namespace Project_ENSAF
{
    using System.IO;
    using System.Drawing;
    partial class produit_Vente
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblProdDescri = new System.Windows.Forms.Label();
            this.numericUpDownQauntite = new System.Windows.Forms.NumericUpDown();
            this.lblnbProduits = new System.Windows.Forms.Label();
            this.panelHorsStock = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQauntite)).BeginInit();
            this.panelHorsStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodImg
            // 
            this.prodImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodImg.InitialImage = null;
            this.prodImg.Location = new System.Drawing.Point(3, -1);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(166, 117);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prodImg.TabIndex = 0;
            this.prodImg.TabStop = false;
            // 
            // lblProdName
            // 
            this.lblProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(-1, 118);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(46, 23);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Title";
            // 
            // btnReadMore
            // 
            this.btnReadMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnReadMore.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReadMore.Location = new System.Drawing.Point(79, 185);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(87, 27);
            this.btnReadMore.TabIndex = 3;
            this.btnReadMore.Text = "Ajouter Produit";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // lblprix
            // 
            this.lblprix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprix.AutoSize = true;
            this.lblprix.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.lblprix.Location = new System.Drawing.Point(-1, 189);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(63, 23);
            this.lblprix.TabIndex = 4;
            this.lblprix.Text = "2.0DH";
            // 
            // lblProdDescri
            // 
            this.lblProdDescri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdDescri.AutoSize = true;
            this.lblProdDescri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdDescri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProdDescri.Location = new System.Drawing.Point(0, 144);
            this.lblProdDescri.MaximumSize = new System.Drawing.Size(190, 40);
            this.lblProdDescri.Name = "lblProdDescri";
            this.lblProdDescri.Size = new System.Drawing.Size(75, 17);
            this.lblProdDescri.TabIndex = 2;
            this.lblProdDescri.Text = "description";
            // 
            // numericUpDownQauntite
            // 
            this.numericUpDownQauntite.Location = new System.Drawing.Point(3, 164);
            this.numericUpDownQauntite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQauntite.Name = "numericUpDownQauntite";
            this.numericUpDownQauntite.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownQauntite.TabIndex = 5;
            this.numericUpDownQauntite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblnbProduits
            // 
            this.lblnbProduits.AutoSize = true;
            this.lblnbProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnbProduits.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnbProduits.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblnbProduits.Location = new System.Drawing.Point(56, 164);
            this.lblnbProduits.MaximumSize = new System.Drawing.Size(190, 20);
            this.lblnbProduits.Name = "lblnbProduits";
            this.lblnbProduits.Size = new System.Drawing.Size(48, 17);
            this.lblnbProduits.TabIndex = 6;
            this.lblnbProduits.Text = "Stock: ";
            // 
            // panelHorsStock
            // 
            this.panelHorsStock.BackColor = System.Drawing.Color.Transparent;
            this.panelHorsStock.Controls.Add(this.label1);
            this.panelHorsStock.Location = new System.Drawing.Point(3, 164);
            this.panelHorsStock.Name = "panelHorsStock";
            this.panelHorsStock.Size = new System.Drawing.Size(166, 48);
            this.panelHorsStock.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hors Stock";
            // 
            // produit_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelHorsStock);
            this.Controls.Add(this.lblnbProduits);
            this.Controls.Add(this.numericUpDownQauntite);
            this.Controls.Add(this.lblProdDescri);
            this.Controls.Add(this.lblprix);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.prodImg);
            this.Name = "produit_Vente";
            this.Size = new System.Drawing.Size(172, 218);
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQauntite)).EndInit();
            this.panelHorsStock.ResumeLayout(false);
            this.panelHorsStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void InitializeComp2(Produit p)
        {

            InitializeComponent();
            this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
            this.lblProdName.Text = p.libelle;
            this.lblprix.Text = p.prixVente.ToString() + "DH";
            this.lblProdDescri.Text = p.description;

        }
        private void InitializeComp(Produit p,  int quantite,bool testCommande)
        {
            InitializeComponent();
            this.panelHorsStock.Visible = false;
            this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
            this.lblProdName.Text = p.libelle;
            this.lblprix.Text = p.prixVente.ToString() + "DH";
            this.lblProdDescri.Text = p.description;
            this.lblnbProduits.Text += quantite;
            if (testCommande== true)
            {
                btnReadMore.Text = "Commander";
                btnReadMore.BackColor = Color.FromArgb(236, 88, 88);
            }else if(this.Quantite == 0)
            {
                this.panelHorsStock.Visible = true;
            }else
            {
                this.numericUpDownQauntite.Maximum = quantite;
            }

        }
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.Label lblprix;
        private System.Windows.Forms.Label lblProdDescri;
        private System.Windows.Forms.NumericUpDown numericUpDownQauntite;
        public System.Windows.Forms.Label lblnbProduits;
        private System.Windows.Forms.Panel panelHorsStock;
        private System.Windows.Forms.Label label1;
    }
}
