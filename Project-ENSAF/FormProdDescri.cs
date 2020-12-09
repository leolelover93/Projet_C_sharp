using System; 
using System.Windows.Forms; 
using System.Collections.Generic; 

namespace Project_ENSAF
{
    public partial class FormProdDescri : Form
    {
      /*  public FormProdDescri( )
        {
            InitializeComponent();
        }*/
        
        public FormProdDescri(List<Produit> stock)
        {
            InitializeComponent(stock);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
