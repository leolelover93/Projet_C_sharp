using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{

    public partial class produit_Vente : UserControl
    {
        private int idProduit;
        private int quntite;

        public int Quantite
        {
            get { return quntite; }
            set { quntite = value; }
        }
        public produit_Vente()
        {
            InitializeComponent();
        }
        public produit_Vente(Produit p)
        {
            this.idProduit = p.codeProduit; 
            InitializeComp2(p);
        }
        public produit_Vente(Produit p,int quantite)
        {
            this.idProduit = p.codeProduit;
            this.Quantite = quantite;
            InitializeComp(p,quantite);
        }


        public void getTheControl()
        {
            //  this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
        }
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if(this.Quantite > 0)
            {
                Control[] tabElment = this.Parent.Parent.Parent.Controls.Find("listBoxItemProduct", true);
                Label label = (Label)tabElment[0];
                //Just to fire the event of the hidden text in form1
                if (label.Text == (this.idProduit.ToString() + " " + numericUpDownQauntite.Value)) label.Text = "";
                label.Text = (this.idProduit.ToString() + " " + numericUpDownQauntite.Value);

            }else
            {
                MessageBox.Show("hna ghydar wahd lblan naadi");
            }

        }

        private void produit_Vente_Load(object sender, EventArgs e)
        {
          
        }
    }
}
