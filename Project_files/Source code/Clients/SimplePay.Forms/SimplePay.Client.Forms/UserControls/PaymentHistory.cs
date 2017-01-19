using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePay_Client_Forms
{
    public partial class PaymentHistory : UserControl
    {
        DataTable dt;
        public PaymentHistory()
        {
            InitializeComponent();

            dt = new DataTable();

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Card", typeof(string));
            dt.Columns.Add("Info", typeof(string));
            dt.Columns.Add("Sum", typeof(string));
            for (int i = 0; i < 25; i++)
                dt.Rows.Add(new DateTime(2015, 01, i+1), "12345****1234", "платіж", "10.50 грн.");
        }

        //Set the Page Size.
        int PageSize = 3;
        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            this.BindGrid(1);
        }

        private void BindGrid(int pageIndex)
        {
            DataTable currentPage = dt.Clone();
            dt.AsEnumerable().Skip((pageIndex - 1) * PageSize).Take(PageSize).ToList().ForEach(r => currentPage.ImportRow(r));
            dgvPH.DataSource = currentPage;
            int recordCount = dt.Rows.Count;
            this.PopulatePager(recordCount, pageIndex);
        }

        private void PopulatePager(int recordCount, int currentPage)
        {
            List<Page> pages = new List<Page>();
            int startIndex, endIndex;
            int pagerSpan = 5;



            //Calculate the Start and End Index of pages to be displayed.
            double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
            endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add the First Page Button.
                pages.Add(new Page { Text = "First", Value = "1" });

            //Add the Previous Button.
                pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });

            for (int i = startIndex; i <= endIndex; i++)
            {
                pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
            }

            //Add the Next Button.
                pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });

            //Add the Last Button.
                pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });

            //Clear existing Pager Buttons.
            pnlPager.Controls.Clear();

            //Loop and add Buttons for Pager.
            int count = 0;
            foreach (Page page in pages)
            {
                Button btnPage = new Button();
                
                btnPage.Location = new System.Drawing.Point(38 * count, 5);
                btnPage.Size = new System.Drawing.Size(35, 26);

                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.Enabled = !page.Selected;
                btnPage.BackColor = Color.White;
                btnPage.Click += new System.EventHandler(this.Page_Click);

                if (currentPage <= 1 && (page.Text == "First" || page.Text == "<<"))
                {
                    btnPage.Enabled = false;
                }

                if (currentPage == pageCount && (page.Text == ">>" || page.Text == "Last"))
                {
                    btnPage.Enabled = false;
                }

                pnlPager.Controls.Add(btnPage);
                count++;
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button btnPager = (sender as Button);
            this.BindGrid(int.Parse(btnPager.Name));
        }

        public class Page
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public bool Selected { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindGrid(1);
        }
    }
}
