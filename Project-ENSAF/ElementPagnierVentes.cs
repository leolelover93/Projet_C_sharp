using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class ElementPagnierVentes : UserControl
    {
        bool closeIconVisbility = true;


        public ElementPagnierVentes(bool closeIconVisbility = true)
        {
            this.closeIconVisbility = closeIconVisbility;
            InitializeComponent();
        }
        public ElementPagnierVentes(int quantite , bool closeIconVisbility = true )
        {
            this.closeIconVisbility = closeIconVisbility;
            InitializeComp(quantite);
        }

     

        private string _title;
        private string _description;
        private Image _icon;
        private string _quntiteProduit;
        private Color _iconBack;
        private decimal prixUnit;
        private string prixToatal;
        private int qunatite;
        private int id;
        private decimal gain;
        private int maxQuantite;







        #region Properties

        [Category("Custom Props")]
        public string PrixTotal
        {
            get { return prixToatal; }
            set { prixToatal = value; labelPrixTotal.Text = prixToatal; }
        }

        [Category("Custom Props")]
        public int MaxQuantite
        {
            get { return maxQuantite; }
            set { maxQuantite = value; numericUpDownQunatite.Maximum = value; }
        }


        [Category("Custom Props")]
        public decimal Gain
        {
            get { return gain; }
            set { gain = value; }
        }

        [Category("Custom Props")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        [Category("Custom Props")]
        public int Quantite
        {
            get { return qunatite; }
            set { qunatite = value; numericUpDownQunatite.Value = Quantite; }
        }


        [Category("Custom Props")]
        public decimal PrixUnit
        {
            get { return prixUnit; }
            set { prixUnit = value; labelPrixUnite.Text = (value.ToString() +"DH"); }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelProduit.Text = value; }
        }


        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; labelDescription.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; icon.Image = value; }
        }

        [Category("Custom Props")]
        public string QuntiteProduit
        {
            get { return _quntiteProduit; }
            set { _quntiteProduit = value; labelNbProduit.Text = value; }
        }

        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panelIconBackground.BackColor = value; }
        }




        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel floawLayout = (FlowLayoutPanel) this.Parent.Parent.Controls[1];
            floawLayout.Controls.Remove(this);
        }

        private void numericUpDownQunatite_ValueChanged(object sender, EventArgs e)
        {
            decimal Qpr = numericUpDownQunatite.Value;
          //decimal prix = decimal.Parse(this.PrixTotal.ToString());
            labelNbProduit.Text = numericUpDownQunatite.Value + "";
            labelPrixTotal.Text =  prixUnit*Qpr +"";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Visible = this.closeIconVisbility;
            numericUpDownQunatite.Visible = this.closeIconVisbility;
          
        }
    }
}
