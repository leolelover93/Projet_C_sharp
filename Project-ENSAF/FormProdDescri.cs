using System.Linq; 
using System.Windows.Forms; 
using System.Collections.Generic;
using System;
namespace Project_ENSAF
{
    public partial class FormProdDescri : Form
    { 
        Form1 formParent = new Form1(); 
        public FormProdDescri(Produit p,Form1 formParent)
        {
            this.formParent = formParent;
            initCompo(p);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_deleteClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 3)
            {
                DateTime date =DateTime.Parse( dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() );
                try
                {
                    var db = new dbContext();
                    var q = db.Produits.Where(p => p.dateExpiration.Day == date.Day && p.dateExpiration.Month == date.Month && p.dateExpiration.Year == date.Year);
                    Produit pr = q.First<Produit>();
                    db.Produits.Remove(pr);
                    db.SaveChangesAsync();
                    dataGridView1.Rows[e.RowIndex].Visible = false;
                    DialogResult res= MessageBox.Show("Stock supprimé!","Supprimé",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                     MessageBox.Show("Error! "+exc.Message); 
                } 
            }
        }

        private void FormProdDescri_FormClosing(object sender, FormClosingEventArgs e)
        { 
            formParent.btnNonDisponible_Click(null, null);
            formParent.btnDisponible_Click(null, null);
            formParent.btnViewAll_Click(null, null);
        }
    }
}
