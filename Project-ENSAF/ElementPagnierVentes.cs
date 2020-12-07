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
       
        public ElementPagnierVentes()
        {
         
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string _title;
        private string _description;
        private Image _icon;
        private string _quntiteProduit;
        private Color _iconBack;
        private string prixUnit;
        private string prixToatal;




        #region Properties

        [Category("Custom Props")]
        public string PrixTotal
        {
            get { return prixToatal; }
            set { prixToatal = value; labelPrixTotal.Text = prixToatal; }
        }

        [Category("Custom Props")]
        public string PrixUnit
        {
            get { return prixUnit; }
            set { prixUnit = value; labelPrixUnite.Text = value; }
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




    }
}
