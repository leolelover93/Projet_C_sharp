using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_ENSAF
{

    public partial class UC_Gestion_Commades : UserControl
    {
        List<Produit> produitVentes;
        FormAcheterProduits a;
        DateTimePicker dateSouhaité;
        int nbCommandes = 0;
        FlowLayoutPanel flowLayoutPagnierProduitCommandes;
        public UC_Gestion_Commades()
        {
            InitializeComponent();
        }

        public UC_Gestion_Commades(List<Commande> commandes, FormAcheterProduits a =null)
        {
            this.a = a;
            initCompo(commandes);

        }

        private  Button findAjouterCommandeBtn()
        {
            Control[] ctrl = a.Controls.Find("panelInfoBottom", true);
            Panel panel = (Panel)ctrl[0];
            Control[] ctrl2 = panel.Controls.Find("buttonSumbitPagnier", true);
            Button btn = (Button)ctrl2[0];
            return btn; 
        }
        private DateTimePicker findDateSouhaité()
        {
            Control[] ctrl = a.Controls.Find("panelInfoBottom", true);
            Panel panel = (Panel)ctrl[0];
            Control[] ctrl2 = panel.Controls.Find("dateTimePickerSouhaite", true);
            DateTimePicker btn = (DateTimePicker)ctrl2[0];
            return btn;
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
            pictureBox.Visible = false;
            flowLayoutPagnierProduitCommandes = (FlowLayoutPanel)a.Controls[1];
            a.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.handel_AfterCloseForm);
            a.VisibleChanged += new System.EventHandler(this.handel2_AfterCloseForm);
            Button ajouterCommande = findAjouterCommandeBtn();
            ajouterCommande.Click += new System.EventHandler(this.affecterCommande);
            this.dateSouhaité = findDateSouhaité();

        }
        private void affecterCommande(object sender, EventArgs e)
        {
          
                var dbase = new dbContext();
            List<int> idfournisseurDansLaCommande = new List<int>();
            foreach (ElementPagnierVentes item in flowLayoutPagnierProduitCommandes.Controls) 
            {
                Produit p = dbase.Produits.
                             Where(s => s.codeProduit == item.Id).SingleOrDefault();
                if(p != null && !idfournisseurDansLaCommande.Contains(p.idFournisseur))
                {
                    idfournisseurDansLaCommande.Add(p.idFournisseur); 
                    
                }
                Commande CommadeAchaquefournisseur = new Commande()
                {
                    codeMagazin = 1,
                    dateDemande = DateTime.Now,
                    dateArriveSouhaite = dateSouhaité.Value,
                    statut = false,
                    idFournisseur = idfournisseurDansLaCommande[idfournisseurDansLaCommande.Count - 1]
                };
                dbase.Commandes.Add(CommadeAchaquefournisseur);
                dbase.SaveChanges();
                List<Commande> list = dbase.Commandes.ToList<Commande>();
                Commande lastOneId = list[list.Count - 1];
                if(a != null)
                {
                    Produit_commande pc = new Produit_commande()
                    {
                        codeProduit = item.Id,
                        quantite = int.Parse(item.QuntiteProduit),
                        NCommande = lastOneId.NCommande,

                    };
                    dbase.Produit_commande.Add(pc);
                    dbase.SaveChanges();
                }
                refrechDataGrid(list); 
            }

            if (produitVentes != null)
                {
                    produitVentes.Clear();
                }
                this.flowLayoutPanel1.Controls.Clear();
                remplireListeProduit();
            
            a.Visible = false;






        }
        private void remplireListeProduit()
        {
            try
            {
                var db = new dbContext();
                produitVentes = db.Produits.ToList<Produit>();
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
        }

        private void bAjoutCommande_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text == "Ajouter commande")
            {
                this.flowLayoutPanel1.Controls.Clear();
                remplireListeProduit();
               (sender as Button).Text = "Liste Commandes";
                pictureBox.Visible = true;
                labelNbCommande.Visible = true;
                panelContainerAjouterCommande.Visible = true;

            }
            else
            {
                panelContainerAjouterCommande.Visible = false;
                (sender as Button).Text = "Ajouter commande";
            }
            if((sender as Button).Text == "Ajouter commande")
            {
                labelNbCommande.Visible = false;
                pictureBox.Visible =false;

            }

        }

        private void labelHiden_TextChanged(object sender, EventArgs e)
        {
            if (labelHiden.Text != "")
            {
                nbCommandes++;
                labelNbCommande.Text = nbCommandes + "";
                int idProduit = int.Parse(labelHiden.Text.Split(' ')[0]); 
                int quantiteDemander = int.Parse(labelHiden.Text.Split(' ')[1]);
                pictureBox.Image = Properties.Resources.closed_box;
                Produit p = produitVentes.Where(pa => pa.codeProduit == idProduit).ToList()[0];
                var dbase = new dbContext();
                ElementPagnierVentes elmnt = new ElementPagnierVentes();
                elmnt.Title = p.libelle;
                elmnt.MaxQuantite = 10000;
                elmnt.Gain = (p.prixVente - p.prixAchat) * quantiteDemander;
                elmnt.Id = p.codeProduit;
                elmnt.Icon = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
                elmnt.Description = p.description;
                elmnt.Quantite = quantiteDemander;
                elmnt.QuntiteProduit = quantiteDemander+"";
                elmnt.PrixUnit = p.prixVente;
                elmnt.PrixTotal = p.prixVente * quantiteDemander + "";
                foreach (Control item in flowLayoutPagnierProduitCommandes.Controls)
                {
                    ElementPagnierVentes epv = (ElementPagnierVentes)item;
                    if (epv.Title == elmnt.Title)
                    {
                        epv.Quantite = quantiteDemander;
                        labelNbCommande.Text = --nbCommandes + "";
                        return;
                    }

                }
                flowLayoutPagnierProduitCommandes.Controls.Add(elmnt);
                labelHiden.Text = "";



            }
            labelHiden.Text = "";

            
            
        }
        private void handel_AfterCloseForm(object sender, EventArgs e)
        {
            labelNbCommande.Text = flowLayoutPagnierProduitCommandes.Controls.Count + "";
            nbCommandes = flowLayoutPagnierProduitCommandes.Controls.Count;
            if (flowLayoutPagnierProduitCommandes.Controls.Count == 0)
            {
                this.pictureBox.Image = Properties.Resources.open_box;
                
            }

        }

        private void handel2_AfterCloseForm(object sender, EventArgs e)
        {
            if (a.Visible == false)
            {
                labelNbCommande.Text = "0";
                nbCommandes = 0;
            }
            if (flowLayoutPagnierProduitCommandes.Controls.Count == 0)
            {
                this.pictureBox.Image = Properties.Resources.open_box;
               

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Object.Equals(a, null))
            {
                a = new FormAcheterProduits();
                flowLayoutPagnierProduitCommandes = (FlowLayoutPanel)a.Controls[0];
            }
            if (!Object.Equals(a, null) && flowLayoutPagnierProduitCommandes.Controls.Count > 0)
            {
                a.Show();
            }
            else
            {
                MessageBox.Show("Aucun Produit Commander !");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            var queryCommande = db.Commandes.Where(n => n.NCommande.ToString().Contains(searchBar.Text) ).ToList();
            refrechDataGrid(queryCommande);

        }

      
    }

}
