using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Project_ENSAF
{
    public partial class Form1 : Form
    {
        Button previousBtn,prvBtnFilter;
        FormPagnierVentes a;
        int nbProduitInBasket = 0; 
        FlowLayoutPanel flowLayoutPagnierProduitVentes;
        public List<Produit> produitVentes = new List<Produit>();
        List<Produit> listeProduitsPagnier = new List<Produit>();
        dbContext db;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;
            db = new dbContext();
            produitVentes = db.Produits.ToList<Produit>();
            var query = (from p in db.Produits
                         group p by new { p.libelle, } into grp
                         select new
                         {
                             libelle = grp.Key.libelle,
                             cout = grp.Count(),
                             first = grp.FirstOrDefault(),
                             grop = grp.ToList<Produit>()
                         }); 
            foreach (var item in query)
            {
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(item.grop[0],this, item.cout));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            panelGestionVentes.Visible = false;
            prvBtnFilter = btnViewAll;
            btnViewAll.BackColor = Color.FromArgb(72, 152, 207);
            btnViewAll.ForeColor = Color.White;
            previousBtn = BtnGestionProduits;
            BtnGestionProduits.BackColor = Color.FromArgb(13, 72, 114);
            //Ajout d'un produit dans la base
            /*   try
             {

                 byte[] buffer = (byte[])new ImageConverter().ConvertTo(Properties.Resources.sweets, typeof(byte[]));
                 Produit p = new Produit()
                 {
                     libelle = "danone2",
                     dateExpiration = DateTime.Now,
                     prixAchat = (decimal)1.5,
                     prixVente = (decimal)2,
                     description = "danone banane",
                     idFournisseur = 1,
                     img = buffer
                 };
                 var db = new dbContext();
                 db.Produits.Add(p);
                 this.Parent.Refresh();
                 db.SaveChanges();

                 MessageBox.Show("product insertion successed:");
             }
             catch (Exception exce)
             {
                 MessageBox.Show("Error! cant insert product :" + exce.Message);
             }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text == "Gestion Produits")
            {
                panelGestionProduit.Visible = true;
                panelGestionVentes.Visible = false; 
            }
            if ((sender as Button).Text == "Gestion Ventes")
            { 
                panelGestionProduit.Visible = false;
                panelGestionVentes.Visible = true;
                if(flowLayoutPanelVente.Controls.Count == 0)
                {
                    produitVentes = db.Produits
                    .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) > 0)
                    .ToList<Produit>();
                    foreach (var prd in produitVentes)
                    {
                        this.flowLayoutPanelVente.Controls.Add(new produit_Vente(prd));
                    } 
                }
                if (a == null)
                {
                    a = new FormPagnierVentes();
                    flowLayoutPagnierProduitVentes = (FlowLayoutPanel)a.Controls[1];
                    a.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.handel_AfterCloseForm); 
                } 
            }

            previousBtn.BackColor = Color.FromArgb(0, 53, 92);
            previousBtn = (sender as Button);
            checkedLinePanel.Height = (sender as Button).Height;
            checkedLinePanel.Top = (sender as Button).Top;
            (sender as Button).BackColor = Color.FromArgb(13, 72, 114);
            
        } 
        private void filter_style_click(object sender, EventArgs e)
        { 
                prvBtnFilter.BackColor = Color.White;
                prvBtnFilter.ForeColor = Color.FromArgb(72, 152, 207);
                prvBtnFilter = (sender as Button);
                prvBtnFilter.BackColor = Color.FromArgb(72, 152, 207);
                prvBtnFilter.ForeColor = Color.White; 
        }   
        private void textBoxSearchProduitVentes_TextChanged(object sender, EventArgs e)
        {
            string produitArech = textBoxSearchProduitVentes.Text;
            List<Produit> ToRender  =  produitVentes.Where(p => p.libelle.ToLower().Contains(produitArech.ToLower())).ToList();
            flowLayoutPanelVente.Controls.Clear();
            foreach(var prd in ToRender)
            {
                flowLayoutPanelVente.Controls.Add(new produit_Vente(prd));  
            }
        } 
        private void btnAjouterAuPagnier_Click(object sender, EventArgs e)
        { 
            this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
        }   
        public void btnViewAll_Click(object sender, EventArgs e)
        {
            if (sender !=null) filter_style_click( sender,  e);  
            produitVentes = db.Produits.ToList<Produit>();
            var dbase = new dbContext();//fix alot of stuff
            var query = (from p in dbase.Produits
                         group p by new { p.libelle, } into grp
                         select new
                         {
                             libelle = grp.Key.libelle,
                             cout = grp.Count(),
                             first=grp.FirstOrDefault(),
                             grop=grp.ToList<Produit>()
                         });
             flowLayoutPanel1.Controls.Clear();
             foreach (var item in query)
             { 
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(item.grop[0], this, item.cout)); 
            } 
        }
        public void btnDisponible_Click(object sender, EventArgs e)
        { 
            if (sender != null) filter_style_click(sender, e);
            var dbase = new dbContext();
            produitVentes = dbase.Produits
                   .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) > 0)
                   .ToList<Produit>();
            var query = (from p in produitVentes
                         group p by new { p.libelle, } into grp
                         select new
                         {
                             libelle = grp.Key.libelle,
                             cout = grp.Count(),
                             first = grp.FirstOrDefault(),
                             grop = grp.ToList<Produit>()
                         });
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in query)
            { 
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(item.grop[0], this, item.cout));
            } 
        } 
        private void tbSearch_TextChanged(object sender, EventArgs e)
        { 
            string cle = tbSearch.Text;
            Console.WriteLine("\ncle: "+cle);  
            List<Produit> prodTrouves = produitVentes.Where(p => p.libelle.ToLower().IndexOf(cle.ToLower()) !=-1)
                                                   .ToList(); 
            var query = (from p in prodTrouves
                         group p by new { p.libelle, } into grp
                         select new
                         {
                             libelle = grp.Key.libelle,
                             cout = grp.Count(),
                             first = grp.FirstOrDefault(),
                             grop = grp.ToList<Produit>()
                         });
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in query)
            {
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(item.grop[0], this, item.cout));
            }
        } 
        public void btnNonDisponible_Click(object sender, EventArgs e)
        {
            if (sender != null) filter_style_click(sender, e);
            //get expired products from db

            var dbase = new dbContext();
            produitVentes = dbase.Produits
                  .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) < 0)
                  .ToList<Produit>();
            //group expired products by 'libelle'
            var query = (from p in produitVentes
                         group p by new { p.libelle, } into grp
                         select new
                         {
                             libelle = grp.Key.libelle,
                             cout = grp.Count(),
                             first = grp.FirstOrDefault(),
                             grop = grp.ToList<Produit>()
                         });
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in query)
            {
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(item.grop[0], this, item.cout));
            }
        }  
        private void btnViderPanger_Click(object sender, EventArgs e)
        {
            labelBasket.Text = "0";
            nbProduitInBasket = 0; 
            this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            flowLayoutPagnierProduitVentes.Controls.Clear();
            Control[] a = flowLayoutPagnierProduitVentes.Parent.Controls[0].Controls.Find("labelTFNb", true);
            Label labelPrixTotal = (Label)a[0];
            labelPrixTotal.Text = "0";
        } 
        private void listBoxItemProduct_TextChanged(object sender, EventArgs e)
        {
           /* if(listBoxItemProduct.Text != "")
            {
                this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                Produit p = produitVentes.Where(pa => pa.codeProduit == int.Parse(listBoxItemProduct.Text.Split(' ')[0])).ToList()[0];
                labelBasket.Text = ++nbProduitInBasket + "";
                ElementPagnierVentes elmnt = new ElementPagnierVentes();
                elmnt.Title = p.libelle;
                elmnt.Icon = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
                elmnt.Description = p.description;
                elmnt.Quantite = int.Parse(listBoxItemProduct.Text.Split(' ')[1]);
                elmnt.QuntiteProduit = listBoxItemProduct.Text.Split(' ')[1];
                elmnt.PrixUnit = p.prixVente.ToString();
                elmnt.PrixTotal = p.prixVente * int.Parse(listBoxItemProduct.Text.Split(' ')[1]) + "";
                foreach (Control item in flowLayoutPagnierProduitVentes.Controls)
                {
                    ElementPagnierVentes epv = (ElementPagnierVentes)item;
                    if (epv.Title == elmnt.Title)
                    {
                        epv.Quantite = int.Parse(listBoxItemProduct.Text.Split(' ')[1]);
                        labelBasket.Text = --nbProduitInBasket + "";

                        return;
                    }

                }
                flowLayoutPagnierProduitVentes.Controls.Add(elmnt);
                listBoxItemProduct.Text = "";
                
            }*/


        }
        private void buttonSearchGP_Click_1(object sender, EventArgs e)
        {
            string produitArech = textBoxSearchProduitVentes.Text;
            Console.WriteLine(produitArech);
            List<Produit> ToRender = produitVentes.Where(p => p.libelle.Contains(produitArech)).ToList();
            if (ToRender.Count > 0) flowLayoutPanel1.Controls.Clear();
            foreach (var prd in ToRender)
            {
                flowLayoutPanel1.Controls.Add(new produit_Vente(prd));
            }
        }
        private void pictureBoxBasket_Click(object sender, EventArgs e)
        {
            if (Object.Equals(a,null))
            {
                a = new FormPagnierVentes();
                flowLayoutPagnierProduitVentes = (FlowLayoutPanel)a.Controls[0];
            }
            if(!Object.Equals(a, null) && flowLayoutPagnierProduitVentes.Controls.Count > 0)
            {
                a.Show(); 
            }else
            {
                MessageBox.Show("Le pagnier est vide !");
            }

        }
        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Produit formajout = new Form_Ajouter_Produit( this);
            formajout.Show();

        }  
        private void handel_AfterCloseForm(object sender, EventArgs e)
        {
            labelBasket.Text  = flowLayoutPagnierProduitVentes.Controls.Count + "";
            nbProduitInBasket = flowLayoutPagnierProduitVentes.Controls.Count;
        } 
    }
}
