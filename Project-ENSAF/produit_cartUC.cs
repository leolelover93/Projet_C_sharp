using System;
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
                Produit p = db.Produits.Find(currentProd.codeProduit);
                db.Produits.Remove(p); 
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

                byte[] buffer = (byte[])new ImageConverter().ConvertTo(Properties.Resources.sidiAlimg, typeof(byte[]));
                Produit p = new Produit()
                {
                    libelle = "Sidi Ali 2L",
                    dateExpiration = DateTime.Parse("12-05-2020"),
                    prixAchat = (decimal)3,
                    prixVente = (decimal)4.5,
                    description = "Eau minirale Sidi Ali 2L",
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


        }

    }
}
