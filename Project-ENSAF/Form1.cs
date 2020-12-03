using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Project_ENSAF
{
    public partial class Form1 : Form
    {
        Button previousBtn;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;

            //www.youtube.com/watch?v=LJKkJI-gE38
        }
        Button btn;
        produit_cardUC produitUI;
        private void Form1_Load(object sender, EventArgs e)
        {
            previousBtn = BtnGestionProduits;
            BtnGestionProduits.BackColor = Color.FromArgb(13, 72, 114);
            
                /*  btn = new Button();
                  btn.Text = "Button " + i.ToString(); 
                  flowLayoutPanel1.Controls.Add(btn);*/
                var db = new dbContext();

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
            //db.Produits.Find(1);
            produitUI = new produit_cardUC();
                this.flowLayoutPanel1.Controls.Add(produitUI);
 

        }
        private void button1_Click(object sender, EventArgs e)
        {
            previousBtn.BackColor = Color.FromArgb(0, 53, 92);
            previousBtn = (sender as Button);
            checkedLinePanel.Height = (sender as Button).Height;
            checkedLinePanel.Top = (sender as Button).Top;
            (sender as Button).BackColor = Color.FromArgb(13, 72, 114);
            

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
          /*  var context = new dbContext();
                    var four = new Fournisseur()
                   {
                       adressFournisseur = "dede",
                       nomFournisseur = "kdjnez",
                       prenomFournisseur = "hamadi dasswass",
                       telFournisseur = "0202020",


                   };
                   try
                   {
                       context.Fournisseurs.Add(four);
                       context.SaveChanges();
                       MessageBox.Show("success");
                   }
                   catch (Exception err)
                   {
                       MessageBox.Show("error" + err.Message);
                   }     */
        }






        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
