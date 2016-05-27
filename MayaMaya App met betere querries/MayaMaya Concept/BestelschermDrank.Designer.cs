namespace MayaMaya_Concept
{
    partial class BestelschermDrank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestelschermDrank));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnFrisdrank = new System.Windows.Forms.Button();
            this.btnBier = new System.Windows.Forms.Button();
            this.btnGedest = new System.Windows.Forms.Button();
            this.btnWijn = new System.Windows.Forms.Button();
            this.btnKot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(135, 0, 135, 0);
            this.label5.Size = new System.Drawing.Size(270, 2);
            this.label5.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-27, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.label4.Size = new System.Drawing.Size(359, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Drank Bestellen";
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(9, 32);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(125, 33);
            this.btnTerug.TabIndex = 40;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnFrisdrank
            // 
            this.btnFrisdrank.Location = new System.Drawing.Point(50, 118);
            this.btnFrisdrank.Name = "btnFrisdrank";
            this.btnFrisdrank.Size = new System.Drawing.Size(189, 56);
            this.btnFrisdrank.TabIndex = 44;
            this.btnFrisdrank.Text = "Frisdrank";
            this.btnFrisdrank.UseVisualStyleBackColor = true;
            // 
            // btnBier
            // 
            this.btnBier.Location = new System.Drawing.Point(50, 180);
            this.btnBier.Name = "btnBier";
            this.btnBier.Size = new System.Drawing.Size(189, 56);
            this.btnBier.TabIndex = 45;
            this.btnBier.Text = "Bier";
            this.btnBier.UseVisualStyleBackColor = true;
            // 
            // btnGedest
            // 
            this.btnGedest.Location = new System.Drawing.Point(50, 304);
            this.btnGedest.Name = "btnGedest";
            this.btnGedest.Size = new System.Drawing.Size(189, 56);
            this.btnGedest.TabIndex = 47;
            this.btnGedest.Text = "Gedestilleerd";
            this.btnGedest.UseVisualStyleBackColor = true;
            // 
            // btnWijn
            // 
            this.btnWijn.Location = new System.Drawing.Point(50, 242);
            this.btnWijn.Name = "btnWijn";
            this.btnWijn.Size = new System.Drawing.Size(189, 56);
            this.btnWijn.TabIndex = 46;
            this.btnWijn.Text = "Wijn";
            this.btnWijn.UseVisualStyleBackColor = true;
            // 
            // btnKot
            // 
            this.btnKot.Location = new System.Drawing.Point(50, 366);
            this.btnKot.Name = "btnKot";
            this.btnKot.Size = new System.Drawing.Size(189, 56);
            this.btnKot.TabIndex = 48;
            this.btnKot.Text = "Koffie / Thee";
            this.btnKot.UseVisualStyleBackColor = true;
            // 
            // BestelschermDrank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 482);
            this.Controls.Add(this.btnKot);
            this.Controls.Add(this.btnGedest);
            this.Controls.Add(this.btnWijn);
            this.Controls.Add(this.btnBier);
            this.Controls.Add(this.btnFrisdrank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTerug);
            this.Name = "BestelschermDrank";
            this.Text = "BestelschermDrank";
            this.Load += new System.EventHandler(this.BestelschermDrank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnFrisdrank;
        private System.Windows.Forms.Button btnBier;
        private System.Windows.Forms.Button btnGedest;
        private System.Windows.Forms.Button btnWijn;
        private System.Windows.Forms.Button btnKot;
    }
}