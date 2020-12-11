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
        byte[] prodImg = null;
        bool isNewProd = true;
        Produit prod2Edit;
        public Form_Ajouter_Produit( Form1 formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }
        public Form_Ajouter_Produit(Produit p, Form1 formParent)
        {
            prod2Edit = p;
            this.formParent = formParent;
            InitializeComponent(p);
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
            if (isNewProd)
            {
                    try
                    {
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        prodImg = brs.ReadBytes((int)stream.Length);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error! please choose a valid image : " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                    if (tbLibelle.Text.Length > 1 && tbDescription.Text.Length > 1 && tb_Prix_Achat.Text.Length > 0 && tb_Prix_Vente.Text.Length > 0 && prodImg != null && fournisseur.nomFournisseur != null)
                    {
                        if (false /*db.Produits.Where(p => p.libelle.Equals(tbLibelle.Text)).Count() > 0*/)
                        {
                            MessageBox.Show("Produit existe déja!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }else {
                                Produit p = new Produit()
                                {
                                    idFournisseur = fournisseur.idFournisseur,
                                    libelle = tbLibelle.Text,

                                    prixAchat = prix_Achat,
                                    prixVente = prix_Vente,
                                    dateExpiration = dateExpirePick.Value,
                                    description = tbDescription.Text,
                                    img = prodImg,
                                };
                                try
                                { 
                                    db.Produits.Add(p);
                                    db.SaveChanges();
                                    var pr = db.Produits.Where(prod => prod.libelle.Equals(p.libelle)).FirstOrDefault<Produit>();
                                    var ss= db.Stock_Magazin.Where(st => st.codeProduit.Equals(pr.codeProduit)).FirstOrDefault<Stock_Magazin>();
                                    if (db.Stock_Magazin.Where(st => st.codeProduit.Equals(pr.codeProduit)).Count() > 0)
                                    {  
                                        ss.quantite += Convert.ToInt32(tbQuantite.Text);
                                    }else { 
                                        Stock_Magazin stock = new Stock_Magazin();
                                        stock.codeProduit = p.codeProduit;
                                        stock.codeMagazin = 1;
                                        stock.quantite = Convert.ToInt32(tbQuantite.Text);
                                        db.Stock_Magazin.Add(stock);
                                    }
                                    db.SaveChanges();
                                    MessageBox.Show("Produit crée avec succès!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    formParent.btnViewAll_Click(null, null);  
                                }
                                catch (Exception exc)
                                {
                                    MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                        } 
                    }
                    else MessageBox.Show("Veuillez remplir tous les champs demandés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {        
                    var q = db.Produits.Where(p => p.libelle.Equals(prod2Edit.libelle));
                    foreach (var item in q)
                    {
                        item.idFournisseur = fournisseur.idFournisseur;
                        item.libelle = tbLibelle.Text;
                        item.prixAchat = prix_Achat;
                        item.prixVente = prix_Vente;
                        //item.dateExpiration = dateExpirePick.Value;
                        item.description = tbDescription.Text;
                        item.img = prodImg;
                    } 
                    try
                    {  
                        db.SaveChanges();
                    //MessageBox.Show("Produit crée avec succès!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        formParent.btnNonDisponible_Click(null, null);
                        formParent.btnDisponible_Click(null, null);
                        formParent.btnViewAll_Click(null, null); 
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
