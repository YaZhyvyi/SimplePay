namespace SimplePay_Client_Forms
{
    partial class TabAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SelectAccount = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtBoxCurrency = new System.Windows.Forms.TextBox();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.labBalance = new System.Windows.Forms.Label();
            this.labCurrency = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Account";
            // 
            // SelectAccount
            // 
            this.SelectAccount.FormattingEnabled = true;
            this.SelectAccount.Location = new System.Drawing.Point(355, 35);
            this.SelectAccount.Name = "SelectAccount";
            this.SelectAccount.Size = new System.Drawing.Size(199, 21);
            this.SelectAccount.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(378, 372);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accounts";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(136, 372);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(122, 23);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Show full history";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // txtBoxCurrency
            // 
            this.txtBoxCurrency.Location = new System.Drawing.Point(203, 82);
            this.txtBoxCurrency.Name = "txtBoxCurrency";
            this.txtBoxCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCurrency.TabIndex = 5;
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(454, 82);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBalance.TabIndex = 6;
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Location = new System.Drawing.Point(365, 85);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(83, 13);
            this.labBalance.TabIndex = 7;
            this.labBalance.Text = "Current Balance";
            this.labBalance.Click += new System.EventHandler(this.labBalance_Click);
            // 
            // labCurrency
            // 
            this.labCurrency.AutoSize = true;
            this.labCurrency.Location = new System.Drawing.Point(148, 85);
            this.labCurrency.Name = "labCurrency";
            this.labCurrency.Size = new System.Drawing.Size(49, 13);
            this.labCurrency.TabIndex = 8;
            this.labCurrency.Text = "Currency";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 215);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last 10 operations";
            // 
            // TabAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labCurrency);
            this.Controls.Add(this.labBalance);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.txtBoxCurrency);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.SelectAccount);
            this.Controls.Add(this.label1);
            this.Name = "TabAccounts";
            this.Size = new System.Drawing.Size(593, 409);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectAccount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox txtBoxCurrency;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.Label labBalance;
        private System.Windows.Forms.Label labCurrency;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}
