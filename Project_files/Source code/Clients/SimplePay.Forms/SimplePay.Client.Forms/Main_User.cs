using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePay_Client_Forms
{
	public partial class Main_User : Form
	{
		Profile_UserControl pUC = new Profile_UserControl();
		PaymentHistory payUC = new PaymentHistory();

		public Main_User()
		{
			InitializeComponent();
		}

		private void ProfileLB_Click_1(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.DimGray;
			ProfileLB.ForeColor = Color.White;
			#endregion Color

			Controls.Add(pUC);

			pUC.Visible = true;
			pUC.Dock = DockStyle.Right;

			payUC.Visible = false;
		}

		private void AccountsLB_Click(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.DimGray;
			AccountsLB.ForeColor = Color.White;
			#endregion Color


		}

		private void PayHLB_Click(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.DimGray;
			PayHLB.ForeColor = Color.White;
			#endregion Color

			Controls.Add(payUC);

			payUC.Visible = true;
			payUC.Dock = DockStyle.Right;

			pUC.Visible = false;
		}

		private void TransferLB_Click(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.DimGray;
			TransferLB.ForeColor = Color.White;
			#endregion Color


		}

		private void AddLB_Click(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.DimGray;
			AddLB.ForeColor = Color.White;
			#endregion Color


		}

		private void WithdrawLB_Click(object sender, EventArgs e)
		{
			#region Color
			AboutLB.BackColor = Color.White;
			AboutLB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.DimGray;
			WithdrawLB.ForeColor = Color.White;
			#endregion Color


		}

		private void AboutLB_Click(object sender, EventArgs e)
		{
			#region Color
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			AccountsLB.BackColor = Color.White;
			AccountsLB.ForeColor = Color.Black;
			PayHLB.BackColor = Color.White;
			PayHLB.ForeColor = Color.Black;
			TransferLB.BackColor = Color.White;
			TransferLB.ForeColor = Color.Black;
			AddLB.BackColor = Color.White;
			AddLB.ForeColor = Color.Black;
			WithdrawLB.BackColor = Color.White;
			WithdrawLB.ForeColor = Color.Black;
			AboutLB.BackColor = Color.DimGray;
			AboutLB.ForeColor = Color.White;
            #endregion Color


		}
	}
}
