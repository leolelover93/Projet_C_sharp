namespace Project_ENSAF
{ 
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Drawing;
    using System.Windows.Forms;

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
        public void fct()
        {

            this.lblProdName.Text ="Said";

            MessageBox.Show("changed: " + this.lblProdName.Text);

        }
        private void InitializeComponent(Produit p)
        {
            this.SuspendLayout();
            // 
            // produit_cardUC
            // 
            this.Name = "produit_cardUC";
            this.Load += new System.EventHandler(this.produit_cardUC_Load_1);
            this.ResumeLayout(false);

        }

        #endregion 
        public System.Windows.Forms.Label lblProdName { get; set; } 
        public System.Windows.Forms.PictureBox prodImg;
        public System.Windows.Forms.Label lblProdDescri; 
        public System.Windows.Forms.Button btnReadMore;
        public System.Windows.Forms.Label lblprix; 
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;  
    }
}
