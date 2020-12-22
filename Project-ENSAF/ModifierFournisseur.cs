using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class ModifierFournisseur : Form
    {
        Fournisseur f = new Fournisseur();
        public ModifierFournisseur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            textIdFournisseur.Text = textNomFournisseur.Text = textAdresseFournisseur.Text = textPhoneFournisseur.Text =textPrenomFournisseur.Text= "";
            button1.Text = "Modifier";
        }

        private void button1_Click(object sender, EventArgs e)
        { /*
            using (var db = new dbContext())
            {
              
                
                var result = db.Fournisseurs.SingleOrDefault(b => b.idFournisseur == textIdFournisseur.value);
                if (result != null)
                {
                    result.nomFournisseur = textNomFournisseur.Text;
                    result.prenomFournisseur = textPrenomFournisseur.Text;
                    result.adressFournisseur = textAdresseFournisseur.Text;
                    result.telFournisseur = textPhoneFournisseur.Text;
                    db.SaveChanges();
                }
            }
            Clear();
            MessageBox.Show("Modifié avec succès");

        */
        }
    }
}
