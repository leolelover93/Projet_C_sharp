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
    public partial class UC_GestionFournisseur : UserControl
    {
        public UC_GestionFournisseur()
        {
            InitializeComponent();
        }
        public UC_GestionFournisseur(List<Fournisseur> fournisseurs)
        {
            initCompo(fournisseurs);
        }
        private void bAjoutCommande_Click(object sender, EventArgs e)
        {
            AjouterFournisseurForm addFourniForm = new AjouterFournisseurForm(this);
            addFourniForm.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new dbContext();
            if (e.ColumnIndex == 6)//delete fournisseur row
            {
                try
                {
                    Fournisseur fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[e.RowIndex];
                    db.Fournisseurs.Remove(fournisseur);
                    db.SaveChanges();   
                    refrechDataGrid(db.Fournisseurs.ToList());
                    DialogResult res = MessageBox.Show("Fournisseur supprimé!", "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error! " + exc.Message);
                }
            }
            if (e.ColumnIndex == 5 )//edit fournisseur row
            {
                Fournisseur fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[e.RowIndex];
                AjouterFournisseurForm f = new AjouterFournisseurForm(fournisseur,this);
                f.Show();
            }
        }
    }
}
