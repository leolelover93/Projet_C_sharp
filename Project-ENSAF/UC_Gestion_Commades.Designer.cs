namespace Project_ENSAF
{

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNbCommande = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bAjoutCommande = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelContainerAjouterCommande = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHiden = new System.Windows.Forms.Label();
            this.nCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveSouhaiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AprouverColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelContainerAjouterCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.labelNbCommande);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.bAjoutCommande);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(535, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 55);
            this.panel1.TabIndex = 3;
            // 
            // labelNbCommande
            // 
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
            this.pictureBox.Image = global::Project_ENSAF.Properties.Resources.open_box;
            this.pictureBox.Location = new System.Drawing.Point(519, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(44, 28);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCommandeDataGridViewTextBoxColumn,
            this.dateDemandeDataGridViewTextBoxColumn,
            this.dateArriveSouhaiteDataGridViewTextBoxColumn,
            this.produitcommandeDataGridViewTextBoxColumn,
            this.AprouverColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Size = new System.Drawing.Size(704, 411);
            this.dataGridView1.TabIndex = 2;
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // nCommandeDataGridViewTextBoxColumn
            // 
            this.nCommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nCommandeDataGridViewTextBoxColumn.DataPropertyName = "NCommande";
            this.nCommandeDataGridViewTextBoxColumn.HeaderText = "N commande";
            this.nCommandeDataGridViewTextBoxColumn.Name = "nCommandeDataGridViewTextBoxColumn";
            this.nCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDemandeDataGridViewTextBoxColumn
            // 
            this.dateDemandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDemandeDataGridViewTextBoxColumn.DataPropertyName = "dateDemande";
            this.dateDemandeDataGridViewTextBoxColumn.HeaderText = "date de demande";
            this.dateDemandeDataGridViewTextBoxColumn.Name = "dateDemandeDataGridViewTextBoxColumn";
            this.dateDemandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateArriveSouhaiteDataGridViewTextBoxColumn
            // 
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.DataPropertyName = "dateArriveSouhaite";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.HeaderText = "date d\'arrivé souhaité";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.Name = "dateArriveSouhaiteDataGridViewTextBoxColumn";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitcommandeDataGridViewTextBoxColumn
            // 
            this.produitcommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produitcommandeDataGridViewTextBoxColumn.DataPropertyName = "Produit_commande";
            this.produitcommandeDataGridViewTextBoxColumn.HeaderText = "Produits commandés";
            this.produitcommandeDataGridViewTextBoxColumn.Name = "produitcommandeDataGridViewTextBoxColumn";
            this.produitcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AprouverColumn
            // 
            this.AprouverColumn.HeaderText = "Aprouver";
            this.AprouverColumn.Name = "AprouverColumn";
            this.AprouverColumn.Text = "Aprouver";
            // 
            // UC_Gestion_Commades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainerAjouterCommande);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_Gestion_Commades";
            this.Size = new System.Drawing.Size(750, 499);
            this.Load += new System.EventHandler(this.UC_Gestion_Commades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelContainerAjouterCommande.ResumeLayout(false);
            this.panelContainerAjouterCommande.PerformLayout();
            this.ResumeLayout(false);

        }

        private void initCompo(System.Collections.Generic.List<Commande> commandes)
        {
            InitializeComponent();
            int i = 0;
            foreach (var item in commandes)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.NCommande;
                dataGridView1.Rows[i].Cells[1].Value = item.dateDemande.ToShortDateString();
                dataGridView1.Rows[i].Cells[2].Value = item.dateArriveSouhaite.ToShortDateString();
                dataGridView1.Rows[i].Cells[3].Value = "produit1, produit2...";
                i++;
            }
        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAjoutCommande;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelContainerAjouterCommande;
        private System.Windows.Forms.Label labelHiden;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNbCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveSouhaiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AprouverColumn;
    }
}
