namespace Lena_Hotel
{
    partial class StatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatClient));
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewresa = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Occupant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_enregistrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Entrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Sortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numchambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedModification = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedRfreshResa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateTimePickersearch = new System.Windows.Forms.DateTimePicker();
            this.materialRaisedButtonIndesirable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDesirable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnIndesirable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedResaPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "----Critére de recherche----",
            "Nom",
            "Prenom",
            "Date d\'entré",
            "Date de sortie",
            "Date d\'enregistrement",
            "Numero de telephone",
            "Nationalité",
            "Montant versé",
            "Montant total",
            "Montant versé supérieur à"});
            this.comboBoxSearch.Location = new System.Drawing.Point(11, 235);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(233, 21);
            this.comboBoxSearch.TabIndex = 0;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(1204, 233);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(71, 23);
            this.materialRaisedButton4.TabIndex = 60;
            this.materialRaisedButton4.Text = "Sortir";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(992, 233);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(206, 23);
            this.materialRaisedButton3.TabIndex = 59;
            this.materialRaisedButton3.Text = "Supprimer une Reservation";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButtonSearch
            // 
            this.materialRaisedButtonSearch.Depth = 0;
            this.materialRaisedButtonSearch.Location = new System.Drawing.Point(530, 233);
            this.materialRaisedButtonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSearch.Name = "materialRaisedButtonSearch";
            this.materialRaisedButtonSearch.Primary = true;
            this.materialRaisedButtonSearch.Size = new System.Drawing.Size(100, 23);
            this.materialRaisedButtonSearch.TabIndex = 58;
            this.materialRaisedButtonSearch.Text = "Rechercher";
            this.materialRaisedButtonSearch.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSearch.Click += new System.EventHandler(this.materialRaisedButtonSearch_Click);
            // 
            // dataGridViewresa
            // 
            this.dataGridViewresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.Telephone,
            this.Nationalité,
            this.Profession,
            this.Sexe,
            this.Nombre_Occupant,
            this.montant_v,
            this.Montant_Total,
            this.reste,
            this.Date_enregistrement,
            this.Date_Entrer,
            this.Date_Sortie,
            this.numchambre,
            this.status});
            this.dataGridViewresa.Location = new System.Drawing.Point(11, 325);
            this.dataGridViewresa.Name = "dataGridViewresa";
            this.dataGridViewresa.Size = new System.Drawing.Size(1264, 435);
            this.dataGridViewresa.TabIndex = 63;
            this.dataGridViewresa.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewresa_CellValueChanged);
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Numero";
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Nationalité
            // 
            this.Nationalité.DataPropertyName = "Nationalite";
            this.Nationalité.HeaderText = "Nationalité";
            this.Nationalité.Name = "Nationalité";
            this.Nationalité.ReadOnly = true;
            // 
            // Profession
            // 
            this.Profession.DataPropertyName = "Proffession";
            this.Profession.HeaderText = "Profession";
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            // 
            // Sexe
            // 
            this.Sexe.DataPropertyName = "sexe";
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.ReadOnly = true;
            // 
            // Nombre_Occupant
            // 
            this.Nombre_Occupant.DataPropertyName = "nbrePersonne";
            this.Nombre_Occupant.HeaderText = "Nombre d\'occupant";
            this.Nombre_Occupant.Name = "Nombre_Occupant";
            this.Nombre_Occupant.ReadOnly = true;
            // 
            // montant_v
            // 
            this.montant_v.DataPropertyName = "Montant_Verse";
            this.montant_v.HeaderText = "Montant Versé";
            this.montant_v.Name = "montant_v";
            this.montant_v.ReadOnly = true;
            // 
            // Montant_Total
            // 
            this.Montant_Total.DataPropertyName = "Montant_Total";
            this.Montant_Total.HeaderText = "Montant Total";
            this.Montant_Total.Name = "Montant_Total";
            this.Montant_Total.ReadOnly = true;
            // 
            // reste
            // 
            this.reste.DataPropertyName = "MontantReste";
            this.reste.HeaderText = "Reste";
            this.reste.Name = "reste";
            // 
            // Date_enregistrement
            // 
            this.Date_enregistrement.DataPropertyName = "DateDuJour";
            this.Date_enregistrement.HeaderText = "Date d\'enregistrement";
            this.Date_enregistrement.Name = "Date_enregistrement";
            this.Date_enregistrement.ReadOnly = true;
            // 
            // Date_Entrer
            // 
            this.Date_Entrer.DataPropertyName = "DateDebut";
            this.Date_Entrer.HeaderText = "Date d\'entrée";
            this.Date_Entrer.Name = "Date_Entrer";
            this.Date_Entrer.ReadOnly = true;
            // 
            // Date_Sortie
            // 
            this.Date_Sortie.DataPropertyName = "DateFin";
            this.Date_Sortie.HeaderText = "Date de Sortie";
            this.Date_Sortie.Name = "Date_Sortie";
            this.Date_Sortie.ReadOnly = true;
            // 
            // numchambre
            // 
            this.numchambre.DataPropertyName = "NumChambre";
            this.numchambre.HeaderText = "Num Chambre";
            this.numchambre.Name = "numchambre";
            this.numchambre.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Indesirable ?";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 185);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1289, 30);
            this.materialTabSelector1.TabIndex = 65;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialRaisedModification
            // 
            this.materialRaisedModification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedModification.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialRaisedModification.Depth = 0;
            this.materialRaisedModification.Location = new System.Drawing.Point(919, 233);
            this.materialRaisedModification.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedModification.Name = "materialRaisedModification";
            this.materialRaisedModification.Primary = true;
            this.materialRaisedModification.Size = new System.Drawing.Size(67, 23);
            this.materialRaisedModification.TabIndex = 66;
            this.materialRaisedModification.Text = "Modifier";
            this.materialRaisedModification.UseVisualStyleBackColor = false;
            this.materialRaisedModification.Click += new System.EventHandler(this.materialRaisedModification_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1289, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedRfreshResa
            // 
            this.materialRaisedRfreshResa.Depth = 0;
            this.materialRaisedRfreshResa.Location = new System.Drawing.Point(636, 233);
            this.materialRaisedRfreshResa.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedRfreshResa.Name = "materialRaisedRfreshResa";
            this.materialRaisedRfreshResa.Primary = true;
            this.materialRaisedRfreshResa.Size = new System.Drawing.Size(92, 23);
            this.materialRaisedRfreshResa.TabIndex = 67;
            this.materialRaisedRfreshResa.Text = "Actualiser";
            this.materialRaisedRfreshResa.UseVisualStyleBackColor = true;
            this.materialRaisedRfreshResa.Click += new System.EventHandler(this.materialRaisedRfreshResa_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(260, 235);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 68;
            // 
            // dateTimePickersearch
            // 
            this.dateTimePickersearch.Location = new System.Drawing.Point(260, 236);
            this.dateTimePickersearch.Name = "dateTimePickersearch";
            this.dateTimePickersearch.Size = new System.Drawing.Size(252, 20);
            this.dateTimePickersearch.TabIndex = 69;
            // 
            // materialRaisedButtonIndesirable
            // 
            this.materialRaisedButtonIndesirable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonIndesirable.Depth = 0;
            this.materialRaisedButtonIndesirable.Location = new System.Drawing.Point(747, 231);
            this.materialRaisedButtonIndesirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonIndesirable.Name = "materialRaisedButtonIndesirable";
            this.materialRaisedButtonIndesirable.Primary = true;
            this.materialRaisedButtonIndesirable.Size = new System.Drawing.Size(166, 24);
            this.materialRaisedButtonIndesirable.TabIndex = 70;
            this.materialRaisedButtonIndesirable.Text = "Désirable/indésirable";
            this.materialRaisedButtonIndesirable.UseVisualStyleBackColor = true;
            this.materialRaisedButtonIndesirable.Click += new System.EventHandler(this.materialRaisedButtonIndesirable_Click);
            // 
            // btnDesirable
            // 
            this.btnDesirable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesirable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesirable.Depth = 0;
            this.btnDesirable.Location = new System.Drawing.Point(734, 274);
            this.btnDesirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesirable.Name = "btnDesirable";
            this.btnDesirable.Primary = true;
            this.btnDesirable.Size = new System.Drawing.Size(132, 23);
            this.btnDesirable.TabIndex = 71;
            this.btnDesirable.Text = "Desirable";
            this.btnDesirable.UseVisualStyleBackColor = false;
            this.btnDesirable.Click += new System.EventHandler(this.btnDesirable_Click);
            // 
            // BtnIndesirable
            // 
            this.BtnIndesirable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIndesirable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIndesirable.Depth = 0;
            this.BtnIndesirable.Location = new System.Drawing.Point(734, 233);
            this.BtnIndesirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIndesirable.Name = "BtnIndesirable";
            this.BtnIndesirable.Primary = true;
            this.BtnIndesirable.Size = new System.Drawing.Size(132, 23);
            this.BtnIndesirable.TabIndex = 72;
            this.BtnIndesirable.Text = "Indesirable";
            this.BtnIndesirable.UseVisualStyleBackColor = false;
            this.BtnIndesirable.Click += new System.EventHandler(this.BtnIndesirable_Click);
            // 
            // materialRaisedResaPrint
            // 
            this.materialRaisedResaPrint.Depth = 0;
            this.materialRaisedResaPrint.Location = new System.Drawing.Point(919, 274);
            this.materialRaisedResaPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedResaPrint.Name = "materialRaisedResaPrint";
            this.materialRaisedResaPrint.Primary = true;
            this.materialRaisedResaPrint.Size = new System.Drawing.Size(79, 23);
            this.materialRaisedResaPrint.TabIndex = 73;
            this.materialRaisedResaPrint.Text = "Imprimer";
            this.materialRaisedResaPrint.UseVisualStyleBackColor = true;
            this.materialRaisedResaPrint.Click += new System.EventHandler(this.materialRaisedResaPrint_Click);
            // 
            // StatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 772);
            this.Controls.Add(this.materialRaisedResaPrint);
            this.Controls.Add(this.BtnIndesirable);
            this.Controls.Add(this.btnDesirable);
            this.Controls.Add(this.materialRaisedButtonIndesirable);
            this.Controls.Add(this.dateTimePickersearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialRaisedRfreshResa);
            this.Controls.Add(this.materialRaisedModification);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewresa);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButtonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatClient";
            this.Text = "Formulaire de Recherche  et Modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatClient_FormClosed);
            this.Load += new System.EventHandler(this.StatClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSearch;
        private System.Windows.Forms.DataGridView dataGridViewresa;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedModification;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedRfreshResa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickersearch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonIndesirable;
        private MaterialSkin.Controls.MaterialRaisedButton btnDesirable;
        private MaterialSkin.Controls.MaterialRaisedButton BtnIndesirable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Occupant;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn reste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_enregistrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Entrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Sortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn numchambre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedResaPrint;
    }
}