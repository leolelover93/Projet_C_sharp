using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)//delete fournisseur row
                {
                    var result = MessageBox.Show("la suppression est en cascade .Tous les produits relative a ce fourniseur vont etre supprimer  y compris tous les records.Vous voulez Continuez ? ", "Attention",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (e.RowIndex < 0) return;//avoid header click event exception
                            Fournisseur fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[e.RowIndex];
                            Form1.SetMessageLog($"Suppression de {fournisseur.nomFournisseur} {fournisseur.prenomFournisseur} de la liste des fournisseurs");
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
                    else
                    {
                        return;
                    }

                }
                if (e.ColumnIndex == 5)//edit fournisseur row
                {
                    if (e.RowIndex < 0) return;
                    Fournisseur fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[e.RowIndex];
                    AjouterFournisseurForm f = new AjouterFournisseurForm(fournisseur, this);
                    f.Show();
                }
                if (e.ColumnIndex == 7)//Detaille des produits
                {
                    int idFournisseur = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    FormDetailleFournisseur a = new FormDetailleFournisseur(idFournisseur);
                    a.Show();
                }
            }

        }

        private void UC_GestionFournisseur_Load(object sender, EventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 213, 217);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 151, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void tbSearchFournisseur_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearchFournisseur.Text;
            var db = new dbContext();
            List<Fournisseur> listToRender = db.Fournisseurs.Where(f => f.nomFournisseur.Contains(search) || f.prenomFournisseur.Contains(search)).ToList<Fournisseur>();
            refrechDataGrid(listToRender);
        }
    }
}
