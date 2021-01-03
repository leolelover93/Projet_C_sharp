using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class FormDetailleFournisseur : Form
    {
        private int idFournisseur; 

        public FormDetailleFournisseur(int id )
        {
            this.idFournisseur = id;
            InitializeComponent();
        }

        public  void remplireLayout(dbContext db)
        {
            flowLayoutPanel1.Controls.Clear();
            var prod_fournissuer = db.Produits.Where(p => p.idFournisseur == this.idFournisseur).ToList();
            foreach (var item in prod_fournissuer)
            {
                flowLayoutPanel1.Controls.Add(new produit_cardUC((Produit)item, this));
            }
        }
        
        private void FormDetailleFournisseur_Load(object sender, EventArgs e)
        {
            var db = new dbContext();
            var fournisser = db.Fournisseurs.Where(f => f.idFournisseur == this.idFournisseur).FirstOrDefault(); 
            if(fournisser != null)
            {
                labelPrenom.Text = fournisser.prenomFournisseur;
                labelNom.Text = fournisser.nomFournisseur;
                labelAdresse.Text = fournisser.adressFournisseur;
                labelTele.Text = fournisser.telFournisseur; 
            }
            remplireLayout(db);
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Produit_Fournisseur a = new Form_Ajouter_Produit_Fournisseur(this,idFournisseur);
            a.Show();
        }
    }
}
