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
    public partial class produit_cardUC : UserControl
    {
        public int codeProduit { get; set; }
        public int idFournisseur { get; set; }
        public string libelle { get; set; }
        public decimal prixAchat { get; set; }
        public decimal prixVente { get; set; }
        public System.DateTime dateExpiration { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
        public produit_cardUC()
        {
           /* codeProduit = p.codeProduit;
            idFournisseur = p.idFournisseur;
            libelle = p.libelle;
            prixAchat = p.prixAchat;
            prixVente = p.prixVente;
            dateExpiration = p.dateExpiration;
            image = p.image;
            description = p.description;
            this.lblPrice.Text = Convert.ToString(p.prixVente);
            this.lblProdName.Text = p.libelle;
            this.lblProdDescri.Text = p.description;*/
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
