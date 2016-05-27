namespace MayaMaya_Concept
{
    partial class AfrekenNieuweRekeningscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfrekenNieuweRekeningscherm));
            this.btnMaakRekening = new System.Windows.Forms.Button();
            this.btnOpnemen = new System.Windows.Forms.Button();
            this.lblNieuweRekening = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMaakRekening
            // 
            this.btnMaakRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaakRekening.Location = new System.Drawing.Point(12, 369);
            this.btnMaakRekening.Name = "btnMaakRekening";
            this.btnMaakRekening.Size = new System.Drawing.Size(266, 78);
            this.btnMaakRekening.TabIndex = 92;
            this.btnMaakRekening.Text = "Maak rekening";
            this.btnMaakRekening.UseVisualStyleBackColor = true;
            this.btnMaakRekening.Click += new System.EventHandler(this.btnMaakRekening_Click);
            // 
            // btnOpnemen
            // 
            this.btnOpnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpnemen.Location = new System.Drawing.Point(12, 232);
            this.btnOpnemen.Name = "btnOpnemen";
            this.btnOpnemen.Size = new System.Drawing.Size(266, 78);
            this.btnOpnemen.TabIndex = 91;
            this.btnOpnemen.Text = "Opnemen";
            this.btnOpnemen.UseVisualStyleBackColor = true;
            this.btnOpnemen.Click += new System.EventHandler(this.btnOpnemen_Click);
            // 
            // lblNieuweRekening
            // 
            this.lblNieuweRekening.AutoSize = true;
            this.lblNieuweRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNieuweRekening.Location = new System.Drawing.Point(90, 113);
            this.lblNieuweRekening.Name = "lblNieuweRekening";
            this.lblNieuweRekening.Size = new System.Drawing.Size(117, 17);
            this.lblNieuweRekening.TabIndex = 83;
            this.lblNieuweRekening.Text = "Nieuwe rekening:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Silver;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(-29, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.lblTitel.Size = new System.Drawing.Size(377, 26);
            this.lblTitel.TabIndex = 82;
            this.lblTitel.Text = "Rekeningoverzicht";
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(11, 48);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(128, 33);
            this.btnTerug.TabIndex = 81;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(150, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 33);
            this.btnRefresh.TabIndex = 80;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 93;
            // 
            // AfrekenNieuweRekeningscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 548);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMaakRekening);
            this.Controls.Add(this.btnOpnemen);
            this.Controls.Add(this.lblNieuweRekening);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRefresh);
            this.Name = "AfrekenNieuweRekeningscherm";
            this.Text = "AfrekenNieuweRekeningscherm";
            this.Load += new System.EventHandler(this.AfrekenNieuweRekeningscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaakRekening;
        private System.Windows.Forms.Button btnOpnemen;
        private System.Windows.Forms.Label lblNieuweRekening;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBox1;
    }
}