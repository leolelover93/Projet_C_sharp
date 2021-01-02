using System; 
using System.Windows.Forms;
using System.IO; 
using System.Linq;
using System.Drawing;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit : Form
    {
        Form1 formParent;
        string imgLocation = ""; 
        Fournisseur fournisseur = new Fournisseur();
        //byte[] prodImg = null;
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
            initCompo(p);
        } 

     /*   private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                
            }
        }*/

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var db = new dbContext(); 
            Decimal prix_Achat = 0, prix_Vente = 0; 
           /* try
            { 
                prix_Achat = Convert.ToDecimal(tb_Prix_Achat.Text);
                prix_Vente = Convert.ToDecimal(tb_Prix_Vente.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Le prix doit être un nombre decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } */
            if (isNewProd) //creating new product
            { 
                if (    fournisseur.nomFournisseur != null)  {  
                    try
                    {
                        var prod = db.Produits.ToList<Produit>()[comboBox1.SelectedIndex];
                        Stock_Magazin stock = new Stock_Magazin();
                        stock.codeProduit = prod.codeProduit;
                        stock.codeMagazin = 1;
                        stock.dateExpiration = dateExpirePick.Value;
                        stock.quantite = Convert.ToInt32(tbQuantite.Text);
                        db.Stock_Magazin.Add(stock);  
                        db.SaveChanges();
                        MessageBox.Show("Produit ajouté!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                       //refrech flowlayoutpanel1
                        if(formParent.filter==0) formParent.btnViewAll_Click(null, null);
                        else if (formParent.filter == 1) formParent.btnDisponible_Click(null, null);
                        else if (formParent.filter == 2) formParent.btnNonDisponible_Click(null, null);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error! " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                else MessageBox.Show("Veuillez remplir tous les champs demandés", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //editing product
            {        
                 /*   var q = db.Produits.Where(p => p.libelle.Equals(prod2Edit.libelle));
                    foreach (var item in q)
                    {
                        item.idFournisseur = fournisseur.idFournisseur;
                        item.libelle = tbLibelle.Text;
                        item.prixAchat = prix_Achat;
                        item.prixVente = prix_Vente;
                        //item.dateExpiration = dateExpirePick.Value;
                        item.description = tbDescription.Text;
                     //   item.img = prodImg;
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
                    }*/
            }

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {

            var db = new dbContext();
            byte[] buffer = File.ReadAllBytes(@"C:\Users\said.leader\source\repos\Projet Csharp\Project-ENSAF\Resources\sidiAlimg.jpg");
            Produit nv_p = new Produit()
            {
                libelle = "Sidi Ali",
                prixAchat = (decimal)4.5,
                prixVente = 5,
                description = "Eau minirale 2L",
                idFournisseur=29,
                img = buffer,
                dureeValidite_jour=10,
            };
            //db.Produits.Add(nv_p);
            Stock_Magazin ss = new Stock_Magazin()
            {
                codeProduit=154,
                codeMagazin=1,
                dateExpiration=DateTime.Now.AddDays(10),
                quantite=52,
            };
            //db.Stock_Magazin.Add(ss);
            db.SaveChanges();
            foreach (var p in db.Produits)
            {
                comboBox1.Items.Add(p.libelle);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new dbContext();
            int i=comboBox1.SelectedIndex;
            var p = db.Produits.ToList<Produit>()[i];
            tbLibelle.Text = p.libelle;
            tb_Prix_Achat.Text = p.prixAchat.ToString(); 
            tb_Prix_Vente.Text = p.prixVente.ToString();
            tbDescription.Text = p.description;
            Fournisseur fournisseur = db.Fournisseurs.Find(p.idFournisseur);
            comboFornisseur.SelectedItem = fournisseur.prenomFournisseur + " " + fournisseur.nomFournisseur;
            try
            { 
                pictureBox1.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("error! product has no img" + exc.Message);
            }
        }
    }
}
