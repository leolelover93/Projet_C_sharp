using System; 
using System.Windows.Forms; 
using System.Data.SqlClient;
using System.IO;

namespace Project_ENSAF
{
    public partial class Form_Ajouter_Produit : Form
    {
        public Form_Ajouter_Produit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IPJGLMH;Initial Catalog=C:/USERS/ACER/DOWNLOADS/DB-PROJET-CS/PROJET.MDF;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;


        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
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

            connection.Open();
            string sqlQuery = "Insert into Produit1(codeProduit,idFournisseur,libelle,prixAchat,prixVente,dateExpiration,image) VALUES ('" + Code_Produit.Text + "','" + ID_Fournisseur.Text + "','" + Libelle.Text + "','" + Prix_Achat.Text + "','" + Prix_Vente.Text + "','" + Date_Expiration.Text + "',@images)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(N.ToString() + "vous avez ajouter le produit");

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
