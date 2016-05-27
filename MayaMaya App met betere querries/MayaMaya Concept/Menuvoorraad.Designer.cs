namespace MayaMaya_Concept
{
    partial class Menuvoorraad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuvoorraad));
            this.btnDiner = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnNieuwItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDrank = new System.Windows.Forms.Button();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDiner
            // 
            this.btnDiner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiner.Image = ((System.Drawing.Image)(resources.GetObject("btnDiner.Image")));
            this.btnDiner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiner.Location = new System.Drawing.Point(13, 91);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(173, 68);
            this.btnDiner.TabIndex = 90;
            this.btnDiner.Text = "Diner menu";
            this.btnDiner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiner.UseVisualStyleBackColor = true;
            this.btnDiner.Click += new System.EventHandler(this.btnDiner_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 373);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(150, 0, 400, 0);
            this.label2.Size = new System.Drawing.Size(550, 2);
            this.label2.TabIndex = 88;
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerhoog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerhoog.Image = ((System.Drawing.Image)(resources.GetObject("btnVerhoog.Image")));
            this.btnVerhoog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerhoog.Location = new System.Drawing.Point(442, 336);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(115, 30);
            this.btnVerhoog.TabIndex = 87;
            this.btnVerhoog.Text = "Pas prijs aan";
            this.btnVerhoog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnNieuwItem
            // 
            this.btnNieuwItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNieuwItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNieuwItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNieuwItem.Image")));
            this.btnNieuwItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNieuwItem.Location = new System.Drawing.Point(300, 386);
            this.btnNieuwItem.Name = "btnNieuwItem";
            this.btnNieuwItem.Size = new System.Drawing.Size(261, 40);
            this.btnNieuwItem.TabIndex = 85;
            this.btnNieuwItem.Text = "Voeg nieuw item toe";
            this.btnNieuwItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNieuwItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(150, 0, 400, 0);
            this.label1.Size = new System.Drawing.Size(550, 2);
            this.label1.TabIndex = 84;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(299, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 33);
            this.btnRefresh.TabIndex = 83;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(12, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 33);
            this.btnLogout.TabIndex = 82;
            this.btnLogout.Text = "Terug";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerwijder.Image = ((System.Drawing.Image)(resources.GetObject("btnVerwijder.Image")));
            this.btnVerwijder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerwijder.Location = new System.Drawing.Point(13, 386);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(261, 40);
            this.btnVerwijder.TabIndex = 80;
            this.btnVerwijder.Text = "Verwijder geslecteerd item";
            this.btnVerwijder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-173, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(400, 3, 400, 3);
            this.label4.Size = new System.Drawing.Size(912, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Menu Voorraad";
            // 
            // btnLunch
            // 
            this.btnLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLunch.Image")));
            this.btnLunch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLunch.Location = new System.Drawing.Point(200, 91);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(176, 68);
            this.btnLunch.TabIndex = 91;
            this.btnLunch.Text = "Lunch menu";
            this.btnLunch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnDrank
            // 
            this.btnDrank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrank.Image = ((System.Drawing.Image)(resources.GetObject("btnDrank.Image")));
            this.btnDrank.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDrank.Location = new System.Drawing.Point(389, 91);
            this.btnDrank.Name = "btnDrank";
            this.btnDrank.Size = new System.Drawing.Size(172, 68);
            this.btnDrank.TabIndex = 92;
            this.btnDrank.Text = "Drank menu";
            this.btnDrank.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrank.UseVisualStyleBackColor = true;
            this.btnDrank.Click += new System.EventHandler(this.btnDrank_Click);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(43, 4);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(64, 20);
            this.txtPrijs.TabIndex = 93;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(13, 170);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(548, 160);
            this.lstItems.TabIndex = 94;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged_1);
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLabel.Controls.Add(this.label3);
            this.pnlLabel.Controls.Add(this.txtPrijs);
            this.pnlLabel.Location = new System.Drawing.Point(324, 336);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(112, 30);
            this.pnlLabel.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Prijs:";
            // 
            // Menuvoorraad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 437);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnDrank);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnDiner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnNieuwItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlLabel);
            this.Name = "Menuvoorraad";
            this.Text = "Dinermenuvoorraad";
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnNieuwItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDrank;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label label3;
    }
}