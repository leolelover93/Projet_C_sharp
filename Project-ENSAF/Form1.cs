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
        Button previousBtn,prvBtnFilter;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;
            
            //www.youtube.com/watch?v=LJKkJI-gE38
        }
        produit_cardUC produitUI;
        private void Form1_Load(object sender, EventArgs e)
        {
            prvBtnFilter = btnViewALL;
            btnViewALL.BackColor = Color.FromArgb(72, 152, 207);
            btnViewALL.ForeColor = Color.White; 
            previousBtn = BtnGestionProduits;

            BtnGestionProduits.BackColor = Color.FromArgb(13, 72, 114);
            for (int i = 0; i < 50; i++)
             {
              
                produitUI = new produit_cardUC();
                 this.flowLayoutPanel1.Controls.Add(produitUI);

             }

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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
