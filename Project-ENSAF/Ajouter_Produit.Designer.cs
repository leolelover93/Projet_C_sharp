namespace Project_ENSAF
{
    partial class Form_Ajouter_Produit
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
            this.Titre = new System.Windows.Forms.Label();
            this.CodeP = new System.Windows.Forms.Label();
            this.ID_Four = new System.Windows.Forms.Label();
            this.Libe = new System.Windows.Forms.Label();
            this.PA = new System.Windows.Forms.Label();
            this.PV = new System.Windows.Forms.Label();
            this.DE = new System.Windows.Forms.Label();
            this.Code_Produit = new System.Windows.Forms.TextBox();
            this.ID_Fournisseur = new System.Windows.Forms.TextBox();
            this.Libelle = new System.Windows.Forms.TextBox();
            this.Prix_Achat = new System.Windows.Forms.TextBox();
            this.Prix_Vente = new System.Windows.Forms.TextBox();
            this.Date_Expiration = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Parcourir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titre.Location = new System.Drawing.Point(0, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(506, 51);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Ajouter Produit";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // CodeP
            // 
            this.CodeP.AutoSize = true;
            this.CodeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CodeP.Location = new System.Drawing.Point(191, 97);
            this.CodeP.Name = "CodeP";
            this.CodeP.Size = new System.Drawing.Size(125, 22);
            this.CodeP.TabIndex = 1;
            this.CodeP.Text = "Code Produit :";
            // 
            // ID_Four
            // 
            this.ID_Four.AutoSize = true;
            this.ID_Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ID_Four.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_Four.Location = new System.Drawing.Point(191, 136);
            this.ID_Four.Name = "ID_Four";
            this.ID_Four.Size = new System.Drawing.Size(137, 22);
            this.ID_Four.TabIndex = 2;
            this.ID_Four.Text = "ID Fournisseur :";
            // 
            // Libe
            // 
            this.Libe.AutoSize = true;
            this.Libe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Libe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Libe.Location = new System.Drawing.Point(191, 174);
            this.Libe.Name = "Libe";
            this.Libe.Size = new System.Drawing.Size(72, 22);
            this.Libe.TabIndex = 3;
            this.Libe.Text = "Libelle :";
            // 
            // PA
            // 
            this.PA.AutoSize = true;
            this.PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PA.Location = new System.Drawing.Point(191, 214);
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(116, 22);
            this.PA.TabIndex = 4;
            this.PA.Text = "Prix d\'Achat :";
            // 
            // PV
            // 
            this.PV.AutoSize = true;
            this.PV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.PV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PV.Location = new System.Drawing.Point(191, 253);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(128, 22);
            this.PV.TabIndex = 5;
            this.PV.Text = "Prix de Vente :";
            // 
            // DE
            // 
            this.DE.AutoSize = true;
            this.DE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DE.Location = new System.Drawing.Point(191, 296);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(152, 22);
            this.DE.TabIndex = 6;
            this.DE.Text = "Date d\'Expiration:";
            // 
            // Code_Produit
            // 
            this.Code_Produit.Location = new System.Drawing.Point(341, 97);
            this.Code_Produit.Multiline = true;
            this.Code_Produit.Name = "Code_Produit";
            this.Code_Produit.Size = new System.Drawing.Size(156, 20);
            this.Code_Produit.TabIndex = 7;
            // 
            // ID_Fournisseur
            // 
            this.ID_Fournisseur.Location = new System.Drawing.Point(341, 138);
            this.ID_Fournisseur.Multiline = true;
            this.ID_Fournisseur.Name = "ID_Fournisseur";
            this.ID_Fournisseur.Size = new System.Drawing.Size(156, 20);
            this.ID_Fournisseur.TabIndex = 8;
            // 
            // Libelle
            // 
            this.Libelle.Location = new System.Drawing.Point(341, 176);
            this.Libelle.Multiline = true;
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(156, 20);
            this.Libelle.TabIndex = 9;
            // 
            // Prix_Achat
            // 
            this.Prix_Achat.Location = new System.Drawing.Point(341, 216);
            this.Prix_Achat.Multiline = true;
            this.Prix_Achat.Name = "Prix_Achat";
            this.Prix_Achat.Size = new System.Drawing.Size(156, 20);
            this.Prix_Achat.TabIndex = 10;
            // 
            // Prix_Vente
            // 
            this.Prix_Vente.Location = new System.Drawing.Point(341, 255);
            this.Prix_Vente.Multiline = true;
            this.Prix_Vente.Name = "Prix_Vente";
            this.Prix_Vente.Size = new System.Drawing.Size(156, 20);
            this.Prix_Vente.TabIndex = 11;
            // 
            // Date_Expiration
            // 
            this.Date_Expiration.Location = new System.Drawing.Point(341, 298);
            this.Date_Expiration.Multiline = true;
            this.Date_Expiration.Name = "Date_Expiration";
            this.Date_Expiration.Size = new System.Drawing.Size(156, 20);
            this.Date_Expiration.TabIndex = 12;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Annuler.Location = new System.Drawing.Point(403, 345);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(94, 32);
            this.Annuler.TabIndex = 13;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ajouter.Location = new System.Drawing.Point(290, 345);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 32);
            this.Ajouter.TabIndex = 16;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Parcourir
            // 
            this.Parcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Parcourir.FlatAppearance.BorderSize = 0;
            this.Parcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parcourir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Parcourir.Location = new System.Drawing.Point(25, 286);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(145, 32);
            this.Parcourir.TabIndex = 17;
            this.Parcourir.Text = "Parcourir...";
            this.Parcourir.UseVisualStyleBackColor = false;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Ajouter_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(506, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Parcourir);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Date_Expiration);
            this.Controls.Add(this.Prix_Vente);
            this.Controls.Add(this.Prix_Achat);
            this.Controls.Add(this.Libelle);
            this.Controls.Add(this.ID_Fournisseur);
            this.Controls.Add(this.Code_Produit);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.PA);
            this.Controls.Add(this.Libe);
            this.Controls.Add(this.ID_Four);
            this.Controls.Add(this.CodeP);
            this.Controls.Add(this.Titre);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Produit";
            this.Text = "Ajouter Produit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label CodeP;
        private System.Windows.Forms.Label ID_Four;
        private System.Windows.Forms.Label Libe;
        private System.Windows.Forms.Label PA;
        private System.Windows.Forms.Label PV;
        private System.Windows.Forms.Label DE;
        private System.Windows.Forms.TextBox Code_Produit;
        private System.Windows.Forms.TextBox ID_Fournisseur;
        private System.Windows.Forms.TextBox Libelle;
        private System.Windows.Forms.TextBox Prix_Achat;
        private System.Windows.Forms.TextBox Prix_Vente;
        private System.Windows.Forms.TextBox Date_Expiration;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Parcourir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}