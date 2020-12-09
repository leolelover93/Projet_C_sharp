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
        public produit_Vente(Produit p)
        {
            this.idProduit = p.codeProduit; 
            InitializeComponent(p);
        }

        public void getTheControl()
        {
            //  this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
        }
        private void btnReadMore_Click(object sender, EventArgs e)
        {
           Control[] tabElment =  this.Parent.Parent.Controls.Find("listBoxItemProduct", true);
            Label label = (Label) tabElment[0];
            //Just to fire the event of the hidden text in form1
          if (label.Text == (this.idProduit.ToString() + " " + numericUpDownQauntite.Value)) label.Text = "";
            label.Text = (this.idProduit.ToString()+" "+numericUpDownQauntite.Value);

        }
    }
}
