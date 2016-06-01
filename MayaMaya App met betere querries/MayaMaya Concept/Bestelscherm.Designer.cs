namespace MayaMaya_Concept
{
    partial class Bestelscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestelscherm));
            this.btnDiner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDrank = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiner
            // 
            this.btnDiner.Location = new System.Drawing.Point(50, 242);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(189, 56);
            this.btnDiner.TabIndex = 54;
            this.btnDiner.Text = "Diner";
            this.btnDiner.UseVisualStyleBackColor = true;
            this.btnDiner.Click += new System.EventHandler(this.btnDiner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(50, 180);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(189, 56);
            this.btnLunch.TabIndex = 53;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDrank
            // 
            this.btnDrank.Location = new System.Drawing.Point(50, 118);
            this.btnDrank.Name = "btnDrank";
            this.btnDrank.Size = new System.Drawing.Size(189, 56);
            this.btnDrank.TabIndex = 52;
            this.btnDrank.Text = "Drank";
            this.btnDrank.UseVisualStyleBackColor = true;
            this.btnDrank.Click += new System.EventHandler(this.btnDrank_Click);
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
            this.label5.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-14, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.label4.Size = new System.Drawing.Size(315, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Bestellen";
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
            this.btnTerug.TabIndex = 49;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // Bestelscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 482);
            this.Controls.Add(this.btnDiner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnDrank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTerug);
            this.Name = "Bestelscherm";
            this.Text = "Bestelscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiner;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDrank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerug;
    }
}