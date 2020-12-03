namespace Project_ENSAF
{
    partial class Form1:System.Windows.Forms.Form
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GestionProduits = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.produit_cardUC1 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC2 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC3 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC4 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC5 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC6 = new Project_ENSAF.produit_cardUC();
            this.produit_cardUC7 = new Project_ENSAF.produit_cardUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.GestionProduits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 499);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GestionProduits
            // 
            this.GestionProduits.FlatAppearance.BorderSize = 0;
            this.GestionProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GestionProduits.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionProduits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GestionProduits.Location = new System.Drawing.Point(42, 109);
            this.GestionProduits.Name = "GestionProduits";
            this.GestionProduits.Size = new System.Drawing.Size(159, 51);
            this.GestionProduits.TabIndex = 0;
            this.GestionProduits.Text = "Gestion Produits";
            this.GestionProduits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GestionProduits.UseVisualStyleBackColor = true;
            this.GestionProduits.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC1);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC2);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC3);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC4);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC5);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC6);
            this.flowLayoutPanel1.Controls.Add(this.produit_cardUC7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 499);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.TabIndex = 0;
            // 
            // produit_cardUC1
            // 
            this.produit_cardUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.produit_cardUC1.Location = new System.Drawing.Point(3, 3);
            this.produit_cardUC1.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC1.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC1.Name = "produit_cardUC1";
            this.produit_cardUC1.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC1.TabIndex = 0;
            // 
            // produit_cardUC2
            // 
            this.produit_cardUC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.produit_cardUC2.Location = new System.Drawing.Point(181, 3);
            this.produit_cardUC2.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC2.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC2.Name = "produit_cardUC2";
            this.produit_cardUC2.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC2.TabIndex = 1;
            // 
            // produit_cardUC3
            // 
            this.produit_cardUC3.BackColor = System.Drawing.Color.White;
            this.produit_cardUC3.Location = new System.Drawing.Point(359, 3);
            this.produit_cardUC3.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC3.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC3.Name = "produit_cardUC3";
            this.produit_cardUC3.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC3.TabIndex = 2;
            // 
            // produit_cardUC4
            // 
            this.produit_cardUC4.BackColor = System.Drawing.Color.White;
            this.produit_cardUC4.Location = new System.Drawing.Point(537, 3);
            this.produit_cardUC4.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC4.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC4.Name = "produit_cardUC4";
            this.produit_cardUC4.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC4.TabIndex = 3;
            // 
            // produit_cardUC5
            // 
            this.produit_cardUC5.BackColor = System.Drawing.Color.White;
            this.produit_cardUC5.Location = new System.Drawing.Point(3, 227);
            this.produit_cardUC5.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC5.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC5.Name = "produit_cardUC5";
            this.produit_cardUC5.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC5.TabIndex = 4;
            // 
            // produit_cardUC6
            // 
            this.produit_cardUC6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(228)))), ((int)(((byte)(207)))));
            this.produit_cardUC6.Location = new System.Drawing.Point(181, 227);
            this.produit_cardUC6.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC6.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC6.Name = "produit_cardUC6";
            this.produit_cardUC6.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC6.TabIndex = 5;
            // 
            // produit_cardUC7
            // 
            this.produit_cardUC7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(228)))), ((int)(((byte)(207)))));
            this.produit_cardUC7.Location = new System.Drawing.Point(359, 227);
            this.produit_cardUC7.MaximumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC7.MinimumSize = new System.Drawing.Size(172, 218);
            this.produit_cardUC7.Name = "produit_cardUC7";
            this.produit_cardUC7.Size = new System.Drawing.Size(172, 218);
            this.produit_cardUC7.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(991, 499);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GestionProduits;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private produit_cardUC produit_cardUC1;
        private produit_cardUC produit_cardUC2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private produit_cardUC produit_cardUC3;
        private produit_cardUC produit_cardUC4;
        private produit_cardUC produit_cardUC5;
        private produit_cardUC produit_cardUC6;
        private produit_cardUC produit_cardUC7;
    }
}

