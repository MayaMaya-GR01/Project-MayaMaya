namespace MayaMaya_Concept
{
    partial class Rekeningenscherm
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
            this.lstRekeningen = new System.Windows.Forms.ListBox();
            this.btnNieuweRekening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRekeningen
            // 
            this.lstRekeningen.FormattingEnabled = true;
            this.lstRekeningen.Location = new System.Drawing.Point(67, 27);
            this.lstRekeningen.Name = "lstRekeningen";
            this.lstRekeningen.Size = new System.Drawing.Size(188, 251);
            this.lstRekeningen.TabIndex = 0;
            // 
            // btnNieuweRekening
            // 
            this.btnNieuweRekening.Location = new System.Drawing.Point(109, 381);
            this.btnNieuweRekening.Name = "btnNieuweRekening";
            this.btnNieuweRekening.Size = new System.Drawing.Size(97, 56);
            this.btnNieuweRekening.TabIndex = 1;
            this.btnNieuweRekening.Text = "Nieuwe rekening";
            this.btnNieuweRekening.UseVisualStyleBackColor = true;
            this.btnNieuweRekening.Click += new System.EventHandler(this.btnNieuweRekening_Click);
            // 
            // Rekeningenscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 525);
            this.Controls.Add(this.btnNieuweRekening);
            this.Controls.Add(this.lstRekeningen);
            this.Name = "Rekeningenscherm";
            this.Text = "Rekeningenscherm";
            this.Load += new System.EventHandler(this.Rekeningenscherm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRekeningen;
        private System.Windows.Forms.Button btnNieuweRekening;
    }
}