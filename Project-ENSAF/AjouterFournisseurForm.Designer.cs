namespace Project_ENSAF
{
    partial class AjouterFournisseurForm
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
            this.Libe = new System.Windows.Forms.Label();
            this.PA = new System.Windows.Forms.Label();
            this.PV = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbadress = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titre.Location = new System.Drawing.Point(0, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(408, 51);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Ajouter Fournisseur";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Libe
            // 
            this.Libe.AutoSize = true;
            this.Libe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Libe.Location = new System.Drawing.Point(24, 68);
            this.Libe.Name = "Libe";
            this.Libe.Size = new System.Drawing.Size(50, 20);
            this.Libe.TabIndex = 3;
            this.Libe.Text = "Nom: ";
            // 
            // PA
            // 
            this.PA.AutoSize = true;
            this.PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PA.Location = new System.Drawing.Point(24, 108);
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(64, 20);
            this.PA.TabIndex = 4;
            this.PA.Text = "Prénom";
            // 
            // PV
            // 
            this.PV.AutoSize = true;
            this.PV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PV.Location = new System.Drawing.Point(24, 148);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(77, 20);
            this.PV.TabIndex = 5;
            this.PV.Text = "Addresse";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(174, 65);
            this.tbNom.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbNom.Multiline = true;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(211, 27);
            this.tbNom.TabIndex = 9;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(174, 105);
            this.tbPrenom.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbPrenom.Multiline = true;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(211, 27);
            this.tbPrenom.TabIndex = 10;
            // 
            // tbadress
            // 
            this.tbadress.Location = new System.Drawing.Point(174, 145);
            this.tbadress.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbadress.Multiline = true;
            this.tbadress.Name = "tbadress";
            this.tbadress.Size = new System.Drawing.Size(211, 27);
            this.tbadress.TabIndex = 11;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Annuler.Location = new System.Drawing.Point(125, 254);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(119, 32);
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
            this.Ajouter.Location = new System.Drawing.Point(266, 254);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(119, 32);
            this.Ajouter.TabIndex = 16;
            this.Ajouter.Text = "Valider";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(174, 185);
            this.tbtel.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbtel.Multiline = true;
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(211, 27);
            this.tbtel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Téléphone";
            // 
            // AjouterFournisseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.tbadress);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.PA);
            this.Controls.Add(this.Libe);
            this.Controls.Add(this.Titre);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjouterFournisseurForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void initCompo2EditFournisseur(Fournisseur fournisseur)//edit case
        {
            InitializeComponent();
            tbNom.Text = fournisseur.nomFournisseur;
            tbPrenom.Text = fournisseur.prenomFournisseur;
            tbadress.Text = fournisseur.adressFournisseur;
            tbtel.Text = fournisseur.telFournisseur;
            isEditing = true;

        }

        #endregion
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Libe;
        private System.Windows.Forms.Label PA;
        private System.Windows.Forms.Label PV;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbadress;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.Label label1;
    }
}