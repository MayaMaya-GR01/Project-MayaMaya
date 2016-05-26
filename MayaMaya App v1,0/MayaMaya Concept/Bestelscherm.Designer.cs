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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnBijvoegen = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(69, 118);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(185, 186);
            this.lstItems.TabIndex = 0;
            // 
            // btnBijvoegen
            // 
            this.btnBijvoegen.Location = new System.Drawing.Point(40, 397);
            this.btnBijvoegen.Name = "btnBijvoegen";
            this.btnBijvoegen.Size = new System.Drawing.Size(107, 53);
            this.btnBijvoegen.TabIndex = 1;
            this.btnBijvoegen.Text = "Bijvoegen";
            this.btnBijvoegen.UseVisualStyleBackColor = true;
            this.btnBijvoegen.Click += new System.EventHandler(this.btnBijvoegen_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(188, 397);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(107, 53);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Bestelscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 495);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBijvoegen);
            this.Controls.Add(this.lstItems);
            this.Name = "Bestelscherm";
            this.Text = "Bestelscherm";
            this.Load += new System.EventHandler(this.Bestelscherm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnBijvoegen;
        private System.Windows.Forms.Button btnCheck;
    }
}