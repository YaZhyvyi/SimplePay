namespace SimplePay_Client_Forms.UserControls
{
    partial class Transfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberofinputaccountTextbox = new System.Windows.Forms.TextBox();
            this.CurrencyTextbox = new System.Windows.Forms.TextBox();
            this.NumberTextbox = new System.Windows.Forms.TextBox();
            this.Numberofoutputaccounttextbox = new System.Windows.Forms.TextBox();
            this.Sendmoneybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of input account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter number of output account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter number";
            // 
            // NumberofinputaccountTextbox
            // 
            this.NumberofinputaccountTextbox.Location = new System.Drawing.Point(45, 44);
            this.NumberofinputaccountTextbox.Name = "NumberofinputaccountTextbox";
            this.NumberofinputaccountTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumberofinputaccountTextbox.TabIndex = 1;
            // 
            // CurrencyTextbox
            // 
            this.CurrencyTextbox.Location = new System.Drawing.Point(45, 121);
            this.CurrencyTextbox.Name = "CurrencyTextbox";
            this.CurrencyTextbox.Size = new System.Drawing.Size(100, 20);
            this.CurrencyTextbox.TabIndex = 1;
            // 
            // NumberTextbox
            // 
            this.NumberTextbox.Location = new System.Drawing.Point(387, 121);
            this.NumberTextbox.Name = "NumberTextbox";
            this.NumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextbox.TabIndex = 1;
            // 
            // Numberofoutputaccounttextbox
            // 
            this.Numberofoutputaccounttextbox.Location = new System.Drawing.Point(387, 44);
            this.Numberofoutputaccounttextbox.Name = "Numberofoutputaccounttextbox";
            this.Numberofoutputaccounttextbox.Size = new System.Drawing.Size(100, 20);
            this.Numberofoutputaccounttextbox.TabIndex = 1;
            // 
            // Sendmoneybtn
            // 
            this.Sendmoneybtn.Location = new System.Drawing.Point(151, 44);
            this.Sendmoneybtn.Name = "Sendmoneybtn";
            this.Sendmoneybtn.Size = new System.Drawing.Size(230, 74);
            this.Sendmoneybtn.TabIndex = 2;
            this.Sendmoneybtn.Text = "Send Money";
            this.Sendmoneybtn.UseVisualStyleBackColor = true;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sendmoneybtn);
            this.Controls.Add(this.Numberofoutputaccounttextbox);
            this.Controls.Add(this.NumberTextbox);
            this.Controls.Add(this.CurrencyTextbox);
            this.Controls.Add(this.NumberofinputaccountTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Size = new System.Drawing.Size(593, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberofinputaccountTextbox;
        private System.Windows.Forms.TextBox CurrencyTextbox;
        private System.Windows.Forms.TextBox NumberTextbox;
        private System.Windows.Forms.TextBox Numberofoutputaccounttextbox;
        private System.Windows.Forms.Button Sendmoneybtn;
    }
}
