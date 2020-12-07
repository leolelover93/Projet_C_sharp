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
            this.emailFournisseur = new System.Windows.Forms.Label();
            this.prenomFournisseur = new System.Windows.Forms.Label();
            this.nomFournisseurText = new System.Windows.Forms.TextBox();
            this.prenomFournisseurText = new System.Windows.Forms.TextBox();
            this.emailFournisseurText = new System.Windows.Forms.TextBox();
            this.phoneFournisseur = new System.Windows.Forms.Label();
            this.phoneFournisseurText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addButton.Location = new System.Drawing.Point(152, 493);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(190, 47);
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
            this.panel1.Location = new System.Drawing.Point(-3, 1);
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
            this.nomFournisseur.Location = new System.Drawing.Point(86, 140);
            this.nomFournisseur.Name = "nomFournisseur";
            this.nomFournisseur.Size = new System.Drawing.Size(62, 23);
            this.nomFournisseur.TabIndex = 2;
            this.nomFournisseur.Text = "Nom :";
            // 
            // emailFournisseur
            // 
            this.emailFournisseur.AutoSize = true;
            this.emailFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailFournisseur.Location = new System.Drawing.Point(86, 301);
            this.emailFournisseur.Name = "emailFournisseur";
            this.emailFournisseur.Size = new System.Drawing.Size(64, 23);
            this.emailFournisseur.TabIndex = 3;
            this.emailFournisseur.Text = "Email :";
            // 
            // prenomFournisseur
            // 
            this.prenomFournisseur.AutoSize = true;
            this.prenomFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomFournisseur.Location = new System.Drawing.Point(86, 218);
            this.prenomFournisseur.Name = "prenomFournisseur";
            this.prenomFournisseur.Size = new System.Drawing.Size(88, 23);
            this.prenomFournisseur.TabIndex = 4;
            this.prenomFournisseur.Text = "Prénom :";
            this.prenomFournisseur.Click += new System.EventHandler(this.prenomFournisseur_Click);
            // 
            // nomFournisseurText
            // 
            this.nomFournisseurText.Location = new System.Drawing.Point(231, 143);
            this.nomFournisseurText.Name = "nomFournisseurText";
            this.nomFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.nomFournisseurText.TabIndex = 5;
            // 
            // prenomFournisseurText
            // 
            this.prenomFournisseurText.Location = new System.Drawing.Point(231, 223);
            this.prenomFournisseurText.Name = "prenomFournisseurText";
            this.prenomFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.prenomFournisseurText.TabIndex = 6;
            // 
            // emailFournisseurText
            // 
            this.emailFournisseurText.Location = new System.Drawing.Point(231, 306);
            this.emailFournisseurText.Name = "emailFournisseurText";
            this.emailFournisseurText.Size = new System.Drawing.Size(215, 20);
            this.emailFournisseurText.TabIndex = 7;
            // 
            // phoneFournisseur
            // 
            this.phoneFournisseur.AutoSize = true;
            this.phoneFournisseur.Font = new System.Drawing.Font("Pangram", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFournisseur.Location = new System.Drawing.Point(86, 392);
            this.phoneFournisseur.Name = "phoneFournisseur";
            this.phoneFournisseur.Size = new System.Drawing.Size(77, 23);
            this.phoneFournisseur.TabIndex = 8;
            this.phoneFournisseur.Text = "Phone :";
            // 
            // phoneFournisseurText
            // 
            this.phoneFournisseurText.Location = new System.Drawing.Point(231, 397);
            this.phoneFournisseurText.Name = "phoneFournisseurText";
            this.phoneFournisseurText.Size = new System.Drawing.Size(159, 20);
            this.phoneFournisseurText.TabIndex = 9;
            // 
            // Ajouter_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 552);
            this.Controls.Add(this.phoneFournisseurText);
            this.Controls.Add(this.phoneFournisseur);
            this.Controls.Add(this.emailFournisseurText);
            this.Controls.Add(this.prenomFournisseurText);
            this.Controls.Add(this.nomFournisseurText);
            this.Controls.Add(this.prenomFournisseur);
            this.Controls.Add(this.emailFournisseur);
            this.Controls.Add(this.nomFournisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Name = "Ajouter_Fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_Fournisseur";
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
        private System.Windows.Forms.Label emailFournisseur;
        private System.Windows.Forms.Label prenomFournisseur;
        private System.Windows.Forms.TextBox nomFournisseurText;
        private System.Windows.Forms.TextBox prenomFournisseurText;
        private System.Windows.Forms.TextBox emailFournisseurText;
        private System.Windows.Forms.Label phoneFournisseur;
        private System.Windows.Forms.TextBox phoneFournisseurText;
    }
}