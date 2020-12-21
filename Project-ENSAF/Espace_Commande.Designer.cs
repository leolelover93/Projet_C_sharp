namespace Project_ENSAF
{
    partial class Espace_Commande
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMagazinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveSouhaiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.magazinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCommandeDataGridViewTextBoxColumn,
            this.codeMagazinDataGridViewTextBoxColumn,
            this.dateDemandeDataGridViewTextBoxColumn,
            this.dateArriveSouhaiteDataGridViewTextBoxColumn,
            this.statutDataGridViewCheckBoxColumn,
            this.magazinDataGridViewTextBoxColumn,
            this.produitcommandeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commandeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(114, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 57);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(732, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter Commande";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nCommandeDataGridViewTextBoxColumn
            // 
            this.nCommandeDataGridViewTextBoxColumn.DataPropertyName = "NCommande";
            this.nCommandeDataGridViewTextBoxColumn.HeaderText = "NCommande";
            this.nCommandeDataGridViewTextBoxColumn.Name = "nCommandeDataGridViewTextBoxColumn";
            // 
            // codeMagazinDataGridViewTextBoxColumn
            // 
            this.codeMagazinDataGridViewTextBoxColumn.DataPropertyName = "codeMagazin";
            this.codeMagazinDataGridViewTextBoxColumn.HeaderText = "codeMagazin";
            this.codeMagazinDataGridViewTextBoxColumn.Name = "codeMagazinDataGridViewTextBoxColumn";
            // 
            // dateDemandeDataGridViewTextBoxColumn
            // 
            this.dateDemandeDataGridViewTextBoxColumn.DataPropertyName = "dateDemande";
            this.dateDemandeDataGridViewTextBoxColumn.HeaderText = "dateDemande";
            this.dateDemandeDataGridViewTextBoxColumn.Name = "dateDemandeDataGridViewTextBoxColumn";
            // 
            // dateArriveSouhaiteDataGridViewTextBoxColumn
            // 
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.DataPropertyName = "dateArriveSouhaite";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.HeaderText = "dateArriveSouhaite";
            this.dateArriveSouhaiteDataGridViewTextBoxColumn.Name = "dateArriveSouhaiteDataGridViewTextBoxColumn";
            // 
            // statutDataGridViewCheckBoxColumn
            // 
            this.statutDataGridViewCheckBoxColumn.DataPropertyName = "statut";
            this.statutDataGridViewCheckBoxColumn.HeaderText = "statut";
            this.statutDataGridViewCheckBoxColumn.Name = "statutDataGridViewCheckBoxColumn";
            // 
            // magazinDataGridViewTextBoxColumn
            // 
            this.magazinDataGridViewTextBoxColumn.DataPropertyName = "Magazin";
            this.magazinDataGridViewTextBoxColumn.HeaderText = "Magazin";
            this.magazinDataGridViewTextBoxColumn.Name = "magazinDataGridViewTextBoxColumn";
            // 
            // produitcommandeDataGridViewTextBoxColumn
            // 
            this.produitcommandeDataGridViewTextBoxColumn.DataPropertyName = "Produit_commande";
            this.produitcommandeDataGridViewTextBoxColumn.HeaderText = "Produit_commande";
            this.produitcommandeDataGridViewTextBoxColumn.Name = "produitcommandeDataGridViewTextBoxColumn";
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(Project_ENSAF.Commande);
            // 
            // Espace_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Espace_Commande";
            this.Text = "Espace_Commande";
            this.Load += new System.EventHandler(this.Espace_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMagazinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveSouhaiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}