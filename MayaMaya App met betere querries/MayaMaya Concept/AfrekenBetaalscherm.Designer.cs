namespace MayaMaya_Concept
{
    partial class AfrekenBetaalscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfrekenBetaalscherm));
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblTafel = new System.Windows.Forms.Label();
            this.lblRekening = new System.Windows.Forms.Label();
            this.lblFooi = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.lblRekeningBedrag = new System.Windows.Forms.Label();
            this.lblTotaalBedrag = new System.Windows.Forms.Label();
            this.btnContant = new System.Windows.Forms.Button();
            this.btnCreditcard = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.txtFooi = new System.Windows.Forms.TextBox();
            this.lblBetaalMet = new System.Windows.Forms.Label();
            this.lstBetaalscherm = new System.Windows.Forms.ListView();
            this.clmnAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.Image = ((System.Drawing.Image)(resources.GetObject("btnTerug.Image")));
            this.btnTerug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerug.Location = new System.Drawing.Point(11, 47);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(128, 33);
            this.btnTerug.TabIndex = 40;
            this.btnTerug.Text = "Terug";
            this.btnTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(150, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 33);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Silver;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(-29, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Padding = new System.Windows.Forms.Padding(125, 3, 120, 3);
            this.lblTitel.Size = new System.Drawing.Size(377, 26);
            this.lblTitel.TabIndex = 46;
            this.lblTitel.Text = "Rekeningoverzicht";
            // 
            // lblTafel
            // 
            this.lblTafel.AutoSize = true;
            this.lblTafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafel.Location = new System.Drawing.Point(108, 112);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(44, 17);
            this.lblTafel.TabIndex = 47;
            this.lblTafel.Text = "Tafel:";
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekening.Location = new System.Drawing.Point(80, 377);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(72, 17);
            this.lblRekening.TabIndex = 48;
            this.lblRekening.Text = "Rekening:";
            // 
            // lblFooi
            // 
            this.lblFooi.AutoSize = true;
            this.lblFooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooi.Location = new System.Drawing.Point(113, 404);
            this.lblFooi.Name = "lblFooi";
            this.lblFooi.Size = new System.Drawing.Size(39, 17);
            this.lblFooi.TabIndex = 49;
            this.lblFooi.Text = "Fooi:";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(103, 430);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(52, 17);
            this.lblTotaal.TabIndex = 50;
            this.lblTotaal.Text = "Totaal:";
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafelnummer.Location = new System.Drawing.Point(169, 112);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(13, 17);
            this.lblTafelnummer.TabIndex = 57;
            this.lblTafelnummer.Text = "-";
            // 
            // lblRekeningBedrag
            // 
            this.lblRekeningBedrag.AutoSize = true;
            this.lblRekeningBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekeningBedrag.Location = new System.Drawing.Point(169, 377);
            this.lblRekeningBedrag.Name = "lblRekeningBedrag";
            this.lblRekeningBedrag.Size = new System.Drawing.Size(13, 17);
            this.lblRekeningBedrag.TabIndex = 58;
            this.lblRekeningBedrag.Text = "-";
            this.lblRekeningBedrag.Click += new System.EventHandler(this.lblRekeningBedrag_Click);
            // 
            // lblTotaalBedrag
            // 
            this.lblTotaalBedrag.AutoSize = true;
            this.lblTotaalBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaalBedrag.Location = new System.Drawing.Point(169, 430);
            this.lblTotaalBedrag.Name = "lblTotaalBedrag";
            this.lblTotaalBedrag.Size = new System.Drawing.Size(13, 17);
            this.lblTotaalBedrag.TabIndex = 60;
            this.lblTotaalBedrag.Text = "-";
            // 
            // btnContant
            // 
            this.btnContant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContant.Location = new System.Drawing.Point(11, 507);
            this.btnContant.Name = "btnContant";
            this.btnContant.Size = new System.Drawing.Size(75, 33);
            this.btnContant.TabIndex = 63;
            this.btnContant.Text = "Contant";
            this.btnContant.UseVisualStyleBackColor = true;
            this.btnContant.Click += new System.EventHandler(this.btnContant_Click);
            // 
            // btnCreditcard
            // 
            this.btnCreditcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditcard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreditcard.Location = new System.Drawing.Point(203, 507);
            this.btnCreditcard.Name = "btnCreditcard";
            this.btnCreditcard.Size = new System.Drawing.Size(75, 33);
            this.btnCreditcard.TabIndex = 62;
            this.btnCreditcard.Text = "Creditcard";
            this.btnCreditcard.UseVisualStyleBackColor = true;
            this.btnCreditcard.Click += new System.EventHandler(this.btnCreditcard_Click);
            // 
            // btnPin
            // 
            this.btnPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPin.Location = new System.Drawing.Point(107, 507);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(75, 33);
            this.btnPin.TabIndex = 61;
            this.btnPin.Text = "Pin";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // txtFooi
            // 
            this.txtFooi.Location = new System.Drawing.Point(172, 404);
            this.txtFooi.Name = "txtFooi";
            this.txtFooi.Size = new System.Drawing.Size(77, 20);
            this.txtFooi.TabIndex = 64;
            this.txtFooi.Text = "Optioneel";
            // 
            // lblBetaalMet
            // 
            this.lblBetaalMet.AutoSize = true;
            this.lblBetaalMet.Location = new System.Drawing.Point(108, 473);
            this.lblBetaalMet.Name = "lblBetaalMet";
            this.lblBetaalMet.Size = new System.Drawing.Size(63, 13);
            this.lblBetaalMet.TabIndex = 65;
            this.lblBetaalMet.Text = "Betalen met";
            // 
            // lstBetaalscherm
            // 
            this.lstBetaalscherm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnAantal,
            this.clmnNaam,
            this.clmnPrijs});
            this.lstBetaalscherm.Location = new System.Drawing.Point(11, 146);
            this.lstBetaalscherm.Name = "lstBetaalscherm";
            this.lstBetaalscherm.Size = new System.Drawing.Size(267, 214);
            this.lstBetaalscherm.TabIndex = 66;
            this.lstBetaalscherm.UseCompatibleStateImageBehavior = false;
            this.lstBetaalscherm.View = System.Windows.Forms.View.Details;
            this.lstBetaalscherm.SelectedIndexChanged += new System.EventHandler(this.lstBetaalscherm_SelectedIndexChanged);
            // 
            // clmnAantal
            // 
            this.clmnAantal.Text = "Aantal";
            // 
            // clmnNaam
            // 
            this.clmnNaam.Text = "Naam";
            this.clmnNaam.Width = 147;
            // 
            // clmnPrijs
            // 
            this.clmnPrijs.Text = "Prijs";
            this.clmnPrijs.Width = 89;
            // 
            // AfrekenBevestigscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 548);
            this.Controls.Add(this.lstBetaalscherm);
            this.Controls.Add(this.lblBetaalMet);
            this.Controls.Add(this.txtFooi);
            this.Controls.Add(this.btnContant);
            this.Controls.Add(this.btnCreditcard);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.lblTotaalBedrag);
            this.Controls.Add(this.lblRekeningBedrag);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblFooi);
            this.Controls.Add(this.lblRekening);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRefresh);
            this.Name = "AfrekenBevestigscherm";
            this.Text = "Afrekenscherm";
            this.Load += new System.EventHandler(this.Afrekenscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblTafel;
        private System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.Label lblFooi;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Label lblRekeningBedrag;
        private System.Windows.Forms.Label lblTotaalBedrag;
        private System.Windows.Forms.Button btnContant;
        private System.Windows.Forms.Button btnCreditcard;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.TextBox txtFooi;
        private System.Windows.Forms.Label lblBetaalMet;
        private System.Windows.Forms.ListView lstBetaalscherm;
        private System.Windows.Forms.ColumnHeader clmnAantal;
        private System.Windows.Forms.ColumnHeader clmnNaam;
        private System.Windows.Forms.ColumnHeader clmnPrijs;
    }
}