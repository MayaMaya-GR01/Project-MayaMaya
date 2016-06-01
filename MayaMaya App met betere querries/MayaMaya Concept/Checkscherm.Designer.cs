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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkscherm));
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lstvwCheckBestelling = new System.Windows.Forms.ListView();
            this.btnStuur = new System.Windows.Forms.Button();
            this.lblPersoneel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(44, 389);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(96, 50);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(135, 0, 135, 0);
            this.label5.Size = new System.Drawing.Size(270, 2);
            this.label5.TabIndex = 49;
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
            this.label4.Size = new System.Drawing.Size(365, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Check Bestelling";
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(10, 34);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(125, 33);
            this.btnTerug.TabIndex = 47;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lstvwCheckBestelling
            // 
            this.lstvwCheckBestelling.FullRowSelect = true;
            this.lstvwCheckBestelling.Location = new System.Drawing.Point(12, 119);
            this.lstvwCheckBestelling.MultiSelect = false;
            this.lstvwCheckBestelling.Name = "lstvwCheckBestelling";
            this.lstvwCheckBestelling.Size = new System.Drawing.Size(265, 245);
            this.lstvwCheckBestelling.TabIndex = 50;
            this.lstvwCheckBestelling.UseCompatibleStateImageBehavior = false;
            this.lstvwCheckBestelling.View = System.Windows.Forms.View.Details;
            // 
            // btnStuur
            // 
            this.btnStuur.Location = new System.Drawing.Point(146, 389);
            this.btnStuur.Name = "btnStuur";
            this.btnStuur.Size = new System.Drawing.Size(96, 50);
            this.btnStuur.TabIndex = 51;
            this.btnStuur.Text = "Stuur";
            this.btnStuur.UseVisualStyleBackColor = true;
            this.btnStuur.Click += new System.EventHandler(this.btnStuur_Click);
            // 
            // lblPersoneel
            // 
            this.lblPersoneel.AutoSize = true;
            this.lblPersoneel.Location = new System.Drawing.Point(12, 79);
            this.lblPersoneel.Name = "lblPersoneel";
            this.lblPersoneel.Size = new System.Drawing.Size(35, 13);
            this.lblPersoneel.TabIndex = 52;
            this.lblPersoneel.Text = "label1";
            // 
            // Checkscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 482);
            this.Controls.Add(this.lblPersoneel);
            this.Controls.Add(this.btnStuur);
            this.Controls.Add(this.lstvwCheckBestelling);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijder);
            this.Name = "Checkscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Checkscherm";
            this.Load += new System.EventHandler(this.Checkscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListView lstvwCheckBestelling;
        private System.Windows.Forms.Button btnStuur;
        private System.Windows.Forms.Label lblPersoneel;
    }
}