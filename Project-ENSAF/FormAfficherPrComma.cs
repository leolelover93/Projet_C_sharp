﻿using System.Windows.Forms;

namespace Project_ENSAF
{
    public partial class FormAfficherPrComma : Form
    {
        // List<ElementPagnierVentes> listElementPagnier = new List<ElementPagnierVentes>();
        // decimal total = 0;

        public FormAfficherPrComma()
        {

            InitializeComponent();
        }

        public FormAfficherPrComma(System.Collections.Generic.List<Produit_commande> listProduit)
        {
            InitializeComp(listProduit);

        }


        /*  private void FormPagnierVentes_FormClosing(object sender, FormClosingEventArgs e)
          {
              if (e.CloseReason == CloseReason.UserClosing)
              {
                  e.Cancel = true;
                  this.Hide();

              }
          }*/
    }

}
