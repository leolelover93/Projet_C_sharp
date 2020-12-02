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
        //www.youtube.com/watch?v=LJKkJI-gE38
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
                produitUI = new produit_cardUC();
                this.flowLayoutPanel1.Controls.Add(produitUI);


             }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine( "fere");
        }

        private void produit_cardUC1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
