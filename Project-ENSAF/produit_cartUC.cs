﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace Project_ENSAF
{
    public partial class produit_cardUC : UserControl
    {
        Produit currentProd=new Produit();
        public produit_cardUC()
        {
            byte[] buffer = File.ReadAllBytes(@"C:\Users\said.leader\source\repos\Project-ENSAF\Project-ENSAF\Project-ENSAF\asset\icon\shipping.png");
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
            InitializeComponent(p); 
        }
        public produit_cardUC(Produit p)
        {
            System.Type a = p.GetType();
            // MessageBox.Show(a.ToString());
            /*  currentProd.codeProduit = p.codeProduit;
              currentProd.idFournisseur = p.idFournisseur;
              currentProd.libelle = p.libelle;
              currentProd.prixAchat = p.prixAchat;
              currentProd.prixVente = p.prixVente;
              currentProd.dateExpiration = p.dateExpiration;
              currentProd.img = p.img;
              currentProd.description = p.description;
             this.lblProdName.Text = p.libelle;*/
            /*  this.Lblprix = p.prixVente.ToString(); 
             this.LblProdDescri = p.description;*/
            //   this.prodImg.Image = Image.FromStream( new MemoryStream(p.img));/**/ 

            InitializeComponent(p);
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
                try
                {

                var db = new dbContext();
                db.Produits.Remove(this.currentProd);
                    db.SaveChanges();
                    MessageBox.Show("product deleted");

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Error! cant delete product :" + excep.Message);
                }
        } 
        private void btnEdit_Click(object sender, EventArgs e)
        { 
            try
            {
                byte[] buffer = File.ReadAllBytes(@"C:\Users\said.leader\source\repos\Project-ENSAF\Project-ENSAF\Project-ENSAF\asset\icon\shipping.png");
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
                db.SaveChanges();

                MessageBox.Show("product insertion successed:");
            }
            catch (Exception exce)
            {
                MessageBox.Show("Error! cant insert product :" + exce.Message);
            }
        }

        private void produit_cardUC_Load(object sender, EventArgs e)
        { 

        }
    }
}
