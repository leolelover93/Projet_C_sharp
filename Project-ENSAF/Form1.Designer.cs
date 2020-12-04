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
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedLinePanel = new System.Windows.Forms.Panel();
            this.BtnGestionProduits = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelGestionProduit = new System.Windows.Forms.Panel();
            this.panelGestionVentes = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelVente = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViderPanger = new System.Windows.Forms.Button();
            this.btnAjouterAuPagnier = new System.Windows.Forms.Button();
            this.labelBasket = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelGestionProduit.SuspendLayout();
            this.panelGestionVentes.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.LogoPanel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkedLinePanel);
            this.panel1.Controls.Add(this.BtnGestionProduits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 499);
            this.panel1.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.LogoPanel.Controls.Add(this.lblLogo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(201, 55);
            this.LogoPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogo.Location = new System.Drawing.Point(44, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(112, 28);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SUPREME";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 230);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gestion Ventes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion Produits ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedLinePanel
            // 
            this.checkedLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.checkedLinePanel.Location = new System.Drawing.Point(0, 116);
            this.checkedLinePanel.Name = "checkedLinePanel";
            this.checkedLinePanel.Size = new System.Drawing.Size(6, 49);
            this.checkedLinePanel.TabIndex = 1;
            // 
            // BtnGestionProduits
            // 
            this.BtnGestionProduits.FlatAppearance.BorderSize = 0;
            this.BtnGestionProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionProduits.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionProduits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGestionProduits.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestionProduits.Image")));
            this.BtnGestionProduits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionProduits.Location = new System.Drawing.Point(6, 116);
            this.BtnGestionProduits.Name = "BtnGestionProduits";
            this.BtnGestionProduits.Size = new System.Drawing.Size(195, 51);
            this.BtnGestionProduits.TabIndex = 0;
            this.BtnGestionProduits.Text = "Gestion Produits";
            this.BtnGestionProduits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGestionProduits.UseVisualStyleBackColor = true;
            this.BtnGestionProduits.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.panelGestionProduit);
            this.panelContainer.Controls.Add(this.panelGestionVentes);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(201, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(790, 499);
            this.panelContainer.TabIndex = 1;
            // 
            // panelGestionProduit
            // 
            this.panelGestionProduit.BackColor = System.Drawing.Color.Maroon;
            this.panelGestionProduit.Controls.Add(this.panelHeader);
            this.panelGestionProduit.Controls.Add(this.flowLayoutPanel1);
            this.panelGestionProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionProduit.Location = new System.Drawing.Point(0, 0);
            this.panelGestionProduit.Name = "panelGestionProduit";
            this.panelGestionProduit.Size = new System.Drawing.Size(790, 499);
            this.panelGestionProduit.TabIndex = 0;
            // 
            // panelGestionVentes
            // 
            this.panelGestionVentes.BackColor = System.Drawing.Color.Chocolate;
            this.panelGestionVentes.Controls.Add(this.flowLayoutPanelVente);
            this.panelGestionVentes.Controls.Add(this.panel2);
            this.panelGestionVentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionVentes.Location = new System.Drawing.Point(0, 0);
            this.panelGestionVentes.Name = "panelGestionVentes";
            this.panelGestionVentes.Size = new System.Drawing.Size(790, 499);
            this.panelGestionVentes.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MintCream;
            this.panelHeader.Controls.Add(this.button5);
            this.panelHeader.Controls.Add(this.button4);
            this.panelHeader.Controls.Add(this.btnViewAll);
            this.panelHeader.Controls.Add(this.panelSearchBox);
            this.panelHeader.Controls.Add(this.btnAjouterProduit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(790, 53);
            this.panelHeader.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button5.Location = new System.Drawing.Point(435, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "Non-Disponible";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.filter_style_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button4.Location = new System.Drawing.Point(356, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Disponible";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.filter_style_click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(275, 16);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 29);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.filter_style_click);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.Controls.Add(this.pictureBox1);
            this.panelSearchBox.Controls.Add(this.textBox1);
            this.panelSearchBox.Location = new System.Drawing.Point(6, 7);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(246, 45);
            this.panelSearchBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.textBox1.Location = new System.Drawing.Point(17, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Cherhcer Produit";
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterProduit.AutoSize = true;
            this.btnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAjouterProduit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAjouterProduit.ForeColor = System.Drawing.Color.White;
            this.btnAjouterProduit.Location = new System.Drawing.Point(598, 9);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(156, 39);
            this.btnAjouterProduit.TabIndex = 0;
            this.btnAjouterProduit.Text = "+ Ajouter Prdouit";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 451);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanelVente
            // 
            this.flowLayoutPanelVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanelVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelVente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelVente.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanelVente.Name = "flowLayoutPanelVente";
            this.flowLayoutPanelVente.Size = new System.Drawing.Size(790, 441);
            this.flowLayoutPanelVente.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnViderPanger);
            this.panel2.Controls.Add(this.btnAjouterAuPagnier);
            this.panel2.Controls.Add(this.labelBasket);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 60);
            this.panel2.TabIndex = 2;
            // 
            // btnViderPanger
            // 
            this.btnViderPanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViderPanger.AutoSize = true;
            this.btnViderPanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnViderPanger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViderPanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViderPanger.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViderPanger.ForeColor = System.Drawing.Color.White;
            this.btnViderPanger.Location = new System.Drawing.Point(215, 13);
            this.btnViderPanger.Margin = new System.Windows.Forms.Padding(0);
            this.btnViderPanger.Name = "btnViderPanger";
            this.btnViderPanger.Size = new System.Drawing.Size(185, 39);
            this.btnViderPanger.TabIndex = 3;
            this.btnViderPanger.Text = "Vider le pagnier";
            this.btnViderPanger.UseVisualStyleBackColor = false;
            // 
            // btnAjouterAuPagnier
            // 
            this.btnAjouterAuPagnier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterAuPagnier.AutoSize = true;
            this.btnAjouterAuPagnier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAjouterAuPagnier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterAuPagnier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAuPagnier.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAjouterAuPagnier.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAuPagnier.Location = new System.Drawing.Point(15, 13);
            this.btnAjouterAuPagnier.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterAuPagnier.Name = "btnAjouterAuPagnier";
            this.btnAjouterAuPagnier.Size = new System.Drawing.Size(185, 39);
            this.btnAjouterAuPagnier.TabIndex = 2;
            this.btnAjouterAuPagnier.Text = "+ Nouveau pagnier";
            this.btnAjouterAuPagnier.UseVisualStyleBackColor = false;
            // 
            // labelBasket
            // 
            this.labelBasket.AutoSize = true;
            this.labelBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelBasket.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasket.ForeColor = System.Drawing.Color.Red;
            this.labelBasket.Location = new System.Drawing.Point(741, 13);
            this.labelBasket.MaximumSize = new System.Drawing.Size(0, 13);
            this.labelBasket.Name = "labelBasket";
            this.labelBasket.Size = new System.Drawing.Size(13, 13);
            this.labelBasket.TabIndex = 1;
            this.labelBasket.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(715, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(991, 499);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelGestionProduit.ResumeLayout(false);
            this.panelGestionVentes.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGestionProduits;
        private System.Windows.Forms.Panel checkedLinePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelGestionProduit;
        private System.Windows.Forms.Panel panelGestionVentes;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViderPanger;
        private System.Windows.Forms.Button btnAjouterAuPagnier;
        private System.Windows.Forms.Label labelBasket;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

