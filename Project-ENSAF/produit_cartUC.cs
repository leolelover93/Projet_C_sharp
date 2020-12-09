using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing; 
using System.Linq;
using System.Collections.Generic;
namespace Project_ENSAF
{
    public partial class produit_cardUC : UserControl
    {
        Produit currentProd=new Produit();
        public produit_cardUC()
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

            InitializeComponent(p,1); 
        }
        public produit_cardUC(Produit p,int nbProds=1)
        { 
            this.currentProd = p; 
            InitializeComponent(p,nbProds); 
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
            //this.fct();
             try
             {
                
                var db = new dbContext();
                var p = db.Produits.Where(prod => prod.libelle == currentProd.libelle);
                db.Produits.RemoveRange(p);
                db.SaveChanges();
                this.Dispose();
               // MessageBox.Show("product deleted");

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

                byte[] buffer = (byte[])new ImageConverter().ConvertTo(Properties.Resources.sweets, typeof(byte[]));
                Produit p = new Produit()
                {
                    libelle = "Crème",
                    dateExpiration = DateTime.Parse("12-31-2020"),
                    prixAchat = (decimal)3,
                    prixVente = (decimal)24.5,
                    description = "creme chocolat",
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
        private void btnReadMore_click(object sender, EventArgs e)
        {
            var db = new dbContext();
            var stock = db.Produits.Where(p => p.libelle == currentProd.libelle).ToList<Produit>(); 
           
            FormProdDescri prodDescri = new FormProdDescri(stock);
            prodDescri.Show();
        }

    }
}
