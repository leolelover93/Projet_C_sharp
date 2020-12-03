using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = GestionProduits.Height;
            checkedLinePanel.Top = GestionProduits.Top;
            //www.youtube.com/watch?v=LJKkJI-gE38
            panel4tyle.SendToBack();
        }
        Button btn;
        produit_cardUC produitUI;
        private void Form1_Load(object sender, EventArgs e)
        {
             for (int i = 0; i < 8; i++)
             {
                /*  btn = new Button();
                  btn.Text = "Button " + i.ToString(); 
                  flowLayoutPanel1.Controls.Add(btn);*/
                /*produitUI = new produit_cardUC();
             this.flowLayoutPanel1.Controls.Add(produitUI);*/


             }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedLinePanel.Height = (sender as Button).Height;
          //  checkedLinePanel.Padding =new Padding(0,100,0,100);
            checkedLinePanel.Top = (sender as Button).Top;

            panel4tyle.Location = new Point(checkedLinePanel.Left+7,checkedLinePanel.Top+1 );

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
     /* var context = new dbContext();
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

    


        private void GestionProduits_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(13, 72, 114);
        }

        private void GestionProduits_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(0, 53, 92);

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }
    }
}
