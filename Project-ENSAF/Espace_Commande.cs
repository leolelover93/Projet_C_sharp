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
    public partial class Espace_Commande : Form
    {
        dbContext db = new dbContext();
        public Espace_Commande()
        {
            InitializeComponent();
        }

        private void commandeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Espace_Commande_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Commandes.ToList();

        }
    }
}
