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
    public partial class FormPagnierVentes : Form
    {

        List<ElementPagnierVentes> listElementPagnier = new List<ElementPagnierVentes>();
        decimal total = 0;

        public FormPagnierVentes()
        {

            InitializeComponent();
        }




        private void FormPagnierVentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }

        private void elemntTotalChanged(object sender, EventArgs e)
        {
            this.total = GetTotal();
            labelTFNb.Text = total + "";
        }

        private decimal GetTotal()
        {
            decimal total = 0;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                Control[] a = item.Controls.Find("labelPrixTotal", true);
                Label labelPrix = (Label)a[0];
                total += decimal.Parse(labelPrix.Text);
            }
            return total;
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            Control adedItem = e.Control;
            listElementPagnier.Add((ElementPagnierVentes)adedItem);
            Control[] a = e.Control.Controls.Find("labelPrixTotal", true);
            Label labelPrix = (Label)a[0];
            labelPrix.TextChanged += new System.EventHandler(this.elemntTotalChanged);
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control adedItem = e.Control;
            listElementPagnier.Remove((ElementPagnierVentes)adedItem);
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }

        private void FormPagnierVentes_Load(object sender, EventArgs e)
        {
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }

        private int retirerDeStock(int idProduit, int Quantite)
        {
            var db = new dbContext();
            List<Stock_Magazin> Stock_Prod = db.Stock_Magazin.
                            Where(s => (s.codeProduit == idProduit) && (DateTime.Compare(s.dateExpiration, DateTime.Now) > 0)).ToList<Stock_Magazin>();
            String libele = "";
            if (Stock_Prod != null)
            {

                for (int i = 0; i < Stock_Prod.Count; i++)
                {
                    libele = Stock_Prod[i].Produit.libelle;
                    if (Stock_Prod[i].quantite == 0)
                    {
                        db.Stock_Magazin.Remove(Stock_Prod[i]);
                    }
                    if (Stock_Prod[i].quantite - Quantite < 0)
                    {
                        int rest = Quantite - Stock_Prod[i].quantite;
                        Stock_Prod[i].quantite -= (Quantite - rest);
                        db.Stock_Magazin.Remove(Stock_Prod[i]);
                        db.SaveChanges();
                        Quantite = rest;
                    }
                    else
                    {
                        Stock_Prod[i].quantite -= Quantite;
                        db.SaveChanges();
                        return Stock_Prod[i].codeProduit;

                    }

                }

            }
            else
            {
                DialogResult a = MessageBox.Show($"Le produits {libele} n'existe pas dans le stock, vous voulez continuez l'achat", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a != DialogResult.OK)
                {
                    return 0;
                }
            }
            return 1;

        }
        private void buttonSumbitPagnier_Click(object sender, EventArgs e)
        {

            var db = new dbContext();
            string qVendu = "";
            string cProduits = "";
            decimal _gain = 0;
            int qVenduInt = 0;
            //Just to fix the aded Column CodeProduit in Vente_magazin
            int prodActuel = 1;
            foreach (ElementPagnierVentes item in listElementPagnier)
            {

                _gain += item.Gain;
                qVendu += item.Quantite + " ";
                qVenduInt += item.Quantite;
                cProduits += item.Id + " ";
                prodActuel = retirerDeStock(item.Id, item.Quantite);
                if (prodActuel == 0)
                {
                    return;
                }

            }
            qVendu += qVenduInt;
            var facture = new Vente_magazin()
            {
                //Les quantité des Produits commandées Stocker successivement comme un string separer par des espace 
                //La dernier valuer c'est le toatal de facture
                quantiteVendus = qVendu,
                codeMagazin = 1,
                codeProduit = prodActuel,
                gain = _gain,
                dateVente = DateTime.Now.Date,
                //Les Produits commandées Stocker comme un string separer par des espace 
                codeProduits = cProduits

            };
            try
            {
                db.Vente_magazin.Add(facture);
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show($"Probléme dans BaseDonné (Stock) ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Facture réglé!");
            listElementPagnier.Clear();
            flowLayoutPanel1.Controls.Clear();
            this.Visible = false;


        }
    }
}
