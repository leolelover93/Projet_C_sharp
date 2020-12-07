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
        FlowLayoutPanel flowLayout;
        List<Produit> produitVentes = new List<Produit>();
        List<Produit> listeProduitsPagnier = new List<Produit>();
        dbContext db;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;
             db = new dbContext();
            //  Produit p = db.Produits.Find(4);
            foreach (var produit in db.Produits)
            {
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(produit));
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
                a = new FormPagnierVentes();
                flowLayout = (FlowLayoutPanel)a.Controls[0];



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
            Console.WriteLine(produitArech);
            List<Produit> ToRender  =  produitVentes.Where(p => p.libelle.Contains(produitArech)).ToList();
            if (ToRender.Count > 0) flowLayoutPanelVente.Controls.Clear();
            foreach(var prd in ToRender)
            {
                flowLayoutPanelVente.Controls.Add(new produit_Vente(prd));  
            }
        }
       
        private void btnAjouterAuPagnier_Click(object sender, EventArgs e)
        {
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        }

        private void listBoxItemProduct_DataSourceChanged(object sender, EventArgs e)
        {


        }


        private void btnViderPanger_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void listBoxItemProduct_Resize(object sender, EventArgs e)
        {
            
            
     

        }

        private void listBoxItemProduct_TextChanged(object sender, EventArgs e)
        {
            listeProduitsPagnier.Add(produitVentes.Where(pa => pa.codeProduit == int.Parse(listBoxItemProduct.Text)).ToList()[0]);

            Produit p = listeProduitsPagnier[listeProduitsPagnier.Count - 1];
                ElementPagnierVentes elmnt = new ElementPagnierVentes();
                elmnt.Title = p.libelle;
                elmnt.Icon = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
                elmnt.Description = p.description;
                elmnt.QuntiteProduit = "56";
                elmnt.PrixUnit = p.prixVente.ToString() + "DH";
                elmnt.PrixTotal = "2121";
                flowLayout.Controls.Add(elmnt);
                Console.WriteLine("titre produit : " + p.libelle);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a.Show(); 
        }

      

    
    }
}
