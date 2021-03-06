using System;
using System.Linq;
using System.Windows.Forms;
namespace Project_ENSAF
{
    public partial class FormProdDescri : Form
    {
        Form1 formParent = new Form1();
        FormDetailleFournisseur formParrent2;
        Produit currentProd = new Produit();
        bool isDetailleFourn = false;

        public FormProdDescri(Produit p, Form1 formParent)
        {
            this.formParent = formParent;
            this.currentProd = p;
            initCompo(p);
        }
        public FormProdDescri(Produit p, FormDetailleFournisseur formParent2)
        {
            this.isDetailleFourn = true;
            this.formParrent2 = formParent2;
            this.currentProd = p;
            initCompo(p);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex < 0) return;
                try
                {
                    var db = new dbContext();
                    var stock = db.Stock_Magazin.Where(s => s.codeProduit.Equals(currentProd.codeProduit));
                    var stk2delete = stock.ToList<Stock_Magazin>()[e.RowIndex];
                    Form1.SetMessageLog("Suppression du stock N" + stk2delete.codeStock + " du '" + currentProd.libelle + ", Quatite retitré " + stk2delete.quantite + " produit(s) , date d'expiration : " + stk2delete.dateExpiration.ToShortDateString());

                    db.Stock_Magazin.Remove(stk2delete);
                    db.SaveChanges();
                    refreshDatagrid(currentProd);
                    DialogResult res = MessageBox.Show("Stock supprimé!", "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error! " + exc.Message);
                }
            }
        }
        private void FormProdDescri_FormClosing(object sender, FormClosingEventArgs e)
        {
            //refrech flowlayoutpanel1
            if (!isDetailleFourn)
            {
                if (formParent.filter == 0) formParent.btnViewAll_Click(null, null);
                else if (formParent.filter == 1) formParent.btnDisponible_Click(null, null);
                else if (formParent.filter == 2) formParent.btnNonDisponible_Click(null, null);
            }
            else
            {
                var db = new dbContext();
                formParrent2.remplireLayout(db);
            }

        }
    }
}
