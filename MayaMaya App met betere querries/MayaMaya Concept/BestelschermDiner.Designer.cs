namespace MayaMaya_Concept
{
    partial class BestelschermDiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestelschermDiner));
            this.btnNa = new System.Windows.Forms.Button();
            this.btnHoofd = new System.Windows.Forms.Button();
            this.btnTussen = new System.Windows.Forms.Button();
            this.btnVoor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblPersoneel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNa
            // 
            this.btnNa.Location = new System.Drawing.Point(51, 304);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(189, 56);
            this.btnNa.TabIndex = 55;
            this.btnNa.Text = "Nagerechten";
            this.btnNa.UseVisualStyleBackColor = true;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // btnHoofd
            // 
            this.btnHoofd.Location = new System.Drawing.Point(51, 242);
            this.btnHoofd.Name = "btnHoofd";
            this.btnHoofd.Size = new System.Drawing.Size(189, 56);
            this.btnHoofd.TabIndex = 54;
            this.btnHoofd.Text = "Hoofdgerechten";
            this.btnHoofd.UseVisualStyleBackColor = true;
            this.btnHoofd.Click += new System.EventHandler(this.btnHoofd_Click);
            // 
            // btnTussen
            // 
            this.btnTussen.Location = new System.Drawing.Point(51, 180);
            this.btnTussen.Name = "btnTussen";
            this.btnTussen.Size = new System.Drawing.Size(189, 56);
            this.btnTussen.TabIndex = 53;
            this.btnTussen.Text = "Tussengerechten";
            this.btnTussen.UseVisualStyleBackColor = true;
            this.btnTussen.Click += new System.EventHandler(this.btnTussen_Click);
            // 
            // btnVoor
            // 
            this.btnVoor.Location = new System.Drawing.Point(51, 118);
            this.btnVoor.Name = "btnVoor";
            this.btnVoor.Size = new System.Drawing.Size(189, 56);
            this.btnVoor.TabIndex = 52;
            this.btnVoor.Text = "Voorgerechten";
            this.btnVoor.UseVisualStyleBackColor = true;
            this.btnVoor.Click += new System.EventHandler(this.btnVoor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(135, 0, 135, 0);
            this.label5.Size = new System.Drawing.Size(270, 2);
            this.label5.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-26, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.label4.Size = new System.Drawing.Size(354, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Diner Bestellen";
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(10, 32);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(125, 33);
            this.btnTerug.TabIndex = 49;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lblPersoneel
            // 
            this.lblPersoneel.AutoSize = true;
            this.lblPersoneel.Location = new System.Drawing.Point(12, 77);
            this.lblPersoneel.Name = "lblPersoneel";
            this.lblPersoneel.Size = new System.Drawing.Size(35, 13);
            this.lblPersoneel.TabIndex = 56;
            this.lblPersoneel.Text = "label1";
            // 
            // BestelschermDiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 482);
            this.Controls.Add(this.lblPersoneel);
            this.Controls.Add(this.btnNa);
            this.Controls.Add(this.btnHoofd);
            this.Controls.Add(this.btnTussen);
            this.Controls.Add(this.btnVoor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTerug);
            this.Name = "BestelschermDiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BestelschermDiner";
            this.Load += new System.EventHandler(this.BestelschermDiner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.Button btnHoofd;
        private System.Windows.Forms.Button btnTussen;
        private System.Windows.Forms.Button btnVoor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblPersoneel;
    }
}