namespace MayaMaya_Concept
{
    partial class Bereidingscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bereidingscherm));
            this.lblBereidingTitelTekst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstBestellingen = new System.Windows.Forms.ListView();
            this.clBestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTijdVanBestellen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAantalItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLopendeBestellingen = new System.Windows.Forms.Button();
            this.btnGereedBestellingen = new System.Windows.Forms.Button();
            this.btnVoorraad = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListView();
            this.clItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMenucategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGereed = new System.Windows.Forms.Button();
            this.btnInBehandeling = new System.Windows.Forms.Button();
            this.btnWacht = new System.Windows.Forms.Button();
            this.lblBestellingTekst = new System.Windows.Forms.Label();
            this.lblTafelTekst = new System.Windows.Forms.Label();
            this.lblBestellingnummer = new System.Windows.Forms.Label();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.lblTijdVanBestellenTekst = new System.Windows.Forms.Label();
            this.lblTijdVanBestellen = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBereidingTitelTekst
            // 
            this.lblBereidingTitelTekst.AutoSize = true;
            this.lblBereidingTitelTekst.BackColor = System.Drawing.Color.Silver;
            this.lblBereidingTitelTekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBereidingTitelTekst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBereidingTitelTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBereidingTitelTekst.Location = new System.Drawing.Point(-166, 0);
            this.lblBereidingTitelTekst.Name = "lblBereidingTitelTekst";
            this.lblBereidingTitelTekst.Padding = new System.Windows.Forms.Padding(400, 3, 400, 3);
            this.lblBereidingTitelTekst.Size = new System.Drawing.Size(921, 26);
            this.lblBereidingTitelTekst.TabIndex = 46;
            this.lblBereidingTitelTekst.Text = "Bereidingscherm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 83);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(150, 0, 400, 0);
            this.label5.Size = new System.Drawing.Size(550, 2);
            this.label5.TabIndex = 49;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(297, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 33);
            this.btnRefresh.TabIndex = 51;
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
            this.btnLogout.Location = new System.Drawing.Point(8, 37);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 33);
            this.btnLogout.TabIndex = 50;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstBestellingen
            // 
            this.lstBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBestelling,
            this.clTafel,
            this.clTijdVanBestellen,
            this.clAantalItems,
            this.clStatus});
            this.lstBestellingen.FullRowSelect = true;
            this.lstBestellingen.Location = new System.Drawing.Point(8, 183);
            this.lstBestellingen.MultiSelect = false;
            this.lstBestellingen.Name = "lstBestellingen";
            this.lstBestellingen.Size = new System.Drawing.Size(551, 176);
            this.lstBestellingen.TabIndex = 52;
            this.lstBestellingen.UseCompatibleStateImageBehavior = false;
            this.lstBestellingen.View = System.Windows.Forms.View.Details;
            this.lstBestellingen.SelectedIndexChanged += new System.EventHandler(this.lstBestellingen_SelectedIndexChanged);
            // 
            // clBestelling
            // 
            this.clBestelling.Text = "Bestelling";
            this.clBestelling.Width = 58;
            // 
            // clTafel
            // 
            this.clTafel.Text = "Tafel";
            this.clTafel.Width = 61;
            // 
            // clTijdVanBestellen
            // 
            this.clTijdVanBestellen.Text = "Tijd van bestellen";
            this.clTijdVanBestellen.Width = 147;
            // 
            // clAantalItems
            // 
            this.clAantalItems.Text = "Aantal Items";
            this.clAantalItems.Width = 101;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 118;
            // 
            // btnLopendeBestellingen
            // 
            this.btnLopendeBestellingen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLopendeBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLopendeBestellingen.Image = ((System.Drawing.Image)(resources.GetObject("btnLopendeBestellingen.Image")));
            this.btnLopendeBestellingen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLopendeBestellingen.Location = new System.Drawing.Point(10, 97);
            this.btnLopendeBestellingen.Name = "btnLopendeBestellingen";
            this.btnLopendeBestellingen.Size = new System.Drawing.Size(167, 68);
            this.btnLopendeBestellingen.TabIndex = 53;
            this.btnLopendeBestellingen.Text = "Lopende bestellingen";
            this.btnLopendeBestellingen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLopendeBestellingen.UseVisualStyleBackColor = true;
            this.btnLopendeBestellingen.Click += new System.EventHandler(this.btnBestellingen_Click);
            // 
            // btnGereedBestellingen
            // 
            this.btnGereedBestellingen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGereedBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGereedBestellingen.Image = ((System.Drawing.Image)(resources.GetObject("btnGereedBestellingen.Image")));
            this.btnGereedBestellingen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGereedBestellingen.Location = new System.Drawing.Point(200, 97);
            this.btnGereedBestellingen.Name = "btnGereedBestellingen";
            this.btnGereedBestellingen.Size = new System.Drawing.Size(169, 68);
            this.btnGereedBestellingen.TabIndex = 54;
            this.btnGereedBestellingen.Text = "Gereedgemelde bestellingen";
            this.btnGereedBestellingen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGereedBestellingen.UseVisualStyleBackColor = true;
            this.btnGereedBestellingen.Click += new System.EventHandler(this.btnGereedBestellingen_Click);
            // 
            // btnVoorraad
            // 
            this.btnVoorraad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoorraad.Image = ((System.Drawing.Image)(resources.GetObject("btnVoorraad.Image")));
            this.btnVoorraad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoorraad.Location = new System.Drawing.Point(389, 97);
            this.btnVoorraad.Name = "btnVoorraad";
            this.btnVoorraad.Size = new System.Drawing.Size(169, 68);
            this.btnVoorraad.TabIndex = 55;
            this.btnVoorraad.Text = "Voorraad";
            this.btnVoorraad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoorraad.UseVisualStyleBackColor = true;
            this.btnVoorraad.Click += new System.EventHandler(this.btnVoorraad_Click);
            // 
            // lstItems
            // 
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clItem,
            this.clMenucategorie,
            this.clAantal});
            this.lstItems.Enabled = false;
            this.lstItems.Location = new System.Drawing.Point(8, 413);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(551, 177);
            this.lstItems.TabIndex = 56;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            // 
            // clItem
            // 
            this.clItem.Text = "Item";
            this.clItem.Width = 231;
            // 
            // clMenucategorie
            // 
            this.clMenucategorie.Text = "Menucategorie";
            this.clMenucategorie.Width = 143;
            // 
            // clAantal
            // 
            this.clAantal.Text = "Aantal";
            this.clAantal.Width = 92;
            // 
            // btnGereed
            // 
            this.btnGereed.Location = new System.Drawing.Point(389, 609);
            this.btnGereed.Name = "btnGereed";
            this.btnGereed.Size = new System.Drawing.Size(169, 58);
            this.btnGereed.TabIndex = 57;
            this.btnGereed.Text = "Gereed";
            this.btnGereed.UseVisualStyleBackColor = true;
            this.btnGereed.Click += new System.EventHandler(this.btnGereed_Click);
            // 
            // btnInBehandeling
            // 
            this.btnInBehandeling.Location = new System.Drawing.Point(200, 608);
            this.btnInBehandeling.Name = "btnInBehandeling";
            this.btnInBehandeling.Size = new System.Drawing.Size(169, 59);
            this.btnInBehandeling.TabIndex = 58;
            this.btnInBehandeling.Text = "In Behandeling";
            this.btnInBehandeling.UseVisualStyleBackColor = true;
            this.btnInBehandeling.Click += new System.EventHandler(this.btnInBehandeling_Click);
            // 
            // btnWacht
            // 
            this.btnWacht.Location = new System.Drawing.Point(10, 609);
            this.btnWacht.Name = "btnWacht";
            this.btnWacht.Size = new System.Drawing.Size(167, 58);
            this.btnWacht.TabIndex = 59;
            this.btnWacht.Text = "Wacht";
            this.btnWacht.UseVisualStyleBackColor = true;
            this.btnWacht.Click += new System.EventHandler(this.btnWacht_Click);
            // 
            // lblBestellingTekst
            // 
            this.lblBestellingTekst.AutoSize = true;
            this.lblBestellingTekst.Location = new System.Drawing.Point(20, 393);
            this.lblBestellingTekst.Name = "lblBestellingTekst";
            this.lblBestellingTekst.Size = new System.Drawing.Size(55, 13);
            this.lblBestellingTekst.TabIndex = 60;
            this.lblBestellingTekst.Text = "Bestelling:";
            // 
            // lblTafelTekst
            // 
            this.lblTafelTekst.AutoSize = true;
            this.lblTafelTekst.Location = new System.Drawing.Point(110, 393);
            this.lblTafelTekst.Name = "lblTafelTekst";
            this.lblTafelTekst.Size = new System.Drawing.Size(34, 13);
            this.lblTafelTekst.TabIndex = 61;
            this.lblTafelTekst.Text = "Tafel:";
            // 
            // lblBestellingnummer
            // 
            this.lblBestellingnummer.AutoSize = true;
            this.lblBestellingnummer.Location = new System.Drawing.Point(80, 393);
            this.lblBestellingnummer.Name = "lblBestellingnummer";
            this.lblBestellingnummer.Size = new System.Drawing.Size(10, 13);
            this.lblBestellingnummer.TabIndex = 62;
            this.lblBestellingnummer.Text = "-";
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Location = new System.Drawing.Point(150, 393);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(10, 13);
            this.lblTafelnummer.TabIndex = 63;
            this.lblTafelnummer.Text = "-";
            // 
            // lblTijdVanBestellenTekst
            // 
            this.lblTijdVanBestellenTekst.AutoSize = true;
            this.lblTijdVanBestellenTekst.Location = new System.Drawing.Point(200, 393);
            this.lblTijdVanBestellenTekst.Name = "lblTijdVanBestellenTekst";
            this.lblTijdVanBestellenTekst.Size = new System.Drawing.Size(93, 13);
            this.lblTijdVanBestellenTekst.TabIndex = 64;
            this.lblTijdVanBestellenTekst.Text = "Tijd van bestellen:";
            // 
            // lblTijdVanBestellen
            // 
            this.lblTijdVanBestellen.AutoSize = true;
            this.lblTijdVanBestellen.Location = new System.Drawing.Point(300, 393);
            this.lblTijdVanBestellen.Name = "lblTijdVanBestellen";
            this.lblTijdVanBestellen.Size = new System.Drawing.Size(10, 13);
            this.lblTijdVanBestellen.TabIndex = 65;
            this.lblTijdVanBestellen.Text = "-";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(400, 393);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(40, 13);
            this.lblStatusText.TabIndex = 66;
            this.lblStatusText.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(450, 393);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 67;
            this.lblStatus.Text = "-";
            // 
            // Bereidingscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 683);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblTijdVanBestellen);
            this.Controls.Add(this.lblTijdVanBestellenTekst);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.lblBestellingnummer);
            this.Controls.Add(this.lblTafelTekst);
            this.Controls.Add(this.lblBestellingTekst);
            this.Controls.Add(this.btnWacht);
            this.Controls.Add(this.btnInBehandeling);
            this.Controls.Add(this.btnGereed);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnVoorraad);
            this.Controls.Add(this.btnGereedBestellingen);
            this.Controls.Add(this.btnLopendeBestellingen);
            this.Controls.Add(this.lstBestellingen);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBereidingTitelTekst);
            this.Name = "Bereidingscherm";
            this.Text = "Bereidingscherm";
            this.Load += new System.EventHandler(this.Keukenscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblBereidingTitelTekst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        protected System.Windows.Forms.ListView lstBestellingen;
        private System.Windows.Forms.ColumnHeader clBestelling;
        private System.Windows.Forms.ColumnHeader clTafel;
        private System.Windows.Forms.ColumnHeader clTijdVanBestellen;
        private System.Windows.Forms.ColumnHeader clAantalItems;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.Button btnLopendeBestellingen;
        private System.Windows.Forms.Button btnGereedBestellingen;
        private System.Windows.Forms.Button btnVoorraad;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader clItem;
        private System.Windows.Forms.ColumnHeader clMenucategorie;
        private System.Windows.Forms.ColumnHeader clAantal;
        private System.Windows.Forms.Button btnGereed;
        private System.Windows.Forms.Button btnInBehandeling;
        private System.Windows.Forms.Button btnWacht;
        private System.Windows.Forms.Label lblBestellingTekst;
        private System.Windows.Forms.Label lblTafelTekst;
        private System.Windows.Forms.Label lblBestellingnummer;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Label lblTijdVanBestellenTekst;
        private System.Windows.Forms.Label lblTijdVanBestellen;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatus;
    }
}