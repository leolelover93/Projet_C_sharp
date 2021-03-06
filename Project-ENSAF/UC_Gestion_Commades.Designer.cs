namespace Project_ENSAF
{
    using System.Drawing;
    using System.Windows.Forms;
    using System.Linq;
    using System.Collections.Generic;

    partial class UC_Gestion_Commades
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Gestion_Commades));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelNbCommande = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.comboBoxFilterCommande = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.bAjoutCommande = new System.Windows.Forms.Button();
            this.panelContainerAjouterCommande = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHiden = new System.Windows.Forms.Label();
            this.panelListeCommande = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveSouhaiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AprouveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelSearchBox.SuspendLayout();
            this.panelContainerAjouterCommande.SuspendLayout();
            this.panelListeCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelHeader.Controls.Add(this.labelNbCommande);
            this.panelHeader.Controls.Add(this.pictureBox);
            this.panelHeader.Controls.Add(this.panelSearchBox);
            this.panelHeader.Controls.Add(this.bAjoutCommande);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.MinimumSize = new System.Drawing.Size(535, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(750, 55);
            this.panelHeader.TabIndex = 3;
            // 
            // labelNbCommande
            // 
            this.labelNbCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNbCommande.AutoSize = true;
            this.labelNbCommande.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbCommande.ForeColor = System.Drawing.Color.White;
            this.labelNbCommande.Location = new System.Drawing.Point(559, 20);
            this.labelNbCommande.Name = "labelNbCommande";
            this.labelNbCommande.Size = new System.Drawing.Size(15, 16);
            this.labelNbCommande.TabIndex = 2;
            this.labelNbCommande.Text = "0";
            this.labelNbCommande.Visible = false;
            this.labelNbCommande.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::Project_ENSAF.Properties.Resources.open_box;
            this.pictureBox.Location = new System.Drawing.Point(519, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(44, 28);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.Controls.Add(this.comboBoxFilterCommande);
            this.panelSearchBox.Controls.Add(this.searchBar);
            this.panelSearchBox.Location = new System.Drawing.Point(9, 9);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(272, 45);
            this.panelSearchBox.TabIndex = 2;
            // 
            // comboBoxFilterCommande
            // 
            this.comboBoxFilterCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.comboBoxFilterCommande.CausesValidation = false;
            this.comboBoxFilterCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilterCommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterCommande.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterCommande.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxFilterCommande.IntegralHeight = false;
            this.comboBoxFilterCommande.ItemHeight = 16;
            this.comboBoxFilterCommande.Items.AddRange(new object[] {
            "Fournisseur",
            "NCommande",
            "Produit"});
            this.comboBoxFilterCommande.Location = new System.Drawing.Point(163, 9);
            this.comboBoxFilterCommande.MaxDropDownItems = 3;
            this.comboBoxFilterCommande.Name = "comboBoxFilterCommande";
            this.comboBoxFilterCommande.Size = new System.Drawing.Size(82, 24);
            this.comboBoxFilterCommande.Sorted = true;
            this.comboBoxFilterCommande.TabIndex = 4;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(9, 9);
            this.searchBar.MinimumSize = new System.Drawing.Size(0, 26);
            this.searchBar.Multiline = true;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(236, 26);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bAjoutCommande
            // 
            this.bAjoutCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjoutCommande.AutoSize = true;
            this.bAjoutCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.bAjoutCommande.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAjoutCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAjoutCommande.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjoutCommande.ForeColor = System.Drawing.Color.White;
            this.bAjoutCommande.Location = new System.Drawing.Point(581, 14);
            this.bAjoutCommande.Margin = new System.Windows.Forms.Padding(0);
            this.bAjoutCommande.MaximumSize = new System.Drawing.Size(145, 28);
            this.bAjoutCommande.MinimumSize = new System.Drawing.Size(145, 28);
            this.bAjoutCommande.Name = "bAjoutCommande";
            this.bAjoutCommande.Size = new System.Drawing.Size(145, 28);
            this.bAjoutCommande.TabIndex = 0;
            this.bAjoutCommande.Text = "Ajouter commande";
            this.bAjoutCommande.UseVisualStyleBackColor = true;
            this.bAjoutCommande.Click += new System.EventHandler(this.bAjoutCommande_Click);
            // 
            // panelContainerAjouterCommande
            // 
            this.panelContainerAjouterCommande.Controls.Add(this.flowLayoutPanel1);
            this.panelContainerAjouterCommande.Controls.Add(this.labelHiden);
            this.panelContainerAjouterCommande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerAjouterCommande.Location = new System.Drawing.Point(0, 55);
            this.panelContainerAjouterCommande.Name = "panelContainerAjouterCommande";
            this.panelContainerAjouterCommande.Size = new System.Drawing.Size(750, 444);
            this.panelContainerAjouterCommande.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 444);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelHiden
            // 
            this.labelHiden.AutoSize = true;
            this.labelHiden.Location = new System.Drawing.Point(3, 0);
            this.labelHiden.Name = "labelHiden";
            this.labelHiden.Size = new System.Drawing.Size(35, 13);
            this.labelHiden.TabIndex = 0;
            this.labelHiden.Text = "label1";
            this.labelHiden.Visible = false;
            this.labelHiden.TextChanged += new System.EventHandler(this.labelHiden_TextChanged);
            // 
            // panelListeCommande
            // 
            this.panelListeCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListeCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.panelListeCommande.Controls.Add(this.dataGridView1);
            this.panelListeCommande.Location = new System.Drawing.Point(0, 55);
            this.panelListeCommande.Name = "panelListeCommande";
            this.panelListeCommande.Size = new System.Drawing.Size(750, 444);
            this.panelListeCommande.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCommandeDataGridViewTextBoxColumn,
            this.dateDemandeDataGridViewTextBoxColumn,
            this.dateArriveSouhaiteDataGridViewTextBoxColumn,
            this.produitcommandeDataGridViewTextBoxColumn,
            this.Montant,
            this.AprouveColumn,
            this.Supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(22, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Size = new System.Drawing.Size(704, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // nCommandeDataGridViewTextBoxColumn
            // 
            this.nCommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nCommandeDataGridViewTextBoxColumn.DataPropertyName = "NCommande";
            this.nCommandeDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.nCommandeDataGridViewTextBoxColumn.HeaderText = "n commande";
            this.nCommandeDataGridViewTextBoxColumn.Name = "nCommandeDataGridViewTextBoxColumn";
            this.nCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCommandeDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateDemandeDataGridViewTextBoxColumn
            // 
            this.dateDemandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDemandeDataGridViewTextBoxColumn.DataPropertyName = "dateDemande";
            this.dateDemandeDataGridViewTextBoxColumn.FillWeight = 74.23858F;
            this.dateDemandeDataGridViewTextBoxColumn.HeaderText = "date de demande";
            this.dateDemandeDataGridViewTextBoxColumn.Name = "dateDemandeDataGridViewTextBoxColumn";
            this.dateDemandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateArriveSouhaiteDataGridViewTextBoxColumn
            // 
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.DataPropertyName = "dateArriveSouhaite";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.FillWeight = 74.23858F;
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.HeaderText = "date d\'arrivé souhaité";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.Name = "dateArriveSouhaiteDataGridViewTextBoxColumn";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitcommandeDataGridViewTextBoxColumn
            // 
            this.produitcommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produitcommandeDataGridViewTextBoxColumn.DataPropertyName = "Produit_commande";
            this.produitcommandeDataGridViewTextBoxColumn.FillWeight = 74.23858F;
            this.produitcommandeDataGridViewTextBoxColumn.HeaderText = "Produits commandés";
            this.produitcommandeDataGridViewTextBoxColumn.Name = "produitcommandeDataGridViewTextBoxColumn";
            this.produitcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.produitcommandeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.produitcommandeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Montant
            // 
            this.Montant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // AprouveColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.AprouveColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AprouveColumn.FillWeight = 74.23858F;
            this.AprouveColumn.HeaderText = "";
            this.AprouveColumn.MinimumWidth = 30;
            this.AprouveColumn.Name = "AprouveColumn";
            this.AprouveColumn.ReadOnly = true;
            this.AprouveColumn.Width = 114;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = " ";
            this.Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("Supprimer.Image")));
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.Width = 50;
            // 
            // UC_Gestion_Commades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainerAjouterCommande);
            this.Controls.Add(this.panelListeCommande);
            this.Controls.Add(this.panelHeader);
            this.Name = "UC_Gestion_Commades";
            this.Size = new System.Drawing.Size(750, 499);
            this.Load += new System.EventHandler(this.UC_Gestion_Commades_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            this.panelContainerAjouterCommande.ResumeLayout(false);
            this.panelContainerAjouterCommande.PerformLayout();
            this.panelListeCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void initCompo(System.Collections.Generic.List<Commande> commandes)
        {
            InitializeComponent();
            refrechDataGrid(commandes);
        }
        public void refrechDataGrid(System.Collections.Generic.List<Commande> commandes)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            commandes.Reverse();
            var db = new dbContext();
            int nbprod = 0;
            decimal montant=0;
            foreach (var item in commandes)
            {
                var pcommandes = db.Produit_commande.Where(c => c.NCommande == item.NCommande).ToList<Produit_commande>();
                montant = pcommandes.Sum(s => s.quantite*db.Produits.Find(s.codeProduit).prixAchat);
                nbprod = pcommandes.Sum(s=>s.quantite);
                if (i < commandes.Count - 1) dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.NCommande;
                dataGridView1.Rows[i].Cells[1].Value = item.dateDemande.ToShortDateString();
                dataGridView1.Rows[i].Cells[2].Value = item.dateArriveSouhaite.ToShortDateString();
                dataGridView1.Rows[i].Cells[3].Value =nbprod+ " produits...";
                dataGridView1.Rows[i].Cells[4].Value = montant + " dh"; 
                dataGridView1.Rows[i].Cells[6].Value = ((System.Drawing.Image)(Properties.Resources.clear));
                if (item.statut == true)
               {
                   dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    dataGridView1.Rows[i].Cells[5].Value = "Arrivé"; 
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
                    dataGridView1.Rows[i].Cells[5].Value = "Valider";
                }
                 
                i++;
            }
        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button bAjoutCommande;
        private System.Windows.Forms.Panel panelContainerAjouterCommande;
        private System.Windows.Forms.Panel panelListeCommande;
        private System.Windows.Forms.Label labelHiden;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNbCommande;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.TextBox searchBar;
        private DataGridView dataGridView1;
        private ComboBox comboBoxFilterCommande;
        private DataGridViewTextBoxColumn nCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDemandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateArriveSouhaiteDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn produitcommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Montant;
        private DataGridViewButtonColumn AprouveColumn;
        private DataGridViewImageColumn Supprimer;
    }
}
