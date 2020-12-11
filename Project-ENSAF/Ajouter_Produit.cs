using System; 
using System.Windows.Forms; 
using System.Data.SqlClient;
using System.IO; 
using System.Linq;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit : Form
    {
        Form1 formParent;
        string imgLocation = ""; 
        Fournisseur fournisseur = new Fournisseur();
        public Form_Ajouter_Produit( Form1 formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }
        /*public Form_Ajouter_Produit(string s)
        {
            InitializeComponent(s);
        } */

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            try
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! please choose a valid image : " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            var db = new dbContext();
            if (tbLibelle.Text.Length > 1 && tbDescription.Text.Length > 1 && tb_Prix_Achat.Text.Length > 0 && tb_Prix_Vente.Text.Length > 0 && image != null&& fournisseur.nomFournisseur!=null)
            {
                Produit p = new Produit()
                {
                    idFournisseur = fournisseur.idFournisseur,
                    libelle = tbLibelle.Text,
                    prixAchat = Convert.ToDecimal(tb_Prix_Achat.Text),
                    prixVente = Convert.ToDecimal(tb_Prix_Vente.Text),
                    dateExpiration = dateExpirePick.Value,
                    description = tbDescription.Text,
                    img = image,
                };
                try
                { 
                    db.Produits.Add(p);
                    db.SaveChanges(); 
                    MessageBox.Show("Produit crée avec succès!" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Close();
                    formParent.btnViewAll_Click(null, null);
                }
                catch (Exception exc)
                { 
                    MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("Veuillez remplir tous les champs demandés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {
            var db = new dbContext();
            foreach (var item in db.Fournisseurs)
            {
                this.comboFornisseur.Items.Add(item.prenomFournisseur + " " + item.nomFournisseur);
            }
        }

        private void comboFornisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new dbContext();
            fournisseur = db.Fournisseurs.ToArray<Fournisseur>()[comboFornisseur.SelectedIndex];
        }
    }
}
