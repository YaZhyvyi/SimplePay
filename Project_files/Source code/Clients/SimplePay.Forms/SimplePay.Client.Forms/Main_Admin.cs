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
	public partial class Main_Admin : Form
	{
		public Main_Admin()
		{
			InitializeComponent();
		}

		private void ProfileLB_Click(object sender, EventArgs e)
		{
			#region Color
			ViewUHLB.BackColor = Color.White;
			ViewUHLB.ForeColor = Color.Black;
			ViewULB.BackColor = Color.White;
			ViewULB.ForeColor = Color.Black;
			SERLB.BackColor = Color.White;
			SERLB.ForeColor = Color.Black;
			AboutALB.BackColor = Color.White;
			AboutALB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.DimGray;
			ProfileLB.ForeColor = Color.White;
			#endregion Color

		}

		private void ViewUHLB_Click(object sender, EventArgs e)
		{
			#region Color
			ViewUHLB.BackColor = Color.DimGray;
			ViewUHLB.ForeColor = Color.White;
			ViewULB.BackColor = Color.White;
			ViewULB.ForeColor = Color.Black;
			SERLB.BackColor = Color.White;
			SERLB.ForeColor = Color.Black;
			AboutALB.BackColor = Color.White;
			AboutALB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			#endregion Color
		}

		private void ViewULB_Click(object sender, EventArgs e)
		{
			#region Color
			ViewUHLB.BackColor = Color.White;
			ViewUHLB.ForeColor = Color.Black;
			ViewULB.BackColor = Color.DimGray;
			ViewULB.ForeColor = Color.White;
			SERLB.BackColor = Color.White;
			SERLB.ForeColor = Color.Black;
			AboutALB.BackColor = Color.White;
			AboutALB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			#endregion Color
		}

		private void SERLB_Click(object sender, EventArgs e)
		{
			#region Color
			ViewUHLB.BackColor = Color.White;
			ViewUHLB.ForeColor = Color.Black;
			ViewULB.BackColor = Color.White;
			ViewULB.ForeColor = Color.Black;
			SERLB.BackColor = Color.DimGray;
			SERLB.ForeColor = Color.White;
			AboutALB.BackColor = Color.White;
			AboutALB.ForeColor = Color.Black;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			#endregion Color
		}

		private void AboutALB_Click(object sender, EventArgs e)
		{
			#region Color
			ViewUHLB.BackColor = Color.White;
			ViewUHLB.ForeColor = Color.Black;
			ViewULB.BackColor = Color.White;
			ViewULB.ForeColor = Color.Black;
			SERLB.BackColor = Color.White;
			SERLB.ForeColor = Color.Black;
			AboutALB.BackColor = Color.DimGray;
			AboutALB.ForeColor = Color.White;
			ProfileLB.BackColor = Color.White;
			ProfileLB.ForeColor = Color.Black;
			#endregion Color
		}
	}
}
