﻿using System;
using System.Windows.Forms;  
using System.Linq; 
namespace Project_ENSAF
{
    public partial class produit_cardUC : UserControl
    {
        public Produit currentProd=new Produit();
        Form1 formParent;
        bool isDeatilleFournisseur = false;
        FormDetailleFournisseur formParent2;

        public produit_cardUC()
        { 
            InitializeComponent(); 
        }
        public produit_cardUC(Produit p,Form1 formParent, int nbProds = 1)
        { 
            
            this.currentProd = p;
            this.formParent = formParent;
            initCompo(p,nbProds); 
        }     
        public produit_cardUC(Produit p,FormDetailleFournisseur formParent, int nbProds = 1)
        {
            this.isDeatilleFournisseur = true;
            this.currentProd = p;
            this.formParent2 = formParent;
            initCompo(p,nbProds); 
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
            DialogResult res= MessageBox.Show("Ce produit sera supprimé définitivement du magazin avec tous les records, voulez vous continuez?", "Supprimer produit?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    var db = new dbContext();
                    var stock2delete = db.Stock_Magazin.Where(st => st.codeProduit.Equals(currentProd.codeProduit)) ;
                    db.Stock_Magazin.RemoveRange(stock2delete);
                    db.SaveChanges();
                    this.Dispose();

                    //Matnsach tziid looog 
                    Form1.SetMessageLog("le produit ");
                    
                    // MessageBox.Show("product deleted"); 
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Error! cant delete product :" + excep.Message);
                }
            }
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            if (isDeatilleFournisseur)
            {
                Form_Ajouter_Produit_Adjust prodDescri = new Form_Ajouter_Produit_Adjust(currentProd, formParent2);
                prodDescri.Show();
            }
            else
            {
                Form_Ajouter_Produit prodDescri = new Form_Ajouter_Produit(currentProd, formParent);
                prodDescri.Show();
            }
        }
        private void btnReadMore_click(object sender, EventArgs e)
        {
            if (isDeatilleFournisseur)
            {
                FormProdDescri prodDescri = new FormProdDescri(currentProd,formParent2);
                prodDescri.Show();
            }
            else
            {
                FormProdDescri prodDescri = new FormProdDescri(currentProd, formParent);
                prodDescri.Show();
            }

        
        }

    }
}
