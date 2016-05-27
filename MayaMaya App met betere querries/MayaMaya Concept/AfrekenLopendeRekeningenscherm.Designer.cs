namespace MayaMaya_Concept
{
    partial class AfrekenLopendeRekeningenscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfrekenLopendeRekeningenscherm));
            this.lstLopendeRekeningen = new System.Windows.Forms.ListView();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblLopendeRekeningen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLopendeRekeningen
            // 
            this.lstLopendeRekeningen.Location = new System.Drawing.Point(11, 140);
            this.lstLopendeRekeningen.Name = "lstLopendeRekeningen";
            this.lstLopendeRekeningen.Size = new System.Drawing.Size(267, 396);
            this.lstLopendeRekeningen.TabIndex = 80;
            this.lstLopendeRekeningen.UseCompatibleStateImageBehavior = false;
            this.lstLopendeRekeningen.View = System.Windows.Forms.View.Details;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Silver;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(-29, 5);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.lblTitel.Size = new System.Drawing.Size(377, 26);
            this.lblTitel.TabIndex = 68;
            this.lblTitel.Text = "Rekeningoverzicht";
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(11, 43);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(128, 33);
            this.btnTerug.TabIndex = 67;
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
            this.btnRefresh.Location = new System.Drawing.Point(150, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 33);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblLopendeRekeningen
            // 
            this.lblLopendeRekeningen.AutoSize = true;
            this.lblLopendeRekeningen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopendeRekeningen.Location = new System.Drawing.Point(80, 111);
            this.lblLopendeRekeningen.Name = "lblLopendeRekeningen";
            this.lblLopendeRekeningen.Size = new System.Drawing.Size(139, 17);
            this.lblLopendeRekeningen.TabIndex = 81;
            this.lblLopendeRekeningen.Text = "Lopende rekeningen";
            // 
            // AfrekenLopendeRekeningenscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 548);
            this.Controls.Add(this.lblLopendeRekeningen);
            this.Controls.Add(this.lstLopendeRekeningen);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRefresh);
            this.Name = "AfrekenLopendeRekeningenscherm";
            this.Text = "AfrekenLopendeRekeningenscherm";
            this.Load += new System.EventHandler(this.AfrekenLopendeRekeningenscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstLopendeRekeningen;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLopendeRekeningen;
    }
}