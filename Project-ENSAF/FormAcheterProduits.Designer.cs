namespace Project_ENSAF
{
    partial class FormAcheterProduits
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
            this.panelInfoBottom = new System.Windows.Forms.Panel();
            this.dateTimePickerSouhaite = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTFNb = new System.Windows.Forms.Label();
            this.labelTF = new System.Windows.Forms.Label();
            this.buttonSumbitPagnier = new System.Windows.Forms.Button();
            this.panelInfoBottom.SuspendLayout();
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 552);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            // 
            // panelInfoBottom
            // 
            this.panelInfoBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfoBottom.Controls.Add(this.dateTimePickerSouhaite);
            this.panelInfoBottom.Controls.Add(this.label1);
            this.panelInfoBottom.Controls.Add(this.labelTFNb);
            this.panelInfoBottom.Controls.Add(this.labelTF);
            this.panelInfoBottom.Controls.Add(this.buttonSumbitPagnier);
            this.panelInfoBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoBottom.Location = new System.Drawing.Point(8, 543);
            this.panelInfoBottom.Name = "panelInfoBottom";
            this.panelInfoBottom.Size = new System.Drawing.Size(551, 56);
            this.panelInfoBottom.TabIndex = 4;
            // 
            // dateTimePickerSouhaite
            // 
            this.dateTimePickerSouhaite.Location = new System.Drawing.Point(115, 7);
            this.dateTimePickerSouhaite.Name = "dateTimePickerSouhaite";
            this.dateTimePickerSouhaite.MinDate = System.DateTime.Now;
            this.dateTimePickerSouhaite.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerSouhaite.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date souhaité :";
            // 
            // labelTFNb
            // 
            this.labelTFNb.AutoSize = true;
            this.labelTFNb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelTFNb.Location = new System.Drawing.Point(108, 30);
            this.labelTFNb.Name = "labelTFNb";
            this.labelTFNb.Size = new System.Drawing.Size(40, 17);
            this.labelTFNb.TabIndex = 2;
            this.labelTFNb.Text = "label";
            // 
            // labelTF
            // 
            this.labelTF.AutoSize = true;
            this.labelTF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelTF.Location = new System.Drawing.Point(3, 30);
            this.labelTF.Name = "labelTF";
            this.labelTF.Size = new System.Drawing.Size(99, 17);
            this.labelTF.TabIndex = 1;
            this.labelTF.Text = "Total Facture :";
            // 
            // buttonSumbitPagnier
            // 
            this.buttonSumbitPagnier.BackColor = System.Drawing.Color.White;
            this.buttonSumbitPagnier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonSumbitPagnier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSumbitPagnier.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonSumbitPagnier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonSumbitPagnier.Location = new System.Drawing.Point(362, 18);
            this.buttonSumbitPagnier.Name = "buttonSumbitPagnier";
            this.buttonSumbitPagnier.Size = new System.Drawing.Size(181, 29);
            this.buttonSumbitPagnier.TabIndex = 0;
            this.buttonSumbitPagnier.Text = "Valider Commande";
            this.buttonSumbitPagnier.UseVisualStyleBackColor = false;
            // 
            // FormAcheterProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 607);
            this.Controls.Add(this.panelInfoBottom);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelLineLeft);
            this.Controls.Add(this.panelLineRight);
            this.Controls.Add(this.panelLineBottom);
            this.Controls.Add(this.panelLineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAcheterProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPagnierVentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAcheterProduits_FormClosing);
            this.Load += new System.EventHandler(this.FormAcheterProduits_Load);
            this.panelInfoBottom.ResumeLayout(false);
            this.panelInfoBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLineTop;
        private System.Windows.Forms.Panel panelLineBottom;
        private System.Windows.Forms.Panel panelLineRight;
        private System.Windows.Forms.Panel panelLineLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelInfoBottom;
        private System.Windows.Forms.Button buttonSumbitPagnier;
        private System.Windows.Forms.Label labelTF;
        private System.Windows.Forms.Label labelTFNb;
        private System.Windows.Forms.DateTimePicker dateTimePickerSouhaite;
        private System.Windows.Forms.Label label1;
    }
}