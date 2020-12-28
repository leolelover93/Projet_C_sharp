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
            foreach(Control item in flowLayoutPanel1.Controls)
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
            Label  labelPrix = (Label)a[0];
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

        private void buttonSumbitPagnier_Click(object sender, EventArgs e)
        {

            var db = new dbContext();
            string qVendu = "";
            string cProduits = "";
            decimal _gain = 0;
            int qVenduInt = 0;
            int prodActuel = 1; 
            foreach(ElementPagnierVentes item in listElementPagnier)
            {
                var Stock_Prod = db.Stock_Magazin.
                             Where(s => s.codeProduit == item.Id).SingleOrDefault();
                if(Stock_Prod != null)
                {
                    _gain += item.Gain;
                    qVendu += item.Quantite + " ";
                    qVenduInt += item.Quantite;
                    cProduits += item.Id + " ";
                    Stock_Prod.quantite -= item.Quantite;
                    db.SaveChanges();
                }else
                {
                  DialogResult a =  MessageBox.Show($"Le produits {item.Title} n'existe pas dans le stock, vous voulez continuez l'achat", "WARNING", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning); 
                    if(a != DialogResult.OK)
                    {
                        return; 
                    }
                }
                prodActuel = Stock_Prod.codeProduit;
            }
            //La dernier valuer c'est le toatal de facture
            qVendu += qVenduInt;
            var facture = new Vente_magazin()
            {
                quantiteVendus = qVendu,
                codeMagazin = 1,
                codeProduit = prodActuel,
                gain = _gain,
                dateVente = DateTime.Now.Date,
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
            
            MessageBox.Show("facture aded");
            listElementPagnier.Clear();
            flowLayoutPanel1.Controls.Clear();
            this.Visible = false;


        }
    }
}
