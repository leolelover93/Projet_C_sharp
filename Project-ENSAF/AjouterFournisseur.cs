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
    public partial class Ajouter_Fournisseur : Form
    {
        Fournisseur f = new Fournisseur();
        public Ajouter_Fournisseur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prenomFournisseur_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.nomFournisseur = nomFournisseurText.Text.Trim();
            f.prenomFournisseur = prenomFournisseurText.Text.Trim();
            f.telFournisseur = phoneFournisseurText.Text.Trim();
            f.adressFournisseur = adresseFournisseurText.Text.Trim();
            using (dbContext db = new dbContext())
            {
                db.Fournisseurs.Add(f);
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Ajouté avec succès");
        }

        private void nomFournisseur_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            nomFournisseurText.Text = prenomFournisseurText.Text =adresseFournisseurText.Text=phoneFournisseurText.Text = "";
            addButton.Text = "Ajouter";
            f.idFournisseur = 0;
        }

        private void Ajouter_Fournisseur_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
