namespace Project_ENSAF
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;


    partial class FormAfficherPrComma
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
            this.panelLineTop = new System.Windows.Forms.Panel();
            this.panelLineBottom = new System.Windows.Forms.Panel();
            this.panelLineRight = new System.Windows.Forms.Panel();
            this.panelLineLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelLineTop
            // 
            this.panelLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLineTop.Location = new System.Drawing.Point(0, 0);
            this.panelLineTop.Name = "panelLineTop";
            this.panelLineTop.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelLineTop.Size = new System.Drawing.Size(567, 8);
            this.panelLineTop.TabIndex = 0;
            // 
            // panelLineBottom
            // 
            this.panelLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLineBottom.Location = new System.Drawing.Point(0, 599);
            this.panelLineBottom.Name = "panelLineBottom";
            this.panelLineBottom.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelLineBottom.Size = new System.Drawing.Size(567, 8);
            this.panelLineBottom.TabIndex = 1;
            // 
            // panelLineRight
            // 
            this.panelLineRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelLineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLineRight.Location = new System.Drawing.Point(559, 8);
            this.panelLineRight.Name = "panelLineRight";
            this.panelLineRight.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelLineRight.Size = new System.Drawing.Size(8, 591);
            this.panelLineRight.TabIndex = 1;
            // 
            // panelLineLeft
            // 
            this.panelLineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLineLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLineLeft.Name = "panelLineLeft";
            this.panelLineLeft.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panelLineLeft.Size = new System.Drawing.Size(8, 591);
            this.panelLineLeft.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 591);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FormAfficherPrComma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 607);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelLineLeft);
            this.Controls.Add(this.panelLineRight);
            this.Controls.Add(this.panelLineBottom);
            this.Controls.Add(this.panelLineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAfficherPrComma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produits commander";
            this.ResumeLayout(false);

        }


        public void InitializeComp(System.Collections.Generic.List<Produit_commande> listProduit)
        {
            InitializeComponent();
            foreach (var p in listProduit)
            {

                ElementPagnierVentes elmnt = new ElementPagnierVentes(false);
                elmnt.Title = p.Produit.libelle;
                elmnt.Id = p.codeProduit;
                elmnt.Icon = p.Produit.img != null ? Image.FromStream(new MemoryStream(p.Produit.img)) : Properties.Resources.loading_product;
                elmnt.Description = p.Produit.description;
                elmnt.QuntiteProduit = p.quantite + "";
                elmnt.PrixUnit = p.Produit.prixAchat;
                elmnt.PrixTotal = p.quantite * p.Produit.prixAchat +"";
                this.Text = "Produit(s) commander dans la commande N'" + p.NCommande; 
                this.flowLayoutPanel1.Controls.Add(elmnt);
            }
        }

        #endregion

        private System.Windows.Forms.Panel panelLineTop;
        private System.Windows.Forms.Panel panelLineBottom;
        private System.Windows.Forms.Panel panelLineRight;
        private System.Windows.Forms.Panel panelLineLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}