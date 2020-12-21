namespace Project_ENSAF
{
    partial class Ajouter_Fournisseur
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
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContactFournisseur = new System.Windows.Forms.Label();
            this.nomFournisseur = new System.Windows.Forms.Label();
            this.prenomFournisseur = new System.Windows.Forms.Label();
            this.nomFournisseurText = new System.Windows.Forms.TextBox();
            this.prenomFournisseurText = new System.Windows.Forms.TextBox();
            this.phoneFournisseur = new System.Windows.Forms.Label();
            this.phoneFournisseurText = new System.Windows.Forms.TextBox();
            this.annulerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adresseFournisseurText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addButton.Location = new System.Drawing.Point(42, 414);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.ContactFournisseur);
            this.panel1.Location = new System.Drawing.Point(-29, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 60);
            this.panel1.TabIndex = 1;
            // 
            // ContactFournisseur
            // 
            this.ContactFournisseur.AutoSize = true;
            this.ContactFournisseur.Font = new System.Drawing.Font("Pangram", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactFournisseur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContactFournisseur.Location = new System.Drawing.Point(119, 11);
            this.ContactFournisseur.Name = "ContactFournisseur";
            this.ContactFournisseur.Size = new System.Drawing.Size(265, 32);
            this.ContactFournisseur.TabIndex = 2;
            this.ContactFournisseur.Text = "Contact Fournisseur";
            this.ContactFournisseur.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomFournisseur
            // 
            this.nomFournisseur.AutoSize = true;
            this.nomFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomFournisseur.Location = new System.Drawing.Point(38, 102);
            this.nomFournisseur.Name = "nomFournisseur";
            this.nomFournisseur.Size = new System.Drawing.Size(62, 23);
            this.nomFournisseur.TabIndex = 2;
            this.nomFournisseur.Text = "Nom :";
            this.nomFournisseur.Click += new System.EventHandler(this.nomFournisseur_Click);
            // 
            // prenomFournisseur
            // 
            this.prenomFournisseur.AutoSize = true;
            this.prenomFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomFournisseur.Location = new System.Drawing.Point(38, 173);
            this.prenomFournisseur.Name = "prenomFournisseur";
            this.prenomFournisseur.Size = new System.Drawing.Size(88, 23);
            this.prenomFournisseur.TabIndex = 4;
            this.prenomFournisseur.Text = "Prénom :";
            this.prenomFournisseur.Click += new System.EventHandler(this.prenomFournisseur_Click);
            // 
            // nomFournisseurText
            // 
            this.nomFournisseurText.Location = new System.Drawing.Point(196, 107);
            this.nomFournisseurText.Name = "nomFournisseurText";
            this.nomFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.nomFournisseurText.TabIndex = 5;
            // 
            // prenomFournisseurText
            // 
            this.prenomFournisseurText.Location = new System.Drawing.Point(196, 173);
            this.prenomFournisseurText.Name = "prenomFournisseurText";
            this.prenomFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.prenomFournisseurText.TabIndex = 6;
            // 
            // phoneFournisseur
            // 
            this.phoneFournisseur.AutoSize = true;
            this.phoneFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFournisseur.Location = new System.Drawing.Point(38, 246);
            this.phoneFournisseur.Name = "phoneFournisseur";
            this.phoneFournisseur.Size = new System.Drawing.Size(77, 23);
            this.phoneFournisseur.TabIndex = 8;
            this.phoneFournisseur.Text = "Phone :";
            // 
            // phoneFournisseurText
            // 
            this.phoneFournisseurText.Location = new System.Drawing.Point(196, 251);
            this.phoneFournisseurText.Name = "phoneFournisseurText";
            this.phoneFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.phoneFournisseurText.TabIndex = 9;
            // 
            // annulerButton
            // 
            this.annulerButton.BackColor = System.Drawing.Color.Red;
            this.annulerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annulerButton.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.annulerButton.Location = new System.Drawing.Point(260, 414);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(139, 40);
            this.annulerButton.TabIndex = 10;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = false;
            this.annulerButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adresse :";
            // 
            // adresseFournisseurText
            // 
            this.adresseFournisseurText.Location = new System.Drawing.Point(196, 330);
            this.adresseFournisseurText.Name = "adresseFournisseurText";
            this.adresseFournisseurText.Size = new System.Drawing.Size(203, 20);
            this.adresseFournisseurText.TabIndex = 12;
            // 
            // Ajouter_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 491);
            this.Controls.Add(this.adresseFournisseurText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.phoneFournisseurText);
            this.Controls.Add(this.phoneFournisseur);
            this.Controls.Add(this.prenomFournisseurText);
            this.Controls.Add(this.nomFournisseurText);
            this.Controls.Add(this.prenomFournisseur);
            this.Controls.Add(this.nomFournisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Name = "Ajouter_Fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_Fournisseur";
            this.Load += new System.EventHandler(this.Ajouter_Fournisseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ContactFournisseur;
        private System.Windows.Forms.Label nomFournisseur;
        private System.Windows.Forms.Label prenomFournisseur;
        private System.Windows.Forms.TextBox nomFournisseurText;
        private System.Windows.Forms.TextBox prenomFournisseurText;
        private System.Windows.Forms.Label phoneFournisseur;
        private System.Windows.Forms.TextBox phoneFournisseurText;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresseFournisseurText;
    }
}