namespace Project_ENSAF
{ 
    using System.Linq;
    using System.ComponentModel;
    using System.IO;
    using System.Drawing;

    using System.Windows.Forms;
    partial class produit_cardUC
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
        public void fct()
        {

            this.lblProdName.Text ="Said";

            MessageBox.Show("changed: " + this.lblProdName.Text);

        }
        private void InitializeComponent()
        {
            this.lblProdName = new System.Windows.Forms.Label();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.lblProdDescri = new System.Windows.Forms.Label();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.lblprix = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblnbProduits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            this.lblProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdName.AutoEllipsis = true;
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(-1, 118);
            this.lblProdName.MaximumSize = new System.Drawing.Size(160, 23);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(67, 23);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "libelle";
            // 
            // prodImg
            // 
            this.prodImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodImg.Image = global::Project_ENSAF.Properties.Resources.loading_product;
            this.prodImg.InitialImage = null;
            this.prodImg.Location = new System.Drawing.Point(3, -1);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(166, 117);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prodImg.TabIndex = 1;
            this.prodImg.TabStop = false;
            // 
            // lblProdDescri
            // 
            this.lblProdDescri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdDescri.AutoEllipsis = true;
            this.lblProdDescri.AutoSize = true;
            this.lblProdDescri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdDescri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProdDescri.Location = new System.Drawing.Point(0, 144);
            this.lblProdDescri.MaximumSize = new System.Drawing.Size(190, 20);
            this.lblProdDescri.Name = "lblProdDescri";
            this.lblProdDescri.Size = new System.Drawing.Size(86, 17);
            this.lblProdDescri.TabIndex = 2;
            this.lblProdDescri.Text = "p.description";
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
            this.btnReadMore.Location = new System.Drawing.Point(92, 185);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(76, 27);
            this.btnReadMore.TabIndex = 3;
            this.btnReadMore.Text = "Voir plus";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_click);
            // 
            // lblprix
            // 
            this.lblprix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprix.AutoEllipsis = true;
            this.lblprix.AutoSize = true;
            this.lblprix.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.lblprix.Location = new System.Drawing.Point(-1, 189);
            this.lblprix.MaximumSize = new System.Drawing.Size(94, 23);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(58, 22);
            this.lblprix.TabIndex = 4;
            this.lblprix.Text = "10 dh";
            this.lblprix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = global::Project_ENSAF.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(123, 119);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(18, 20);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.btnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::Project_ENSAF.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(147, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 18);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // lblnbProduits
            // 
            this.lblnbProduits.AutoSize = true;
            this.lblnbProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnbProduits.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnbProduits.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblnbProduits.Location = new System.Drawing.Point(0, 164);
            this.lblnbProduits.MaximumSize = new System.Drawing.Size(190, 20);
            this.lblnbProduits.Name = "lblnbProduits";
            this.lblnbProduits.Size = new System.Drawing.Size(55, 17);
            this.lblnbProduits.TabIndex = 2;
            this.lblnbProduits.Text = "Stock: 5";
            // 
            // produit_cardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblprix);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.lblProdDescri);
            this.Controls.Add(this.prodImg);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblnbProduits);
            this.MaximumSize = new System.Drawing.Size(172, 218);
            this.MinimumSize = new System.Drawing.Size(172, 218);
            this.Name = "produit_cardUC";
            this.Size = new System.Drawing.Size(172, 218);
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void initCompo(Produit p, int nbProds)
        { 
            InitializeComponent();
            this.lblProdName.Text = p.libelle;  
            this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
            this.lblProdDescri.Text = p.description;  
            this.lblprix.Text = p.prixVente.ToString() + "dh";
            this.lblnbProduits.Text = "Stock: " + nbProds;//nbProds.ToString(); 

        }
        #endregion 
        public System.Windows.Forms.Label lblProdName;
        public System.Windows.Forms.PictureBox prodImg;
        public System.Windows.Forms.Label lblProdDescri; 
        public System.Windows.Forms.Button btnReadMore;
        public System.Windows.Forms.Label lblprix; 
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblnbProduits;
    }
}
