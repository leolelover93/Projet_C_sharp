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
    public partial class UC_Gestion_Commades : UserControl
    {
        public UC_Gestion_Commades()
        {
            InitializeComponent();
        }

        public UC_Gestion_Commades(List<Commande> commandes)
        {
            initCompo(commandes);

        }

        private void UC_Gestion_Commades_Load(object sender, EventArgs e)
        {
            panelContainerAjouterCommande.Visible = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 213, 217);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 151, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void bAjoutCommande_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text == "Ajouter commande")
            {
                this.flowLayoutPanel1.Controls.Clear();
                panelContainerAjouterCommande.Visible = true;
                try
                {
                    var db = new dbContext();
                    List<Produit> produitVentes = db.Produits.ToList<Produit>();
                    //groupin by libelle
                    var query = (from p in db.Produits
                                 group p by new { p.libelle, } into grp
                                 select new { first = grp.FirstOrDefault() });
                    int quantity = 0;
                    if (query.Count() > 0)
                    {
                        foreach (var elm in query)
                        {
                            foreach (var s in db.Stock_Magazin)
                            {
                                if (db.Produits.Find(s.codeProduit).libelle.Equals(elm.first.libelle)) quantity += s.quantite;
                            }
                            this.flowLayoutPanel1.Controls.Add(new produit_Vente(elm.first, quantity, true));
                            quantity = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connection! " + ex.Message);
                }
                (sender as Button).Text = "Liste Commandes";

            }
            else
            {
                panelContainerAjouterCommande.Visible = false;
                (sender as Button).Text = "Ajouter commande";

            }

        }

        private void labelHiden_TextChanged(object sender, EventArgs e)
        {
            if (labelHiden.Text != "")
            {
                int idProduit = int.Parse(labelHiden.Text.Split(' ')[0]); 
                int quantiteDemander = int.Parse(labelHiden.Text.Split(' ')[1]); 



            }
            labelHiden.Text = "";

            
            
        }
    }
}
