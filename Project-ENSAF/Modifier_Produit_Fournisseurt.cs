using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit_Adjust : Form
    {
        FormDetailleFournisseur formParent2;
        string imgLocation = "";
        bool isDetailFournisseur = false;
        bool isAjouterProd = true;
        int idFournisseurAajouter;
        Produit prod2Edit;
        public Form_Ajouter_Produit_Adjust(FormDetailleFournisseur formParent, int idFournisseur)
        {
            this.isAjouterProd = true;
            this.idFournisseurAajouter = idFournisseur;
            this.formParent2 = formParent;
            InitializeComponent();
            this.Text = "Ajouter Produit";
            this.Titre.Text = "Ajouter Produit";
        }

        public Form_Ajouter_Produit_Adjust(Produit p, FormDetailleFournisseur formParent)
        {
            this.isAjouterProd = false;
            this.isDetailFournisseur = true;
            this.prod2Edit = p;
            this.formParent2 = formParent;
            initCompo(p);
            this.Text = "Modfier Produit";
            this.Titre.Text = "Modfier Produit";
        }
        private void Parcourir_Click(object sender, EventArgs e)
        {
            if (isDetailFournisseur)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imgLocation;
                }
            }
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            var db = new dbContext();
            if (tb_Prix_Achat.Text == "" || tb_Prix_Vente.Text == "" || tbLibelle.Text == "" || tbDescription.Text == "")
            {
                MessageBox.Show("Remplire tous les chapms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isDetailFournisseur)
            {
                Decimal prix_Achat, prix_Vente;
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


                try
                {
                    Produit prod = db.Produits.Where(p => p.codeProduit == this.prod2Edit.codeProduit).FirstOrDefault<Produit>();
                    if (prod != null)
                    {
                        prod.idFournisseur = prod.Fournisseur.idFournisseur;
                        prod.libelle = tbLibelle.Text;
                        prod.prixAchat = prix_Achat;
                        prod.prixVente = prix_Vente;
                        prod.description = tbDescription.Text;
                        prod.img = (byte[])(new ImageConverter()).ConvertTo(pictureBox1.Image, typeof(byte[]));
                    }
                    else
                    {
                        MessageBox.Show("Opération Non effectuer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    db.SaveChanges();
                    formParent2.remplireLayout(db);
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {

        }

        private void comboFornisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
