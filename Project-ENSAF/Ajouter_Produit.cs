using System; 
using System.Windows.Forms; 
using System.Data.SqlClient;
using System.IO;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit : Form
    { 
        string imgLocation = "";
        public Form_Ajouter_Produit()
        {
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
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            var db = new dbContext(); 
           /* Produit p=new Produit()
            {
                idFournisseur= int.Parse(ID_Fournisseur.Text),
                libelle = Libelle.Text,
                dateExpiration= Date_Expiration.Text,

            }
            db.Produits.Add();*/
           /* connection.Open();
            string sqlQuery = "Insert into Produit1(codeProduit,idFournisseur,libelle,prixAchat,prixVente,dateExpiration,image)
                            VALUES ('" + Code_Produit.Text + "','" + ID_Fournisseur.Text + "','" + Libelle.Text + "','" + Prix_Achat.Text + "','" + Prix_Vente.Text + "','" + Date_Expiration.Text + "',@images)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();*/
           // MessageBox.Show(N.ToString() + "vous avez ajouter le produit");

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Ajouter_Produit_Load(object sender, EventArgs e)
        {

        }
    }
}
