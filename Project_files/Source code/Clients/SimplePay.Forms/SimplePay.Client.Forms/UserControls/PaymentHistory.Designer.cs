namespace SimplePay_Client_Forms
{
    partial class PaymentHistory
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
            this.dgvPH = new System.Windows.Forms.DataGridView();
            this.pnlPager = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPH
            // 
            this.dgvPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPH.Location = new System.Drawing.Point(24, 24);
            this.dgvPH.Name = "dgvPH";
            this.dgvPH.Size = new System.Drawing.Size(546, 343);
            this.dgvPH.TabIndex = 0;
            // 
            // pnlPager
            // 
            this.pnlPager.Location = new System.Drawing.Point(24, 373);
            this.pnlPager.Name = "pnlPager";
            this.pnlPager.Size = new System.Drawing.Size(546, 33);
            this.pnlPager.TabIndex = 1;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPager);
            this.Controls.Add(this.dgvPH);
            this.Name = "PaymentHistory";
            this.Size = new System.Drawing.Size(593, 409);
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPH;
        private System.Windows.Forms.Panel pnlPager;
    }
}
