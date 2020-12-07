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
            
        }
        private void btnReadMore_Click(object sender, EventArgs e)
        {
           Control[] tabElment =  this.Parent.Parent.Controls.Find("listBoxItemProduct", true);
           Label label = (Label) tabElment[0];
            //Just to fire the resize event
            label.Text = (this.idProduit.ToString()); 
        }
    }
}
