using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
namespace Project_ENSAF
{
    public partial class Form1 : Form
    {
        Button previousBtn,prvBtnFilter;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;
            produit_cardUC produitUI;
            var db = new dbContext();
            Produit p = db.Produits.Find(4);
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
     
            
            var db = new dbContext();
            byte[] buffer = File.ReadAllBytes(@"C:\Users\TokenPc\source\repos\Project-ENSAF\Project-ENSAF\Project-ENSAF\asset\icon\shipping.png");
            Produit p = new Produit()
            {
                libelle = "danone2",
                dateExpiration = DateTime.Now,
                prixAchat = (decimal)1,
                prixVente = (decimal)2,
                description = "danone banane",
                idFournisseur = 1,
                img = buffer
            };

            //db.Produits.Find(1);
            produitUI = new produit_cardUC(p);
/*            p.libelle = "refresh";
            produitUI = new produit_cardUC(p);*/

          //  this.flowLayoutPanel1.Controls.Add(prodVent);
 
       /*  for (int i = 0; i < 50; i++)
             {
              
                produitUI = new produit_cardUC();
                this.flowLayoutPanel1.Controls.Add(produitUI);

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


        private void button3_Click(object sender, EventArgs e)
        {
             
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
