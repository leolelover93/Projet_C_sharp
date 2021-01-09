using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Project_ENSAF
{
    public partial class produit_cardUC : UserControl
    {
        public Produit currentProd = new Produit();
        Form1 formParent;
        bool isDeatilleFournisseur = false;
        FormDetailleFournisseur formParent2;

        public produit_cardUC()
        {
            InitializeComponent();
        }
        public produit_cardUC(Produit p, Form1 formParent, int nbProds = 1)
        {
            this.isDeatilleFournisseur = false;
            this.currentProd = p;
            this.formParent = formParent;
            initCompo(p, nbProds);
        }
        public produit_cardUC(Produit p, FormDetailleFournisseur formParent, int nbProds = 1)
        {
            this.isDeatilleFournisseur = true;
            this.currentProd = p;
            this.formParent2 = formParent;
            initCompo(p, nbProds);
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Silver;
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {

            (sender as Button).BackColor = System.Drawing.Color.White;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.No;

            if (isDeatilleFournisseur)
            {
                res = MessageBox.Show("Ce produit sera supprimé définitivement du magazin avec tous les records, voulez vous continuez?", "Supprimer produit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        var db = new dbContext();
                        var produitFournisseur = db.Produits.Where(st => st.codeProduit.Equals(currentProd.codeProduit)).FirstOrDefault();
                        Form1.SetMessageLog($"Supprimer le produit {produitFournisseur.libelle} du Fournisseur {produitFournisseur.Fournisseur.nomFournisseur}  {produitFournisseur.Fournisseur.prenomFournisseur} depuis la base donne .");
                        db.Produits.Remove(produitFournisseur);
                        db.SaveChanges();
                        this.Dispose();

                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("Error! cant delete product :" + excep.Message);
                    }
                }
            }
            else
            {
                res = MessageBox.Show("Tous le stock de ce produit va être retirer, voulez vous continuez?", "Supprimer produit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        var db = new dbContext();
                        List<Stock_Magazin> stock2delete = db.Stock_Magazin.Where(st => st.codeProduit.Equals(currentProd.codeProduit)).ToList<Stock_Magazin>();
                        Form1.SetMessageLog($"Retirer tous le stock du produit {stock2delete[0].Produit.libelle} du Fournisseur {stock2delete[0].Produit.Fournisseur.nomFournisseur}  {stock2delete[0].Produit.Fournisseur.prenomFournisseur}.");
                        db.Stock_Magazin.RemoveRange(stock2delete);
                        db.SaveChanges();
                        this.Dispose();



                        // MessageBox.Show("product deleted"); 
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("Error! cant delete product :" + excep.Message);
                    }
                }
            }



        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (isDeatilleFournisseur)
            {
                Form_Ajouter_Produit_Adjust prodDescri = new Form_Ajouter_Produit_Adjust(currentProd, formParent2);
                prodDescri.Show();
            }
            else
            {
                Form_Ajouter_Produit prodDescri = new Form_Ajouter_Produit(currentProd, formParent);
                prodDescri.Show();
            }
        }
        private void btnReadMore_click(object sender, EventArgs e)
        {
            if (isDeatilleFournisseur)
            {
                FormProdDescri prodDescri = new FormProdDescri(currentProd, formParent2);
                prodDescri.Show();
            }
            else
            {
                FormProdDescri prodDescri = new FormProdDescri(currentProd, formParent);
                prodDescri.Show();
            }


        }



    }
}
