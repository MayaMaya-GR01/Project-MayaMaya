namespace MayaMaya_Concept
{
    partial class Tafelscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tafelscherm));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnOpnemen = new System.Windows.Forms.Button();
            this.btnAfrekenen = new System.Windows.Forms.Button();
            this.btnTafel = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(12, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 33);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(155, 35);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(127, 33);
            this.btnTerug.TabIndex = 37;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnOpnemen
            // 
            this.btnOpnemen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpnemen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpnemen.Image")));
            this.btnOpnemen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpnemen.Location = new System.Drawing.Point(12, 151);
            this.btnOpnemen.Name = "btnOpnemen";
            this.btnOpnemen.Size = new System.Drawing.Size(127, 95);
            this.btnOpnemen.TabIndex = 38;
            this.btnOpnemen.Text = "Opnemen";
            this.btnOpnemen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpnemen.UseVisualStyleBackColor = true;
            this.btnOpnemen.Click += new System.EventHandler(this.btnOpnemen_Click);
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfrekenen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfrekenen.Image = ((System.Drawing.Image)(resources.GetObject("btnAfrekenen.Image")));
            this.btnAfrekenen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAfrekenen.Location = new System.Drawing.Point(157, 151);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(122, 95);
            this.btnAfrekenen.TabIndex = 39;
            this.btnAfrekenen.Text = "Afrekenen";
            this.btnAfrekenen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAfrekenen.UseVisualStyleBackColor = true;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // btnTafel
            // 
            this.btnTafel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTafel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTafel.Image = ((System.Drawing.Image)(resources.GetObject("btnTafel.Image")));
            this.btnTafel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTafel.Location = new System.Drawing.Point(12, 89);
            this.btnTafel.Name = "btnTafel";
            this.btnTafel.Size = new System.Drawing.Size(127, 55);
            this.btnTafel.TabIndex = 40;
            this.btnTafel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTafel.UseVisualStyleBackColor = true;
            this.btnTafel.Click += new System.EventHandler(this.btnTafel_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(13, 255);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(266, 225);
            this.lstItems.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Totaal:";
            // 
            // btnStatus
            // 
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(157, 89);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(122, 55);
            this.btnStatus.TabIndex = 44;
            this.btnStatus.Text = "Status aanpassen";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-12, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.label4.Size = new System.Drawing.Size(317, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Rekening";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(135, 0, 135, 0);
            this.label5.Size = new System.Drawing.Size(270, 2);
            this.label5.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 500);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(135, 0, 135, 0);
            this.label2.Size = new System.Drawing.Size(270, 2);
            this.label2.TabIndex = 47;
            // 
            // Tafelscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnTafel);
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnOpnemen);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Tafelscherm";
            this.Text = "Maya Maya";
            this.Load += new System.EventHandler(this.Tafelklikscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnOpnemen;
        private System.Windows.Forms.Button btnAfrekenen;
        private System.Windows.Forms.Button btnTafel;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;

    }
}