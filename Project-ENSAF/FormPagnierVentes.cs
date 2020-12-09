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
    public partial class FormPagnierVentes : Form
    {

        List<ElementPagnierVentes> listElementPagnier = new List<ElementPagnierVentes>();
        public FormPagnierVentes()
        {
            InitializeComponent();
        }




        private void FormPagnierVentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                
            }
        }


        private void elemntTotalChanged(object sender, EventArgs e)
        {
           
            labelTFNb.Text = GetTotal() + "";
        }

        private decimal GetTotal()
        {
            decimal total = 0; 
            foreach(Control item in flowLayoutPanel1.Controls)
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
            Label  labelPrix = (Label)a[0];
            labelPrix.TextChanged += new System.EventHandler(this.elemntTotalChanged);
            labelTFNb.Text = GetTotal() + "";

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control adedItem = e.Control;
            listElementPagnier.Remove((ElementPagnierVentes)adedItem);
            labelTFNb.Text = GetTotal() + "";

        }

        private void FormPagnierVentes_Load(object sender, EventArgs e)
        {
            labelTFNb.Text = GetTotal() + "";

        }
    }
}
