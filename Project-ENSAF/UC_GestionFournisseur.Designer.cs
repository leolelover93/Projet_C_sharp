namespace Project_ENSAF
{
    partial class UC_GestionFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAjoutCommande = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveSouhaiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.bAjoutCommande);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(535, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 55);
            this.panel1.TabIndex = 3;
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
            this.bAjoutCommande.Text = "Ajouter Fournisseur";
            this.bAjoutCommande.UseVisualStyleBackColor = true;
            this.bAjoutCommande.Click += new System.EventHandler(this.bAjoutCommande_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCommandeDataGridViewTextBoxColumn,
            this.dateDemandeDataGridViewTextBoxColumn,
            this.dateArriveSouhaiteDataGridViewTextBoxColumn,
            this.tel,
            this.produitcommandeDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
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
            this.dataGridView1.Size = new System.Drawing.Size(704, 411);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nCommandeDataGridViewTextBoxColumn
            // 
            this.nCommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nCommandeDataGridViewTextBoxColumn.DataPropertyName = "NCommande";
            this.nCommandeDataGridViewTextBoxColumn.HeaderText = "Nfournisseur";
            this.nCommandeDataGridViewTextBoxColumn.Name = "nCommandeDataGridViewTextBoxColumn";
            this.nCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDemandeDataGridViewTextBoxColumn
            // 
            this.dateDemandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDemandeDataGridViewTextBoxColumn.DataPropertyName = "dateDemande";
            this.dateDemandeDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.dateDemandeDataGridViewTextBoxColumn.Name = "dateDemandeDataGridViewTextBoxColumn";
            this.dateDemandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateArriveSouhaiteDataGridViewTextBoxColumn
            // 
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.DataPropertyName = "dateArriveSouhaite";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.Name = "dateArriveSouhaiteDataGridViewTextBoxColumn";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Téléphone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // produitcommandeDataGridViewTextBoxColumn
            // 
            this.produitcommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produitcommandeDataGridViewTextBoxColumn.DataPropertyName = "Produit_commande";
            this.produitcommandeDataGridViewTextBoxColumn.HeaderText = "Addresse";
            this.produitcommandeDataGridViewTextBoxColumn.Name = "produitcommandeDataGridViewTextBoxColumn";
            this.produitcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            // 
            // UC_GestionFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_GestionFournisseur";
            this.Size = new System.Drawing.Size(750, 499);
            this.Load += new System.EventHandler(this.UC_GestionFournisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void initCompo(System.Collections.Generic.List<Fournisseur> fournisseurs)
        {
            InitializeComponent();
            refrechDataGrid(fournisseurs); //first time
            var db = new dbContext();
          //  db.Produits
        } 
        public void refrechDataGrid(System.Collections.Generic.List<Fournisseur> fournisseurs)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (var item in fournisseurs)
            {
                if (i < fournisseurs.Count - 1) dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.idFournisseur;
                dataGridView1.Rows[i].Cells[1].Value = item.nomFournisseur;
                dataGridView1.Rows[i].Cells[2].Value = item.prenomFournisseur;
                dataGridView1.Rows[i].Cells[3].Value = item.telFournisseur;
                dataGridView1.Rows[i].Cells[4].Value = item.adressFournisseur;
                dataGridView1.Rows[i].Cells[5].Value = "Modifier";
                dataGridView1.Rows[i].Cells[6].Value = "Supprimer";
                i++;
            }
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAjoutCommande;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveSouhaiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Modifier;
        private System.Windows.Forms.DataGridViewLinkColumn Supprimer;
    }
}
