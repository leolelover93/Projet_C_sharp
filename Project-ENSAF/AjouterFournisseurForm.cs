using System;
using System.Linq;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class AjouterFournisseurForm : Form
    {
        UC_GestionFournisseur theCaller = new UC_GestionFournisseur();
        Boolean isEditing = false;
        Fournisseur fournisseursToEdit = new Fournisseur();
        public AjouterFournisseurForm(UC_GestionFournisseur theCaller)
        {
            this.theCaller = theCaller;
            InitializeComponent();
        }
        public AjouterFournisseurForm(Fournisseur fournisseursToEdit, UC_GestionFournisseur theCaller)//used to edit fournisseur
        {
            this.fournisseursToEdit = fournisseursToEdit;
            this.theCaller = theCaller;
            initCompo2EditFournisseur(fournisseursToEdit);
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var db = new dbContext();
            if (!isEditing)
            {
                if (tbNom.Text.Length > 0 && tbPrenom.Text.Length > 0 && tbtel.Text.Length > 0 && tbadress.Text.Length > 0)
                {
                    try
                    {
                        Fournisseur f = new Fournisseur()
                        {
                            nomFournisseur = tbNom.Text,
                            prenomFournisseur = tbPrenom.Text,
                            adressFournisseur = tbadress.Text,
                            telFournisseur = tbtel.Text,
                        };
                        db.Fournisseurs.Add(f);
                        db.SaveChanges();
                        Form1.SetMessageLog($"L'ajout d'un nouveau fournisseur {tbNom.Text} {tbPrenom.Text} à la liste des fournisseurs");
                        MessageBox.Show("Fournisseur ajouté!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        theCaller.refrechDataGrid(db.Fournisseurs.ToList());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erreur! fournisseur n'est pas ajouter :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Veuillez remplir tous les champs", "Champs vides!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Fournisseur f2Edit = db.Fournisseurs.Find(fournisseursToEdit.idFournisseur);
                f2Edit.nomFournisseur = tbNom.Text;
                f2Edit.prenomFournisseur = tbPrenom.Text;
                f2Edit.adressFournisseur = tbadress.Text;
                f2Edit.telFournisseur = tbtel.Text;
                db.SaveChanges();
                theCaller.refrechDataGrid(db.Fournisseurs.ToList());
                this.Close();
            }

        }
    }
}
