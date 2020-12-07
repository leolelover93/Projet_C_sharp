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
            this.checkedLinePanel = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelGestionVentes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearchProduitVentes = new System.Windows.Forms.TextBox();
            this.btnViderPanger = new System.Windows.Forms.Button();
            this.btnAjouterAuPagnier = new System.Windows.Forms.Button();
            this.labelBasket = new System.Windows.Forms.Label();
            this.listBoxItemProduct = new System.Windows.Forms.Label();
            this.panelGestionProduit = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnNonDisponible = new System.Windows.Forms.Button();
            this.btnDisponible = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGestionProduits = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            listBoxItemProduct = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelVente = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelGestionVentes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelGestionProduit.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lblLogo.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogo.Location = new System.Drawing.Point(3, 11);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(167, 34);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SUPREME";
            // 
            // checkedLinePanel
            // 
            this.checkedLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.checkedLinePanel.Location = new System.Drawing.Point(0, 116);
            this.checkedLinePanel.Name = "checkedLinePanel";
            this.checkedLinePanel.Size = new System.Drawing.Size(6, 49);
            this.checkedLinePanel.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.panelGestionProduit);
            this.panelContainer.Controls.Add(this.panelGestionVentes);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(201, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(750, 499);
            this.panelContainer.TabIndex = 1;
            // 
            // panelGestionVentes
            // 
        this.panelGestionVentes.BackColor = System.Drawing.Color.Chocolate;
            this.panelGestionVentes.Controls.Add(this.panel2);
            this.panelGestionVentes.Controls.Add(this.flowLayoutPanelVente);
            this.panelGestionVentes.Controls.Add(this.listBoxItemProduct);
            this.panelGestionVentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionVentes.Location = new System.Drawing.Point(0, 0);
            this.panelGestionVentes.Name = "panelGestionVentes";
            this.panelGestionVentes.Size = new System.Drawing.Size(750, 499);
            this.panelGestionVentes.TabIndex = 1;    /**/
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnViderPanger);
            this.panel2.Controls.Add(this.btnAjouterAuPagnier);
            this.panel2.Controls.Add(this.labelBasket);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 60);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.textBoxSearchProduitVentes);
            this.panel3.Location = new System.Drawing.Point(23, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 45);
            this.panel3.TabIndex = 4;
            // 
            // textBoxSearchProduitVentes
            // 
            this.textBoxSearchProduitVentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSearchProduitVentes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.textBoxSearchProduitVentes.Location = new System.Drawing.Point(17, 9);
            this.textBoxSearchProduitVentes.Multiline = true;
            this.textBoxSearchProduitVentes.Name = "textBoxSearchProduitVentes";
            this.textBoxSearchProduitVentes.Size = new System.Drawing.Size(216, 25);
            this.textBoxSearchProduitVentes.TabIndex = 2;
            this.textBoxSearchProduitVentes.Text = "Cherhcer Produit";
            this.textBoxSearchProduitVentes.TextChanged += new System.EventHandler(this.textBoxSearchProduitVentes_TextChanged);
            // 
            // btnViderPanger
            // 
            this.btnViderPanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViderPanger.AutoSize = true;
            this.btnViderPanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnViderPanger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViderPanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViderPanger.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViderPanger.ForeColor = System.Drawing.Color.White;
            this.btnViderPanger.Location = new System.Drawing.Point(498, 9);
            this.btnViderPanger.Margin = new System.Windows.Forms.Padding(0);
            this.btnViderPanger.Name = "btnViderPanger";
            this.btnViderPanger.Size = new System.Drawing.Size(160, 39);
            this.btnViderPanger.TabIndex = 3;
            this.btnViderPanger.Text = "Vider le pagnier";
            this.btnViderPanger.UseVisualStyleBackColor = false;
            this.btnViderPanger.Click += new System.EventHandler(this.btnViderPanger_Click);
            // 
            // btnAjouterAuPagnier
            // 
            this.btnAjouterAuPagnier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterAuPagnier.AutoSize = true;
            this.btnAjouterAuPagnier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAjouterAuPagnier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterAuPagnier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAuPagnier.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAjouterAuPagnier.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAuPagnier.Location = new System.Drawing.Point(331, 9);
            this.btnAjouterAuPagnier.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterAuPagnier.Name = "btnAjouterAuPagnier";
            this.btnAjouterAuPagnier.Size = new System.Drawing.Size(164, 39);
            this.btnAjouterAuPagnier.TabIndex = 2;
            this.btnAjouterAuPagnier.Text = " Nouveau pagnier";
            this.btnAjouterAuPagnier.UseVisualStyleBackColor = false;
            this.btnAjouterAuPagnier.Click += new System.EventHandler(this.btnAjouterAuPagnier_Click);
            // 
            // labelBasket
            // 
            this.labelBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBasket.AutoSize = true;
            this.labelBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelBasket.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasket.ForeColor = System.Drawing.Color.Red;
            this.labelBasket.Location = new System.Drawing.Point(701, 9);
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
            this.pictureBox2.Location = new System.Drawing.Point(715, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flowLayoutPanelVente
        // 
            this.flowLayoutPanelVente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelVente.AutoScroll = true;
            this.flowLayoutPanelVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanelVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelVente.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanelVente.Name = "flowLayoutPanelVente";
            this.flowLayoutPanelVente.Size = new System.Drawing.Size(790, 441);
            this.flowLayoutPanelVente.TabIndex = 3;
            /*  */  // 
            // listBoxItemProduct
            // 
            this.listBoxItemProduct.Location = new System.Drawing.Point(44, 6);
            this.listBoxItemProduct.Name = "listBoxItemProduct";
            this.listBoxItemProduct.Size = new System.Drawing.Size(72, 39);
            this.listBoxItemProduct.TabIndex = 5;
            this.listBoxItemProduct.Visible = false;
            this.listBoxItemProduct.TextChanged += new System.EventHandler(this.listBoxItemProduct_TextChanged);
            this.listBoxItemProduct.Resize += new System.EventHandler(this.listBoxItemProduct_Resize);
            // 
            // panelGestionProduit
            // 
            this.panelGestionProduit.BackColor = System.Drawing.Color.Maroon;
            this.panelGestionProduit.Controls.Add(this.panelHeader);
            this.panelGestionProduit.Controls.Add(this.flowLayoutPanel1);
            this.panelGestionProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionProduit.Location = new System.Drawing.Point(0, 0);
            this.panelGestionProduit.Name = "panelGestionProduit";
            this.panelGestionProduit.Size = new System.Drawing.Size(750, 499);
            this.panelGestionProduit.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelHeader.Controls.Add(this.btnNonDisponible);
            this.panelHeader.Controls.Add(this.btnDisponible);
            this.panelHeader.Controls.Add(this.btnViewAll);
            this.panelHeader.Controls.Add(this.panelSearchBox);
            this.panelHeader.Controls.Add(this.btnAjouterProduit);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(750, 55);
            this.panelHeader.TabIndex = 7;
            // 
            // btnNonDisponible
            // 
            this.btnNonDisponible.BackColor = System.Drawing.Color.White;
            this.btnNonDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonDisponible.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnNonDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnNonDisponible.Location = new System.Drawing.Point(457, 16);
            this.btnNonDisponible.Name = "btnNonDisponible";
            this.btnNonDisponible.Size = new System.Drawing.Size(100, 29);
            this.btnNonDisponible.TabIndex = 3;
            this.btnNonDisponible.Text = "Non-Disponible";
            this.btnNonDisponible.UseVisualStyleBackColor = false;
            this.btnNonDisponible.Click += new System.EventHandler(this.btnNonDisponible_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.BackColor = System.Drawing.Color.White;
            this.btnDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponible.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnDisponible.Location = new System.Drawing.Point(378, 16);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(73, 29);
            this.btnDisponible.TabIndex = 2;
            this.btnDisponible.Text = "Disponible";
            this.btnDisponible.UseVisualStyleBackColor = false;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(297, 16);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 29);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.Controls.Add(this.button3);
            this.panelSearchBox.Controls.Add(this.tbSearch);
            this.panelSearchBox.Location = new System.Drawing.Point(0, 7);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(246, 45);
            this.panelSearchBox.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(9, 9);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(216, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouterProduit.AutoSize = true;
            this.btnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAjouterProduit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.ForeColor = System.Drawing.Color.White;
            this.btnAjouterProduit.Location = new System.Drawing.Point(621, 16);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterProduit.MaximumSize = new System.Drawing.Size(0, 31);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(120, 29);
            this.btnAjouterProduit.TabIndex = 0;
            this.btnAjouterProduit.Text = " Ajouter Prdouit";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 2, 5, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 444);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(675, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(199, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 20);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(951, 499);
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
            this.panelGestionVentes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelGestionProduit.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button btnNonDisponible;
        private System.Windows.Forms.Button btnDisponible;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViderPanger;
        private System.Windows.Forms.Button btnAjouterAuPagnier;
        private System.Windows.Forms.Label labelBasket;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxSearchProduitVentes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label listBoxItemProduct;
    }
}

