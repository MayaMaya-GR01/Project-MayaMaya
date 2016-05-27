namespace MayaMaya_Concept
{
    partial class Checkscherm
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lstbxCheckbestelling = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(43, 365);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(93, 48);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnCheckscherm_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(196, 363);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(96, 50);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lstbxCheckbestelling
            // 
            this.lstbxCheckbestelling.FormattingEnabled = true;
            this.lstbxCheckbestelling.Location = new System.Drawing.Point(60, 57);
            this.lstbxCheckbestelling.Name = "lstbxCheckbestelling";
            this.lstbxCheckbestelling.Size = new System.Drawing.Size(216, 212);
            this.lstbxCheckbestelling.TabIndex = 3;
            // 
            // Checkscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 456);
            this.Controls.Add(this.lstbxCheckbestelling);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnTerug);
            this.Name = "Checkscherm";
            this.Text = "Checkscherm";
            this.Load += new System.EventHandler(this.Checkscherm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListBox lstbxCheckbestelling;
    }
}