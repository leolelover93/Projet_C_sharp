using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit : Form
    {
        Form1 formParent;
        Fournisseur fournisseur = new Fournisseur();
        Produit prod2Edit;
        public Form_Ajouter_Produit(Form1 formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }
        public Form_Ajouter_Produit(Produit p, Form1 formParent)
        {
            prod2Edit = p;
            this.formParent = formParent;
            initCompo(p);
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            var db = new dbContext();
            if (fournisseur.nomFournisseur != null)
            {
                try
                {
                    var prod = db.Produits.ToList<Produit>()[comboBox1.SelectedIndex];
                    Stock_Magazin stock = new Stock_Magazin();
                    stock.codeProduit = prod.codeProduit;
                    stock.codeMagazin = 1;
                    stock.dateExpiration = dateExpirePick.Value;
                    stock.quantite = Convert.ToInt32(tbQuantite.Text);
                    db.Stock_Magazin.Add(stock);
                    db.SaveChanges();
                    MessageBox.Show("Produit ajouté!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //refrech flowlayoutpanel1
                    if (formParent.filter == 0) formParent.btnViewAll_Click(null, null);
                    else if (formParent.filter == 1) formParent.btnDisponible_Click(null, null);
                    else if (formParent.filter == 2) formParent.btnNonDisponible_Click(null, null);
                    Form1.SetMessageLog("L'ajout d'un nouveau stock de " + prod.libelle + ", quantité: " + stock.quantite + ", date d'expiration: " + stock.dateExpiration);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("Veuillez remplir tous les champs demandés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {
            var db = new dbContext();
            foreach (var p in db.Produits)
            {
                comboBox1.Items.Add(p.libelle);
            }
            foreach (var item in db.Fournisseurs)
            {
                this.comboFornisseur.Items.Add(item.prenomFournisseur + " " + item.nomFournisseur);
            }
        }

        private void comboFornisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new dbContext();
            fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[comboFornisseur.SelectedIndex];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new dbContext();
            int i = comboBox1.SelectedIndex;
            var p = db.Produits.ToList<Produit>()[i];
            tbLibelle.Text = p.libelle;
            tb_Prix_Achat.Text = p.prixAchat.ToString();
            tb_Prix_Vente.Text = p.prixVente.ToString();
            tbDescription.Text = p.description;
            Fournisseur fournisseur = db.Fournisseurs.Find(p.idFournisseur);
            comboFornisseur.SelectedItem = fournisseur.prenomFournisseur + " " + fournisseur.nomFournisseur;
            try
            {
                pictureBox1.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("error! product has no img" + exc.Message);
            }
        }
    }
}
