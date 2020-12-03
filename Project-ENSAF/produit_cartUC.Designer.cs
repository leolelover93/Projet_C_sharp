namespace Project_ENSAF
{
    partial class produit_cardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produit_cardUC));
            this.lblProdName = new System.Windows.Forms.Label();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.lblProdDescri = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            this.lblProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(-1, 119);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(56, 23);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "Bimo";
            this.lblProdName.Click += new System.EventHandler(this.label1_Click);
            // 
            // prodImg
            // 
            this.prodImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodImg.Image = ((System.Drawing.Image)(resources.GetObject("prodImg.Image")));
            this.prodImg.InitialImage = null;
            this.prodImg.Location = new System.Drawing.Point(3, -1);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(166, 117);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodImg.TabIndex = 1;
            this.prodImg.TabStop = false;
            // 
            // lblProdDescri
            // 
            this.lblProdDescri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdDescri.AutoSize = true;
            this.lblProdDescri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdDescri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProdDescri.Location = new System.Drawing.Point(0, 148);
            this.lblProdDescri.MaximumSize = new System.Drawing.Size(190, 40);
            this.lblProdDescri.Name = "lblProdDescri";
            this.lblProdDescri.Size = new System.Drawing.Size(177, 40);
            this.lblProdDescri.TabIndex = 2;
            this.lblProdDescri.Text = "this is product description. it gives the products caracteristics ...";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(84, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Read more";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(-1, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "$12";
            // 
            // produit_cardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblProdDescri);
            this.Controls.Add(this.prodImg);
            this.Controls.Add(this.lblProdName);
            this.MaximumSize = new System.Drawing.Size(172, 218);
            this.MinimumSize = new System.Drawing.Size(172, 218);
            this.Name = "produit_cardUC";
            this.Size = new System.Drawing.Size(172, 218);
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.Label lblProdDescri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
