namespace MayaMaya_Concept
{
    partial class NieuweRekening
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
            this.txtTotaalPrijs = new System.Windows.Forms.TextBox();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.lblBedrag_Btw = new System.Windows.Forms.Label();
            this.lblBedragFooi = new System.Windows.Forms.Label();
            this.lblCommentaar = new System.Windows.Forms.Label();
            this.txtCommentaar = new System.Windows.Forms.RichTextBox();
            this.txtBedrag_btw = new System.Windows.Forms.TextBox();
            this.txtBedrag_fooi = new System.Windows.Forms.TextBox();
            this.btnMaakRekening = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTotaalPrijs
            // 
            this.txtTotaalPrijs.Location = new System.Drawing.Point(165, 42);
            this.txtTotaalPrijs.Name = "txtTotaalPrijs";
            this.txtTotaalPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtTotaalPrijs.TabIndex = 0;
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(39, 45);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(58, 13);
            this.lblTotaalPrijs.TabIndex = 1;
            this.lblTotaalPrijs.Text = "Totaalprijs:";
            // 
            // lblBedrag_Btw
            // 
            this.lblBedrag_Btw.AutoSize = true;
            this.lblBedrag_Btw.Location = new System.Drawing.Point(39, 71);
            this.lblBedrag_Btw.Name = "lblBedrag_Btw";
            this.lblBedrag_Btw.Size = new System.Drawing.Size(35, 13);
            this.lblBedrag_Btw.TabIndex = 2;
            this.lblBedrag_Btw.Text = "BTW:";
            // 
            // lblBedragFooi
            // 
            this.lblBedragFooi.AutoSize = true;
            this.lblBedragFooi.Location = new System.Drawing.Point(39, 97);
            this.lblBedragFooi.Name = "lblBedragFooi";
            this.lblBedragFooi.Size = new System.Drawing.Size(30, 13);
            this.lblBedragFooi.TabIndex = 3;
            this.lblBedragFooi.Text = "Fooi:";
            // 
            // lblCommentaar
            // 
            this.lblCommentaar.AutoSize = true;
            this.lblCommentaar.Location = new System.Drawing.Point(39, 130);
            this.lblCommentaar.Name = "lblCommentaar";
            this.lblCommentaar.Size = new System.Drawing.Size(69, 13);
            this.lblCommentaar.TabIndex = 4;
            this.lblCommentaar.Text = "Commentaar:";
            // 
            // txtCommentaar
            // 
            this.txtCommentaar.Location = new System.Drawing.Point(144, 127);
            this.txtCommentaar.Name = "txtCommentaar";
            this.txtCommentaar.Size = new System.Drawing.Size(150, 83);
            this.txtCommentaar.TabIndex = 5;
            this.txtCommentaar.Text = "";
            // 
            // txtBedrag_btw
            // 
            this.txtBedrag_btw.Location = new System.Drawing.Point(165, 68);
            this.txtBedrag_btw.Name = "txtBedrag_btw";
            this.txtBedrag_btw.Size = new System.Drawing.Size(100, 20);
            this.txtBedrag_btw.TabIndex = 6;
            // 
            // txtBedrag_fooi
            // 
            this.txtBedrag_fooi.Location = new System.Drawing.Point(165, 94);
            this.txtBedrag_fooi.Name = "txtBedrag_fooi";
            this.txtBedrag_fooi.Size = new System.Drawing.Size(100, 20);
            this.txtBedrag_fooi.TabIndex = 7;
            // 
            // btnMaakRekening
            // 
            this.btnMaakRekening.Location = new System.Drawing.Point(165, 288);
            this.btnMaakRekening.Name = "btnMaakRekening";
            this.btnMaakRekening.Size = new System.Drawing.Size(100, 44);
            this.btnMaakRekening.TabIndex = 8;
            this.btnMaakRekening.Text = "Maak rekening";
            this.btnMaakRekening.UseVisualStyleBackColor = true;
            this.btnMaakRekening.Click += new System.EventHandler(this.btnMaakRekening_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(42, 288);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(100, 44);
            this.btnTerug.TabIndex = 9;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(119, 241);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(10, 13);
            this.lblException.TabIndex = 10;
            this.lblException.Text = "-";
            // 
            // NieuweRekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 437);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnMaakRekening);
            this.Controls.Add(this.txtBedrag_fooi);
            this.Controls.Add(this.txtBedrag_btw);
            this.Controls.Add(this.txtCommentaar);
            this.Controls.Add(this.lblCommentaar);
            this.Controls.Add(this.lblBedragFooi);
            this.Controls.Add(this.lblBedrag_Btw);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.txtTotaalPrijs);
            this.Name = "NieuweRekening";
            this.Text = "NieuweRekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotaalPrijs;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.Label lblBedrag_Btw;
        private System.Windows.Forms.Label lblBedragFooi;
        private System.Windows.Forms.Label lblCommentaar;
        private System.Windows.Forms.RichTextBox txtCommentaar;
        private System.Windows.Forms.TextBox txtBedrag_btw;
        private System.Windows.Forms.TextBox txtBedrag_fooi;
        private System.Windows.Forms.Button btnMaakRekening;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblException;
    }
}