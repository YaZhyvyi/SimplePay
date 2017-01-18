namespace SimplePay_Client_Forms
{
	partial class Main_User
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.ProfileLB = new System.Windows.Forms.Label();
            this.AccountsLB = new System.Windows.Forms.Label();
            this.PayHLB = new System.Windows.Forms.Label();
            this.TransferLB = new System.Windows.Forms.Label();
            this.AddLB = new System.Windows.Forms.Label();
            this.WithdrawLB = new System.Windows.Forms.Label();
            this.AboutLB = new System.Windows.Forms.Label();
            this.payment1 = new SimplePay_Client_Forms.Payment();
            this.tabAccounts1 = new SimplePay_Client_Forms.TabAccounts();
            this.transfer1 = new SimplePay_Client_Forms.Transfer();
            this.paymentHistory1 = new SimplePay_Client_Forms.PaymentHistory();
            this.profile_UserControl1 = new SimplePay_Client_Forms.Profile_UserControl();
            this.SuspendLayout();
            // 
            // ProfileLB
            // 
            this.ProfileLB.BackColor = System.Drawing.Color.White;
            this.ProfileLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfileLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileLB.Location = new System.Drawing.Point(0, 0);
            this.ProfileLB.Name = "ProfileLB";
            this.ProfileLB.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ProfileLB.Size = new System.Drawing.Size(145, 60);
            this.ProfileLB.TabIndex = 0;
            this.ProfileLB.Text = "Profile";
            this.ProfileLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProfileLB.Click += new System.EventHandler(this.ProfileLB_Click_1);
            // 
            // AccountsLB
            // 
            this.AccountsLB.BackColor = System.Drawing.Color.White;
            this.AccountsLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountsLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountsLB.ForeColor = System.Drawing.Color.Black;
            this.AccountsLB.Location = new System.Drawing.Point(0, 59);
            this.AccountsLB.Name = "AccountsLB";
            this.AccountsLB.Size = new System.Drawing.Size(145, 59);
            this.AccountsLB.TabIndex = 1;
            this.AccountsLB.Text = "Accounts";
            this.AccountsLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AccountsLB.Click += new System.EventHandler(this.AccountsLB_Click);
            // 
            // PayHLB
            // 
            this.PayHLB.BackColor = System.Drawing.Color.White;
            this.PayHLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayHLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayHLB.Location = new System.Drawing.Point(0, 117);
            this.PayHLB.Name = "PayHLB";
            this.PayHLB.Size = new System.Drawing.Size(145, 59);
            this.PayHLB.TabIndex = 2;
            this.PayHLB.Text = "Payment History";
            this.PayHLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayHLB.Click += new System.EventHandler(this.PayHLB_Click);
            // 
            // TransferLB
            // 
            this.TransferLB.BackColor = System.Drawing.Color.White;
            this.TransferLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferLB.Location = new System.Drawing.Point(0, 175);
            this.TransferLB.Name = "TransferLB";
            this.TransferLB.Size = new System.Drawing.Size(145, 59);
            this.TransferLB.TabIndex = 3;
            this.TransferLB.Text = "Transfer";
            this.TransferLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TransferLB.Click += new System.EventHandler(this.TransferLB_Click);
            // 
            // AddLB
            // 
            this.AddLB.BackColor = System.Drawing.Color.White;
            this.AddLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLB.Location = new System.Drawing.Point(0, 233);
            this.AddLB.Name = "AddLB";
            this.AddLB.Size = new System.Drawing.Size(145, 59);
            this.AddLB.TabIndex = 4;
            this.AddLB.Text = "Add";
            this.AddLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddLB.Click += new System.EventHandler(this.AddLB_Click);
            // 
            // WithdrawLB
            // 
            this.WithdrawLB.BackColor = System.Drawing.Color.White;
            this.WithdrawLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WithdrawLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithdrawLB.Location = new System.Drawing.Point(0, 291);
            this.WithdrawLB.Name = "WithdrawLB";
            this.WithdrawLB.Size = new System.Drawing.Size(145, 59);
            this.WithdrawLB.TabIndex = 5;
            this.WithdrawLB.Text = "Withdraw";
            this.WithdrawLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WithdrawLB.Click += new System.EventHandler(this.WithdrawLB_Click);
            // 
            // AboutLB
            // 
            this.AboutLB.BackColor = System.Drawing.Color.White;
            this.AboutLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboutLB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLB.Location = new System.Drawing.Point(0, 349);
            this.AboutLB.Name = "AboutLB";
            this.AboutLB.Size = new System.Drawing.Size(145, 59);
            this.AboutLB.TabIndex = 6;
            this.AboutLB.Text = "About";
            this.AboutLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutLB.Click += new System.EventHandler(this.AboutLB_Click);
            // 
            // payment1
            // 
            this.payment1.Location = new System.Drawing.Point(145, 0);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(594, 409);
            this.payment1.TabIndex = 11;
            this.payment1.Visible = false;
            // 
            // tabAccounts1
            // 
            this.tabAccounts1.Location = new System.Drawing.Point(146, 0);
            this.tabAccounts1.Name = "tabAccounts1";
            this.tabAccounts1.Size = new System.Drawing.Size(593, 409);
            this.tabAccounts1.TabIndex = 10;
            this.tabAccounts1.Visible = false;
            // 
            // transfer1
            // 
            this.transfer1.Location = new System.Drawing.Point(170, 259);
            this.transfer1.Name = "transfer1";
            this.transfer1.Size = new System.Drawing.Size(593, 409);
            this.transfer1.TabIndex = 9;
            this.transfer1.Visible = false;
            // 
            // paymentHistory1
            // 
            this.paymentHistory1.Location = new System.Drawing.Point(148, 0);
            this.paymentHistory1.Name = "paymentHistory1";
            this.paymentHistory1.Size = new System.Drawing.Size(593, 409);
            this.paymentHistory1.TabIndex = 8;
            this.paymentHistory1.Visible = false;
            // 
            // profile_UserControl1
            // 
            this.profile_UserControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.profile_UserControl1.Enabled = false;
            this.profile_UserControl1.Location = new System.Drawing.Point(148, 0);
            this.profile_UserControl1.Name = "profile_UserControl1";
            this.profile_UserControl1.Size = new System.Drawing.Size(593, 408);
            this.profile_UserControl1.TabIndex = 7;
            this.profile_UserControl1.Visible = false;
            // 
            // Main_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 408);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.tabAccounts1);
            this.Controls.Add(this.transfer1);
            this.Controls.Add(this.paymentHistory1);
            this.Controls.Add(this.profile_UserControl1);
            this.Controls.Add(this.AboutLB);
            this.Controls.Add(this.WithdrawLB);
            this.Controls.Add(this.AddLB);
            this.Controls.Add(this.TransferLB);
            this.Controls.Add(this.PayHLB);
            this.Controls.Add(this.AccountsLB);
            this.Controls.Add(this.ProfileLB);
            this.Name = "Main_User";
            this.Text = "SimplePay: @User";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label ProfileLB;
		private System.Windows.Forms.Label AccountsLB;
		private System.Windows.Forms.Label PayHLB;
		private System.Windows.Forms.Label TransferLB;
		private System.Windows.Forms.Label AddLB;
		private System.Windows.Forms.Label WithdrawLB;
		private System.Windows.Forms.Label AboutLB;
		private Profile_UserControl profile_UserControl1;
		private PaymentHistory paymentHistory1;
		private Transfer transfer1;
		private SimplePay_Client_Forms.TabAccounts tabAccounts1;
		private SimplePay_Client_Forms.Payment payment1;
	}
}