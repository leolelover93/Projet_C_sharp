using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
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
            prvBtnFilter = btnViewALL;
            btnViewALL.BackColor = Color.FromArgb(72, 152, 207);
            btnViewALL.ForeColor = Color.White; 
            previousBtn = BtnGestionProduits;
            BtnGestionProduits.BackColor = Color.FromArgb(13, 72, 114);

           
           // produitUI = new produit_cardUC(p);
/*            p.libelle = "refresh";
            produitUI = new produit_cardUC(p);*/

           // this.flowLayoutPanel1.Controls.Add(produitUI);
 
       /*  for (int i = 0; i < 50; i++)
             {
              
                produitUI = new produit_cardUC();
                this.flowLayoutPanel1.Controls.Add(produitUI);

            }*/

        }
        private void button1_Click(object sender, EventArgs e)
        {
            previousBtn.BackColor = Color.FromArgb(0, 53, 92);
            previousBtn = (sender as Button);
            checkedLinePanel.Height = (sender as Button).Height;
            checkedLinePanel.Top = (sender as Button).Top;
            (sender as Button).BackColor = Color.FromArgb(13, 72, 114);
            

        }




        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void filter_style_click(object sender, EventArgs e)
        {
            prvBtnFilter.BackColor = Color.White;
            prvBtnFilter.ForeColor = Color.FromArgb(72, 152, 207);
            prvBtnFilter = (sender as Button); 
            prvBtnFilter.BackColor = Color.FromArgb(72, 152, 207);
            prvBtnFilter.ForeColor = Color.White;
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
