namespace Project_ENSAF
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;
    partial class Form_Ajouter_Produit_Fournisseur
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
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tb_Prix_Achat = new System.Windows.Forms.TextBox();
            this.tb_Prix_Vente = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Parcourir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDV = new System.Windows.Forms.Label();
            this.textBoxDV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titre.Location = new System.Drawing.Point(0, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(635, 51);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Ajouter Produit";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Libe
            // 
            this.Libe.AutoSize = true;
            this.Libe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Libe.Location = new System.Drawing.Point(317, 101);
            this.Libe.Name = "Libe";
            this.Libe.Size = new System.Drawing.Size(62, 20);
            this.Libe.TabIndex = 3;
            this.Libe.Text = "Libelle :";
            // 
            // PA
            // 
            this.PA.AutoSize = true;
            this.PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PA.Location = new System.Drawing.Point(317, 141);
            this.PA.Name = "PA";
            this.PA.Size = new System.Drawing.Size(100, 20);
            this.PA.TabIndex = 4;
            this.PA.Text = "Prix d\'Achat :";
            // 
            // PV
            // 
            this.PV.AutoSize = true;
            this.PV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PV.Location = new System.Drawing.Point(317, 181);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(111, 20);
            this.PV.TabIndex = 5;
            this.PV.Text = "Prix de Vente :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(467, 98);
            this.tbLibelle.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbLibelle.Multiline = true;
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(156, 27);
            this.tbLibelle.TabIndex = 9;
            // 
            // tb_Prix_Achat
            // 
            this.tb_Prix_Achat.Location = new System.Drawing.Point(467, 138);
            this.tb_Prix_Achat.MinimumSize = new System.Drawing.Size(4, 27);
            this.tb_Prix_Achat.Multiline = true;
            this.tb_Prix_Achat.Name = "tb_Prix_Achat";
            this.tb_Prix_Achat.Size = new System.Drawing.Size(156, 27);
            this.tb_Prix_Achat.TabIndex = 10;
            // 
            // tb_Prix_Vente
            // 
            this.tb_Prix_Vente.Location = new System.Drawing.Point(467, 178);
            this.tb_Prix_Vente.MinimumSize = new System.Drawing.Size(4, 27);
            this.tb_Prix_Vente.Multiline = true;
            this.tb_Prix_Vente.Name = "tb_Prix_Vente";
            this.tb_Prix_Vente.Size = new System.Drawing.Size(156, 27);
            this.tb_Prix_Vente.TabIndex = 11;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Annuler.Location = new System.Drawing.Point(417, 389);
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
            this.Ajouter.Location = new System.Drawing.Point(529, 389);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 32);
            this.Ajouter.TabIndex = 16;
            this.Ajouter.Text = "Valider";
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
            this.Parcourir.Location = new System.Drawing.Point(77, 373);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(145, 32);
            this.Parcourir.TabIndex = 17;
            this.Parcourir.Text = "Parcourir...";
            this.Parcourir.UseVisualStyleBackColor = false;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_ENSAF.Properties.Resources.camera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(21, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(467, 261);
            this.tbDescription.MinimumSize = new System.Drawing.Size(4, 27);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(156, 42);
            this.tbDescription.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(320, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Description :";
            // 
            // labelDV
            // 
            this.labelDV.AutoSize = true;
            this.labelDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDV.Location = new System.Drawing.Point(317, 224);
            this.labelDV.Name = "labelDV";
            this.labelDV.Size = new System.Drawing.Size(139, 20);
            this.labelDV.TabIndex = 27;
            this.labelDV.Text = "Durée de validité  :";
            // 
            // textBoxDV
            // 
            this.textBoxDV.Location = new System.Drawing.Point(467, 217);
            this.textBoxDV.MinimumSize = new System.Drawing.Size(4, 27);
            this.textBoxDV.Multiline = true;
            this.textBoxDV.Name = "textBoxDV";
            this.textBoxDV.Size = new System.Drawing.Size(156, 27);
            this.textBoxDV.TabIndex = 28;
            // 
            // Form_Ajouter_Produit_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(635, 433);
            this.Controls.Add(this.textBoxDV);
            this.Controls.Add(this.labelDV);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Parcourir);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.tb_Prix_Vente);
            this.Controls.Add(this.tb_Prix_Achat);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.PA);
            this.Controls.Add(this.Libe);
            this.Controls.Add(this.Titre);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Produit_Fournisseur";
            this.Text = "Ajouter Produit";
            this.Load += new System.EventHandler(this.Form_Ajouter_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    

        #endregion
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Libe;
        private System.Windows.Forms.Label PA;
        private System.Windows.Forms.Label PV;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tb_Prix_Achat;
        private System.Windows.Forms.TextBox tb_Prix_Vente;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Parcourir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private Label labelDV;
        private TextBox textBoxDV;
    }
}