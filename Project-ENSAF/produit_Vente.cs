using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class produit_Vente : UserControl
    {
        public produit_Vente(Produit p)
        {
            InitializeComponent(p);
        }
    }
}
