using System; 
using System.Windows.Forms;
using System.IO; 
using System.Linq;
using System.Drawing;

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
      public Form_Ajouter_Produit_Adjust(FormDetailleFournisseur formParent,int idFournisseur)
        {
            this.isAjouterProd = true;
            this.idFournisseurAajouter = idFournisseur;
            this.formParent2 = formParent;
            InitializeComponent();
            this.Text = "Ajouter Produit";
            this.Titre.Text = "Ajouter Produit";
        }
   
        public Form_Ajouter_Produit_Adjust(Produit p, FormDetailleFournisseur formParent )
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
            MessageBox.Show("stat " + isAjouterProd);
            var db = new dbContext();
            if (isDetailFournisseur)
            {
                Decimal prix_Achat = 0, prix_Vente = 0;
                try
                {
                    prix_Achat = Convert.ToDecimal(tb_Prix_Achat.Text);
                    prix_Vente = Convert.ToDecimal(tb_Prix_Vente.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le prix doit être un nombre decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //item.dateExpiration = dateExpirePick.Value;
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
                throw exc;
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
