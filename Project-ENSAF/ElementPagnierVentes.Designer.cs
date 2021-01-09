namespace Project_ENSAF
{
    partial class ElementPagnierVentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementPagnierVentes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownQunatite = new System.Windows.Forms.NumericUpDown();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelPrixUnite = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.panelIconBackground = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.labelNbProduit = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelProduit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQunatite)).BeginInit();
            this.panelIconBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numericUpDownQunatite);
            this.panel1.Controls.Add(this.labelPrixTotal);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Controls.Add(this.labelPrixUnite);
            this.panel1.Controls.Add(this.labelP);
            this.panel1.Controls.Add(this.panelIconBackground);
            this.panel1.Controls.Add(this.labelNbProduit);
            this.panel1.Controls.Add(this.labelQ);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelProduit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 121);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownQunatite
            // 
            this.numericUpDownQunatite.Location = new System.Drawing.Point(383, 67);
            this.numericUpDownQunatite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQunatite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQunatite.Name = "numericUpDownQunatite";
            this.numericUpDownQunatite.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownQunatite.TabIndex = 11;
            this.numericUpDownQunatite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQunatite.ValueChanged += new System.EventHandler(this.numericUpDownQunatite_ValueChanged);
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelPrixTotal.Location = new System.Drawing.Point(437, 90);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(47, 17);
            this.labelPrixTotal.TabIndex = 10;
            this.labelPrixTotal.Text = "label1";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelT.Location = new System.Drawing.Point(380, 90);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(51, 17);
            this.labelT.TabIndex = 9;
            this.labelT.Text = "Total : ";
            // 
            // labelPrixUnite
            // 
            this.labelPrixUnite.AutoSize = true;
            this.labelPrixUnite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelPrixUnite.Location = new System.Drawing.Point(203, 87);
            this.labelPrixUnite.Name = "labelPrixUnite";
            this.labelPrixUnite.Size = new System.Drawing.Size(47, 17);
            this.labelPrixUnite.TabIndex = 8;
            this.labelPrixUnite.Text = "label1";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelP.Location = new System.Drawing.Point(120, 87);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(77, 17);
            this.labelP.TabIndex = 7;
            this.labelP.Text = "Prix Unité : ";
            // 
            // panelIconBackground
            // 
            this.panelIconBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelIconBackground.Controls.Add(this.icon);
            this.panelIconBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIconBackground.Location = new System.Drawing.Point(0, 0);
            this.panelIconBackground.Name = "panelIconBackground";
            this.panelIconBackground.Size = new System.Drawing.Size(114, 121);
            this.panelIconBackground.TabIndex = 6;
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(108, 115);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // labelNbProduit
            // 
            this.labelNbProduit.AutoSize = true;
            this.labelNbProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelNbProduit.Location = new System.Drawing.Point(203, 70);
            this.labelNbProduit.Name = "labelNbProduit";
            this.labelNbProduit.Size = new System.Drawing.Size(47, 17);
            this.labelNbProduit.TabIndex = 5;
            this.labelNbProduit.Text = "label1";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelQ.Location = new System.Drawing.Point(120, 70);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(77, 17);
            this.labelQ.TabIndex = 4;
            this.labelQ.Text = "Quantité : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(120, 35);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(233, 35);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "label1";
            // 
            // labelProduit
            // 
            this.labelProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProduit.AutoSize = true;
            this.labelProduit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduit.Location = new System.Drawing.Point(120, 7);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(54, 18);
            this.labelProduit.TabIndex = 1;
            this.labelProduit.Text = "label1";
            // 
            // ElementPagnierVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ElementPagnierVentes";
            this.Size = new System.Drawing.Size(511, 121);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQunatite)).EndInit();
            this.panelIconBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeComp(int quantite)
        {
            InitializeComponent();
            this.numericUpDownQunatite.Maximum = qunatite;

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNbProduit;
        private System.Windows.Forms.Panel panelIconBackground;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelPrixUnite;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.NumericUpDown numericUpDownQunatite;
    }
}
