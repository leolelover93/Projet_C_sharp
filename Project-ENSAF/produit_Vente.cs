using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ENSAF
{

    public partial class produit_Vente : UserControl
    {
        private int idProduit;
        private int quntite;
        private bool DansPanelCommande;
        private bool isSelected = false;
        FlowLayoutPanel formPagnierVentes;





        public int Quantite
        {
            get { return quntite; }
            set { quntite = value; }
        }

        

        public  bool  IsSelcted
        {
            get { return isSelected; }
            set { isSelected = value;
                if (isSelected)
                {
                    this.btnReadMore.FlatAppearance.BorderSize = 2;
                }
                else
                {
                    this.btnReadMore.FlatAppearance.BorderSize = 0;
                }
            }
        }


        public int IdProduit
        {
            get { return idProduit; }
            set { idProduit = value; }
        }

        public produit_Vente()
        {
            InitializeComponent();
        }
        public produit_Vente(Produit p,FlowLayoutPanel flowLayout=null)
        {

            this.IdProduit = p.codeProduit; 
            InitializeComp2(p);
        }
        public produit_Vente(Produit p,int quantite,bool test=false, FlowLayoutPanel formPagnierVentes = null)
        {
          
            this.formPagnierVentes = formPagnierVentes;
            this.formPagnierVentes.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.setSelectionOption);
            this.DansPanelCommande = test;
            this.idProduit = p.codeProduit;
            this.Quantite = quantite;
            InitializeComp(p,quantite,test);
        }


        public void getTheControl()
        {
            //  this.prodImg.Image = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
        }
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if(this.Quantite > 0 && !this.DansPanelCommande)
            {
                this.IsSelcted = true;
                Control[] tabElment = this.Parent.Parent.Parent.Controls.Find("listBoxItemProduct", true);
                Label label = (Label)tabElment[0];
                //Just to fire the event of the hidden text in form1
                if (label.Text == (this.idProduit.ToString() + " " + numericUpDownQauntite.Value)) label.Text = "";
                label.Text = (this.idProduit.ToString() + " " + numericUpDownQauntite.Value);
                
            }else
            {
                this.IsSelcted = true;
                Control[] tabElment = this.Parent.Parent.Controls.Find("labelHiden", true);
                Label label = (Label)tabElment[0];
                if (label.Text == (this.idProduit.ToString() + " " + numericUpDownQauntite.Value)) label.Text = "";
                label.Text = (this.idProduit.ToString() + " " + numericUpDownQauntite.Value);
            }


        }

      
      
        private void setSelectionOption(object sender, ControlEventArgs e)
        {
            Control control = e.Control;
            int id = (control as ElementPagnierVentes).Id;
            if (this.idProduit == id)
            {
                this.IsSelcted = false;
            }
        }

     



    }
}
