using System; 
using System.Windows.Forms;
using System.IO; 
using System.Linq;
using System.Drawing;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit_Fournisseur : Form
    {
        FormDetailleFournisseur formParent2;
        string imgLocation = "";
        int idFournisseurAajouter;



        public Form_Ajouter_Produit_Fournisseur(FormDetailleFournisseur formParent, int idFournisseur)
        {
            this.idFournisseurAajouter = idFournisseur;
            this.formParent2 = formParent;
            InitializeComponent();
        }



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
            var db = new dbContext();
            Decimal prix_Achat, prix_Vente;
            if (tb_Prix_Achat.Text == "" || tb_Prix_Vente.Text == "" || tbLibelle.Text == "" || tbDescription.Text == "")
            {
                MessageBox.Show("Remplire tous les chapms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string[] pat = tb_Prix_Achat.Text.Split('.');
                string[] pvt = tb_Prix_Vente.Text.Split('.');
                string pa = tb_Prix_Achat.Text;
                string pv = tb_Prix_Vente.Text;
                if (tb_Prix_Achat.Text.Split('.').Length > 1) pa = pa.Replace(".", ",").Trim();
                if (tb_Prix_Vente.Text.Split('.').Length > 1) pv = pv.Replace(".", ",").Trim();
                prix_Achat = Convert.ToDecimal(pa);
                prix_Vente = Convert.ToDecimal(pv);
            }
            catch (Exception)
            {
                MessageBox.Show("Le prix doit être un nombre decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            int dv = 1;
            try
            {
                dv = Convert.ToInt32(textBoxDV.Text);
              
            }
            catch (Exception)
            {
                MessageBox.Show("Le duréé doit être un nombre un eniter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Produit prod = new Produit();
                if (prod != null)
                {
                    prod.idFournisseur = idFournisseurAajouter;
                    prod.libelle = tbLibelle.Text;
                    prod.prixAchat = prix_Achat;
                    prod.prixVente = prix_Vente;
                    prod.description = tbDescription.Text;
                    prod.dureeValidite_jour = dv;
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        if(pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Save(mStream, pictureBox1.Image.RawFormat);
                            prod.img = mStream.ToArray();
                        }else
                        {
                            prod.img = null;
                        }
                       

                    }
                }
                else
                {
                    MessageBox.Show("Opération Non effectuer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var fournisseur = db.Fournisseurs.Where(f => f.idFournisseur == idFournisseurAajouter).FirstOrDefault();
                Form1.SetMessageLog($"L'ajout d'un nouveau produit '{tbLibelle.Text}' au liste des produits du  fournisseur {fournisseur.nomFournisseur} {fournisseur.prenomFournisseur} ");
                db.Produits.Add(prod);
                db.SaveChanges();
                formParent2.remplireLayout(db);
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw exc;

            }
        }






        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {

          
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }

     
    
}
