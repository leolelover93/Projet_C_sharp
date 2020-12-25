using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class UC_Gestion_Commades : UserControl
    {
        public UC_Gestion_Commades()
        {
            InitializeComponent();
        }

        public UC_Gestion_Commades(List<Commande> commandes)
        {
            initCompo(commandes);

        }

        private void UC_Gestion_Commades_Load(object sender, EventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 213, 217);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 151, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            var queryCommande = db.Commandes.Where(n => n.NCommande.ToString().Contains(searchBar.Text)).ToList();
            refrechDataGrid(queryCommande);
        }

        private void bAjoutCommande_Click(object sender, EventArgs e)
        {

        }
    }
}
