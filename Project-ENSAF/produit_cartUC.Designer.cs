namespace Project_ENSAF
{ 
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Drawing;

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
         
        private void InitializeComponent(Produit p)
        {
            this.SuspendLayout();
            // 
            // produit_cardUC
            // 
            this.Name = "produit_cardUC";
            this.ResumeLayout(false);

        }

        #endregion
       /* [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }*/
        public System.Windows.Forms.Label lblProdName { get; set; }
      /*  public string LblProdName
        {
            get { return lblProdName.Text; }
            set { this.lblProdName.Text = value; }
        }*/
        public System.Windows.Forms.PictureBox prodImg;
        public System.Windows.Forms.Label lblProdDescri;
      /*  public string LblProdDescri
        {
            get { return lblProdName.Text; }
            set { this.lblProdName.Text = value; }
        }*/
        public System.Windows.Forms.Button btnReadMore;
        public System.Windows.Forms.Label lblprix;
        /*  public string Lblprix
          {
              get { return lblProdName.Text; }
              set { this.lblProdName.Text = value; }
          }*/
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
      
/*

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true), Description("The Image Index for the button"), DefaultValue(0)]
        [System.ComponentModel.TypeConverter(typeof(System.Windows.Forms.ImageIndexConverter))]
        public int ImageIndex
        {
            get { return btnPick.ImageIndex; }
            set { btnPick.ImageIndex = value; }
        }*/

    }
}
