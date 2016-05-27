namespace MayaMaya_Concept
{
    partial class Itemvoorraadscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Itemvoorraadscherm));
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.nmrTeller = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNieuwItem = new System.Windows.Forms.Button();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmrTeller)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-160, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(400, 3, 400, 3);
            this.label4.Size = new System.Drawing.Size(903, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Item Voorraad";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerwijder.Image = ((System.Drawing.Image)(resources.GetObject("btnVerwijder.Image")));
            this.btnVerwijder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerwijder.Location = new System.Drawing.Point(14, 386);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(261, 40);
            this.btnVerwijder.TabIndex = 62;
            this.btnVerwijder.Text = "Verwijder geslecteerd item";
            this.btnVerwijder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // nmrTeller
            // 
            this.nmrTeller.Location = new System.Drawing.Point(234, 343);
            this.nmrTeller.Name = "nmrTeller";
            this.nmrTeller.Size = new System.Drawing.Size(41, 20);
            this.nmrTeller.TabIndex = 64;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(300, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 33);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(11, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 33);
            this.btnLogout.TabIndex = 67;
            this.btnLogout.Text = "Terug";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(150, 0, 400, 0);
            this.label1.Size = new System.Drawing.Size(550, 2);
            this.label1.TabIndex = 72;
            // 
            // btnNieuwItem
            // 
            this.btnNieuwItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNieuwItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNieuwItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNieuwItem.Image")));
            this.btnNieuwItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNieuwItem.Location = new System.Drawing.Point(301, 386);
            this.btnNieuwItem.Name = "btnNieuwItem";
            this.btnNieuwItem.Size = new System.Drawing.Size(261, 40);
            this.btnNieuwItem.TabIndex = 73;
            this.btnNieuwItem.Text = "Voeg nieuw item toe";
            this.btnNieuwItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNieuwItem.UseVisualStyleBackColor = true;
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerlaag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerlaag.Image = ((System.Drawing.Image)(resources.GetObject("btnVerlaag.Image")));
            this.btnVerlaag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerlaag.Location = new System.Drawing.Point(302, 340);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(115, 23);
            this.btnVerlaag.TabIndex = 74;
            this.btnVerlaag.Text = "Verlaag";
            this.btnVerlaag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerhoog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerhoog.Image = ((System.Drawing.Image)(resources.GetObject("btnVerhoog.Image")));
            this.btnVerhoog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerhoog.Location = new System.Drawing.Point(447, 339);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(115, 23);
            this.btnVerhoog.TabIndex = 75;
            this.btnVerhoog.Text = "Verhoog";
            this.btnVerhoog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 373);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(150, 0, 400, 0);
            this.label2.Size = new System.Drawing.Size(550, 2);
            this.label2.TabIndex = 76;
            // 
            // lstItems
            // 
            this.lstItems.CheckBoxes = true;
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clNaam,
            this.clAantal});
            this.lstItems.Location = new System.Drawing.Point(14, 90);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(549, 238);
            this.lstItems.TabIndex = 77;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 58;
            // 
            // clNaam
            // 
            this.clNaam.Text = "Naam";
            this.clNaam.Width = 400;
            // 
            // clAantal
            // 
            this.clAantal.Text = "Aantal";
            this.clAantal.Width = 102;
            // 
            // Itemvoorraadscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 438);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnVerlaag);
            this.Controls.Add(this.btnNieuwItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.nmrTeller);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label4);
            this.Name = "Itemvoorraadscherm";
            this.Text = "Voorraadscherm";
            this.Load += new System.EventHandler(this.Voorraadscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrTeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.NumericUpDown nmrTeller;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNieuwItem;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clNaam;
        private System.Windows.Forms.ColumnHeader clAantal;


    }
}