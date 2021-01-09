using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class FormAcheterProduits : Form
    {

        List<ElementPagnierVentes> listElementPagnier = new List<ElementPagnierVentes>();
        decimal total = 0;

        public FormAcheterProduits()
        {

            InitializeComponent();
        }



        private void FormAcheterProduits_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }

        private void elemntTotalChanged(object sender, EventArgs e)
        {
            this.total = GetTotal();
            labelTFNb.Text = total + "";
        }

        private decimal GetTotal()
        {
            decimal total = 0;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                Control[] a = item.Controls.Find("labelPrixTotal", true);
                Label labelPrix = (Label)a[0];
                total += decimal.Parse(labelPrix.Text);
            }
            return total;
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            Control adedItem = e.Control;
            listElementPagnier.Add((ElementPagnierVentes)adedItem);
            Control[] a = e.Control.Controls.Find("labelPrixTotal", true);
            Label labelPrix = (Label)a[0];
            labelPrix.TextChanged += new System.EventHandler(this.elemntTotalChanged);
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control adedItem = e.Control;
            listElementPagnier.Remove((ElementPagnierVentes)adedItem);
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }

        private void FormAcheterProduits_Load(object sender, EventArgs e)
        {
            this.total = GetTotal();
            labelTFNb.Text = total + "";

        }


    }
}
