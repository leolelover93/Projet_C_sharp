using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic; 
using System.Windows.Forms.DataVisualization.Charting;
namespace Project_ENSAF
{
    public partial class Form1 : Form
    { 
        Button previousBtn,prvBtnFilter;
        FormPagnierVentes a;
        FormAcheterProduits formAcheterProduits;
        UC_GestionFournisseur uc;
        int nbProduitInBasket = 0;
        UC_Gestion_Commades uc_Commandes;
        FlowLayoutPanel flowLayoutPagnierProduitVentes;
        public List<Produit> produitVentes = new List<Produit>();
        List<Produit> listeProduitsPagnier = new List<Produit>();
        dbContext db=new dbContext();
        public int filter = 0;
        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;

            try
            {
                btnViewAll_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connection a la base de donnees! solutions proposés:\n-Verifier le server de db\n-verifier si la db existe deja\n " + ex.Message);
                this.Close();
            }
        }  


        private void Form1_Load(object sender, EventArgs e)
        { 
            panelGestionVentes.Visible = false; 
            panelGestionVentes.Visible = false;
            panelSM_GV.Visible = false;
            panelCommandes.Visible = false;
            panelGestionProduit.Visible = true;
            prvBtnFilter = btnViewAll;
            btnViewAll.BackColor = Color.FromArgb(72, 152, 207);
            btnViewAll.ForeColor = Color.White;
            previousBtn = BtnGestionProduits;
            BtnGestionProduits.BackColor = Color.FromArgb(13, 72, 114);

            dataGridView1.Visible = dataGridView2.Visible = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 213, 217);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 151, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 213, 217);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 151, 255);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBoxLog,"Log");

            SetMessageLog("Connecté");

            //Automating the delete Log 
            LogForm.automatingDeletingLog();
        }

        public static void SetMessageLog(String msg)
        {
            String filePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            StreamWriter writer = new StreamWriter(filePath, true);
            writer.WriteLine(DateTime.Now + " : "+msg);
            writer.Close();

        }
        private void writeFactureInlog(object sender, EventArgs e)
        {
            var dbase = new dbContext();
            List<Vente_magazin> factures = dbase.Vente_magazin.ToList<Vente_magazin>();
            Vente_magazin venteL = factures[factures.Count - 1];
            if(venteL != null)
            {
                int quantite = int.Parse(venteL.quantiteVendus.Split(' ')[venteL.quantiteVendus.Split(' ').Length - 1]);
                SetMessageLog("Vente de " + quantite + " produit(s) avec un gain de : " + venteL.gain+" Dh");
            }
            
        }
        private Button findAjouterFactureBtn()
        {
            if (a != null)
            {
                Control[] ctrl = a.Controls.Find("panelInfoBottom", true);
                Panel panel = (Panel)ctrl[0];
                Control[] ctrl2 = panel.Controls.Find("buttonSumbitPagnier", true);
                Button btn = (Button)ctrl2[0];
                return btn;
            }
            return null;
        }
        private void refreshFlowLayoutPVente()
        {
            produitVentes.Clear();
            flowLayoutPanelVente.Controls.Clear();
            var dbase = new dbContext();
            var NonExpireStock = dbase.Stock_Magazin
                    .Where(stk => DateTime.Compare(stk.dateExpiration, DateTime.Now) > 0)
                    .GroupBy(st => st.codeProduit, (key, g) => new { grp = g.ToList<Stock_Magazin>() });
            int quantity = 0;
            foreach (var st in NonExpireStock) //fetch non expired products from stock
            {
                Produit p = dbase.Produits.Find(st.grp.FirstOrDefault().codeProduit);
                if (p == null) continue;
                produitVentes.Add(p);
                quantity = st.grp.Sum(stk => stk.quantite);
                if (quantity > 0) this.flowLayoutPanelVente.Controls.Add(new produit_Vente(p, quantity));
                quantity = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (previousBtn == (sender as Button)) return;
            if((sender as Button).Name == "BtnGestionProduits")
            {
                panelGestionVentes.Visible = false;
                panelSM_GV.Visible =false; 
                panelCommandes.Visible = false;
                panelGestionProduit.Visible = true;
                btnViewAll_Click(null, null);

            }
            if ((sender as Button).Name == "BtnGestionVentes")
            {
                refreshFlowLayoutPVente();
                panelGestionProduit.Visible = false;
                panelCommandes.Visible = false;
                panelGestionVentes.Visible = true;
                panelSM_GV.Visible = true;
            

                if (a == null)
                {
                    a = new FormPagnierVentes();
                    flowLayoutPagnierProduitVentes = (FlowLayoutPanel)a.Controls[1];
                    a.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.handel_AfterCloseForm);
                    a.VisibleChanged += new System.EventHandler(this.handel2_AfterCloseForm);
                    Button BtnaffecterFacture = findAjouterFactureBtn();
                    BtnaffecterFacture.Click += new System.EventHandler(this.writeFactureInlog);

                }
            }
            if((sender as Button).Name == "buttonCommandes")
            {
                if(formAcheterProduits == null)
                {
                    formAcheterProduits = new FormAcheterProduits(); 
                }
                panelGestionProduit.Visible = false;
                panelGestionVentes.Visible = false;
                panelSM_GV.Visible = false;
                var db = new dbContext();
                if(this.uc_Commandes == null)
                {
                    this.uc_Commandes = new UC_Gestion_Commades(db.Commandes.ToList<Commande>(), formAcheterProduits);

                }
                panelCommandes.Controls.Clear();
                panelCommandes.Controls.Add(uc_Commandes);
                panelCommandes.Controls[0].Dock = System.Windows.Forms.DockStyle.Fill;
                panelCommandes.Visible = true;
            }
            if((sender as Button).Name == "buttonForunisseur")
            {
                panelGestionProduit.Visible = false;
                panelGestionVentes.Visible = false;
                panelSM_GV.Visible = false;
                var db = new dbContext();
                uc = new UC_GestionFournisseur(db.Fournisseurs.ToList<Fournisseur>());
                panelCommandes.Controls.Clear();
                panelCommandes.Controls.Add(uc);
                panelCommandes.Controls[0].Dock = System.Windows.Forms.DockStyle.Fill;
                panelCommandes.Visible = true;
            }
           
            previousBtn.BackColor = Color.FromArgb(0, 53, 92);
            previousBtn = (sender as Button);
            checkedLinePanel.Height = (sender as Button).Height;
            checkedLinePanel.Top = (sender as Button).Top;
            (sender as Button).BackColor = Color.FromArgb(13, 72, 114);
            
        } 
        private void filter_style_click(object sender, EventArgs e)
        { 
                prvBtnFilter.BackColor = Color.White;
                prvBtnFilter.ForeColor = Color.FromArgb(72, 152, 207);
                prvBtnFilter = (sender as Button);
                prvBtnFilter.BackColor = Color.FromArgb(72, 152, 207);
                prvBtnFilter.ForeColor = Color.White; 
        }   
        private void textBoxSearchProduitVentes_TextChanged(object sender, EventArgs e)
        {
            string produitArech = textBoxSearchProduitVentes.Text;
            Console.WriteLine(produitArech);
            var dbase = new dbContext();
            List<Produit> ToRender = produitVentes.Where(p => p.libelle.ToLower().Contains(produitArech.ToLower())).ToList();
            var NonExpiredStock = dbase.Stock_Magazin
                    .Where(stk => DateTime.Compare(stk.dateExpiration, DateTime.Now) > 0)
                    .ToList<Stock_Magazin>();
            flowLayoutPanelVente.Controls.Clear();
            int quantity = 0;
            foreach (var prd in ToRender)
            {
                quantity = NonExpiredStock.FindAll(s => s.codeProduit.Equals(prd.codeProduit)).Sum(stk => stk.quantite);
                Console.WriteLine("search vente-> produit: " + prd.libelle + "Quanti: " + quantity);
                if (quantity != 0)
                    flowLayoutPanelVente.Controls.Add(new produit_Vente(prd, quantity));
                quantity = 0;
            }
        } 
        private void btnAjouterAuPagnier_Click(object sender, EventArgs e)
        { 
            this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
        }   
        public void btnViewAll_Click(object sender, EventArgs e)
        {
            if (sender !=null) filter_style_click( sender,  e);
            filter = 0; //display all
            var dbase = new dbContext();//fix alot of stuff
            int quantity = 0;
            produitVentes.Clear();
            produitVentes = dbase.Produits.ToList<Produit>();
            flowLayoutPanel1.Controls.Clear(); 
            if (dbase.Produits.Count() > 0)
            {
                foreach (var produit in dbase.Produits)
                {
                    quantity = dbase.Stock_Magazin.ToList<Stock_Magazin>()
                               .FindAll(s => s.codeProduit.Equals(produit.codeProduit))
                               .Sum(stk => stk.quantite);
                    if (quantity > 0)
                        this.flowLayoutPanel1.Controls.Add(new produit_cardUC(produit, this, quantity));
                    quantity = 0;
                }
                
            }
        }
        public void btnDisponible_Click(object sender, EventArgs e)
        { 
            if (sender != null) filter_style_click(sender, e);
            filter = 1; //display non expired products 
            var dbase = new dbContext();
            var NonExpireStock = dbase.Stock_Magazin
                    .Where(stk => DateTime.Compare(stk.dateExpiration, DateTime.Now) > 0)
                    .GroupBy(st => st.codeProduit, (key, g) => new { grp = g.ToList<Stock_Magazin>() });
            int quantity = 0;
            produitVentes.Clear();
            flowLayoutPanel1.Controls.Clear();
            foreach (var st in NonExpireStock) //fetch non expired products from stock
            {
                Produit p = dbase.Produits.Find(st.grp.FirstOrDefault().codeProduit);
                if (p == null) continue;
                produitVentes.Add(p);
                quantity = st.grp.Sum(stk => stk.quantite);
                if (quantity > 0) this.flowLayoutPanel1.Controls.Add(new produit_cardUC(p, this, quantity));
                quantity = 0;
            }
        } 
        private void tbSearch_TextChanged(object sender, EventArgs e)
        { 
            string cle = tbSearch.Text;
            Console.WriteLine("\nCherche: "+cle);
            var dbase = new dbContext();
            var stock=dbase.Stock_Magazin.ToList<Stock_Magazin>();
            switch (filter) //detemine ou on doit chercher
            {
                case 1: //si on est dans btnDisponible_Click()
                    stock = dbase.Stock_Magazin.Where(s=> DateTime.Compare(s.dateExpiration, DateTime.Now) > 0)
                                                    .ToList<Stock_Magazin>();
                        break;
                case 2://si on est dans btnNonDisponible_Click()
                    stock = dbase.Stock_Magazin.Where(s => DateTime.Compare(s.dateExpiration, DateTime.Now) < 0)
                                            .ToList<Stock_Magazin>();
                    break;//si on est dans btnDViewAll_Click()
                default: stock = dbase.Stock_Magazin.ToList<Stock_Magazin>(); break;
            } 
            int quantity = 0;
            flowLayoutPanel1.Controls.Clear();
            foreach (var prod in produitVentes)
            { 
                if (prod.libelle.ToLower().IndexOf(cle.ToLower()) == -1) continue;
                quantity = stock.FindAll(s => s.codeProduit.Equals(prod.codeProduit)).Sum(stk => stk.quantite);
                if (quantity != 0)
                    this.flowLayoutPanel1.Controls.Add(new produit_cardUC(prod,this, quantity));  
            }
        } 
        public void btnNonDisponible_Click(object sender, EventArgs e)
        {
            if (sender != null) filter_style_click(sender, e);
            filter = 2; //display expired products
            var dbase = new dbContext();
            var ExpiredStock = dbase.Stock_Magazin
                    .Where(stk => DateTime.Compare(stk.dateExpiration, DateTime.Now) < 0).ToList<Stock_Magazin>();
            int quantity = 0;
            produitVentes.Clear();
            foreach (var st in ExpiredStock) //fetch expired products from stock
            {
                if (dbase.Produits.Find(st.codeProduit) != null)
                    produitVentes.Add(dbase.Produits.Find(st.codeProduit));
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (var prod in produitVentes)//somme des quantités des stocks de chaque prod
            {
                quantity = ExpiredStock.FindAll(s => s.codeProduit.Equals(prod.codeProduit)).Sum(stk => stk.quantite);
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(prod, this, quantity));
                quantity = 0;
            } 
        }  
        private void btnViderPanger_Click(object sender, EventArgs e)
        {
            labelBasket.Text = "0";
            nbProduitInBasket = 0;
            this.pictureBoxBasket.Image = Properties.Resources.cart;
            this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            flowLayoutPagnierProduitVentes.Controls.Clear();
            Control[] a = flowLayoutPagnierProduitVentes.Parent.Controls[0].Controls.Find("labelTFNb", true);
            Label labelPrixTotal = (Label)a[0];
            labelPrixTotal.Text = "0";
        } 
        private void listBoxItemProduct_TextChanged(object sender, EventArgs e)
        {
           if(listBoxItemProduct.Text != "")
            {
                var dbase = new dbContext();
                this.pictureBoxBasket.Image = Properties.Resources.cart__full;
                Produit p = produitVentes.Where(pa => pa.codeProduit == int.Parse(listBoxItemProduct.Text.Split(' ')[0])).ToList()[0];
                labelBasket.Text = ++nbProduitInBasket + "";
                var stock_produit_tables = dbase.Stock_Magazin.Where(s => s.Produit.libelle == p.libelle).ToList();
                int quantity = 0;
                foreach (var elm in stock_produit_tables)
                {
                    quantity += elm.quantite;
                 }
                 ElementPagnierVentes elmnt = new ElementPagnierVentes();
                elmnt.Title = p.libelle;
                elmnt.MaxQuantite = quantity;
                elmnt.Gain = (p.prixVente - p.prixAchat)* int.Parse(listBoxItemProduct.Text.Split(' ')[1]); 
                elmnt.Id = p.codeProduit;
                elmnt.Icon = p.img != null ? Image.FromStream(new MemoryStream(p.img)) : Properties.Resources.loading_product;
                elmnt.Description = p.description;
                elmnt.Quantite = int.Parse(listBoxItemProduct.Text.Split(' ')[1]);
                elmnt.QuntiteProduit = listBoxItemProduct.Text.Split(' ')[1];
                elmnt.PrixUnit = p.prixVente;
                elmnt.PrixTotal = p.prixVente * int.Parse(listBoxItemProduct.Text.Split(' ')[1]) + "";
                foreach (Control item in flowLayoutPagnierProduitVentes.Controls)
                {
                    ElementPagnierVentes epv = (ElementPagnierVentes)item;
                    if (epv.Id  == elmnt.Id)
                    {
                        epv.Quantite = int.Parse(listBoxItemProduct.Text.Split(' ')[1]);
                        labelBasket.Text = --nbProduitInBasket + "";

                        return;
                    }

                }
                flowLayoutPagnierProduitVentes.Controls.Add(elmnt);
                listBoxItemProduct.Text = "";
                
            }


        }
        private void pictureBoxBasket_Click(object sender, EventArgs e)
        {
            if (Object.Equals(a,null))
            {
                a = new FormPagnierVentes();
                flowLayoutPagnierProduitVentes = (FlowLayoutPanel)a.Controls[0];
            }
            if(!Object.Equals(a, null) && flowLayoutPagnierProduitVentes.Controls.Count > 0)
            {
                a.Show(); 
            }else
            {
                MessageBox.Show("Le pagnier est vide !");
            }

        }
        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
          Form_Ajouter_Produit formajout = new Form_Ajouter_Produit( this);
            formajout.Show();
        }

        private void buttonSM_Ventes_Click(object sender, EventArgs e)
        {
            panelContainerSM_GV_V.Visible = true;
            panelContainerSM_GV_JV.Visible = false; 
            panelCommandes.Visible = false;
        }

        private void buttonSM_JVentes_Click(object sender, EventArgs e)
        {
            panelContainerSM_GV_V.Visible = false;
            panelContainerSM_GV_JV.Visible = true;  
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            var db = new dbContext();
            var ventes_liste = db.Vente_magazin.OrderBy(s => s.dateVente).ToList();
            try
            {
                dateTimePickerD.MinDate = ventes_liste[0].dateVente.Value;
                dateTimePickerD.MaxDate = ventes_liste[ventes_liste.Count - 1].dateVente.Value;
                dateTimePickerE.MinDate = ventes_liste[0].dateVente.Value;
                dateTimePickerE.MaxDate = ventes_liste[ventes_liste.Count - 1].dateVente.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur Connection base donné !","warning",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
              
        }

        private void handel_AfterCloseForm(object sender, EventArgs e)
        {
            labelBasket.Text  = flowLayoutPagnierProduitVentes.Controls.Count + "";
            nbProduitInBasket = flowLayoutPagnierProduitVentes.Controls.Count;
            if(flowLayoutPagnierProduitVentes.Controls.Count == 0)
            {
                this.pictureBoxBasket.Image = Properties.Resources.cart;
                
            }

        }

        private void buttonJournalVentes_Click(object sender, EventArgs e)
         {
            var db = new dbContext();
            if (!checkBoxTableu.Checked && !checkBoxGraphique.Checked && !radioButtonGain.Checked && !radioButtonPerte.Checked)
            {
                checkBoxGraphique.Checked = true;
            }
            labelErrorGraph.Text = "";
            chart1.Series.Clear();
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.AddXY(0,0);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Visible = dataGridView2.Visible = checkBoxTableu.Checked;
            chart1.Visible = chart2.Visible = checkBoxGraphique.Checked;
            //For the responsivness of the dataGridView and the Charts---StartBloc#x1
            if (checkBoxGraphique.Checked)
            {
                if(chart2.Width == panelContainerSM_GV_JV.Width -50)
                {
                    chart1.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                    chart2.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                    chart2.Location = new Point(chart1.Width + chart1.Location.X + 15, chart2.Location.Y);
                }
                if(chart1.Width == panelContainerSM_GV_JV.Width - 50)
                {
                    chart1.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                    chart2.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                    chart1.Location = new Point(20, chart1.Location.Y);
                }
            }
            if (checkBoxTableu.Checked)
            {
                dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);

            }
            if (checkBoxTableu.Checked && !checkBoxGraphique.Checked)
            {
                panelContainerLabelGraphe2.Visible = panelContainerLabelGraphe.Visible = false;
                dataGridView1.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                dataGridView2.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
                dataGridView1.Location = new Point(dataGridView1.Location.X, 132);
                dataGridView2.Location = new Point(dataGridView1.Location.X+dataGridView1.Width+8,132);

            }
            else if(!checkBoxTableu.Checked && checkBoxGraphique.Checked)
            {
                panelContainerLabelGraphe2.Visible = panelContainerLabelGraphe.Visible = true;
                dataGridView1.Location = new Point(chart1.Location.X, chart1.Location.Y + chart1.Height +8);
                dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);
            }


            if (!checkBoxTableu.Checked && !checkBoxGraphique.Checked)
            {
                dataGridView1.Visible = chart1.Visible = panelContainerLabelGraphe2.Visible = radioButtonGain.Checked;
                dataGridView2.Visible = chart2.Visible = panelContainerLabelGraphe.Visible = radioButtonPerte.Checked;
                if (radioButtonGain.Checked)
                {
                    chart1.Width = panelContainerSM_GV_JV.Width - 50;
                    dataGridView1.Width = chart1.Width ;
                    dataGridView1.Location = new Point(dataGridView1.Location.X, chart1.Location.Y + chart1.Height + 8);


                }

                if (radioButtonPerte.Checked)
                {
                    chart2.Width = panelContainerSM_GV_JV.Width - 50;
                    chart2.Location = new Point(20, chart2.Location.Y);
                    dataGridView2.Width = chart2.Width;
                    dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);
                }
            }
            if(checkBoxTableu.Checked && checkBoxGraphique.Checked)
            {
                panelContainerLabelGraphe2.Visible = panelContainerLabelGraphe.Visible = true;
                dataGridView1.Width = chart1.Width;
                dataGridView2.Width = chart2.Width;
                dataGridView1.Location = new Point(chart1.Location.X, chart1.Location.Y + chart1.Height + 8);
                dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);
            }
            //For the responsivness of the dataGridView and the Charts---EndBloc#x1 
            if (dateTimePickerD.Value.Date > dateTimePickerE.Value.Date)
                {
                    DateTime temp = dateTimePickerD.Value.Date;
                    dateTimePickerD.Value = dateTimePickerE.Value.Date;
                     dateTimePickerE.Value = temp; 
                }
            var ventes_liste = db.Vente_magazin.GroupBy(s => s.dateVente);
                int i = 0;
            foreach (var groupItem in ventes_liste)
                {

                    int quantite = 0;
                    decimal? _gain = 0;
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    if (!checkBoxTous.Checked)
                    {
                        if (groupItem.Key.Value.Date >= dateTimePickerD.Value.Date && groupItem.Key.Value.Date <= dateTimePickerE.Value.Date)
                        {
                            row.Cells[2].Value = groupItem.Key.Value.Date.ToString("dd/MM/yyyy");
                            i++;
                        }else 
                        {
                            continue;
                        }
                    }else
                    {
                        row.Cells[2].Value = groupItem.Key.Value.Date.ToString("dd/MM/yyyy");
                        i++;
                    }
                    //---
                System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series2.ChartArea = "ChartArea1";
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                series2.Name = "Series" + i ;
                series2.YValuesPerPoint = 1;
                series2.ToolTip = groupItem.Key.Value.Date.ToString("dd/MM/yyyy");
                chart1.Series.Add(series2);
                Axis axisX = chart1.ChartAreas[0].AxisX;
                axisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                foreach (var venteL in groupItem)
                    {
                    quantite += int.Parse(venteL.quantiteVendus.Split(' ')[venteL.quantiteVendus.Split(' ').Length - 1]);
                    _gain += venteL.gain;
                     }
                    row.Cells[0].Value = quantite;
                    row.Cells[1].Value = _gain;
                    dataGridView1.Rows.Add(row);
                     series2.IsValueShownAsLabel = false;
                    series2.Label = _gain+"/"+quantite ;
                    series2.Points.AddXY(i, _gain);
                    chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    chart1.ChartAreas[0].AxisX.Title = "Quantite Produit vendu";
                    chart1.ChartAreas[0].AxisY.Title = "Gain(dhs)";
                    
            }
            if(chart1.Series.Count == 0)
            {
                MessageBox.Show("Aucaun donné à affciher de"+dateTimePickerD.Value.Date.ToString("dd/MM/yyyy")+"-"+dateTimePickerE.Value.Date.ToString("dd/MM/yyyy"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelErrorGraph.Text = "No Data To show";
            }  
            var ExpiredStock = db.Stock_Magazin
                   .Where(stk => DateTime.Compare(stk.dateExpiration, DateTime.Now) < 0).ToList<Stock_Magazin>();
            produitVentes.Clear();
            foreach (var st in ExpiredStock) //fetch expired products from stock
            {
                if (db.Produits.Find(st.codeProduit) != null)
                    produitVentes.Add(db.Produits.Find(st.codeProduit));
            } 
            int j = 0, totalQNonDispo = 0;
            decimal totalPerte = 0;
            int fix = 1;
            foreach (var item in produitVentes)//somme des quantités de chaque produit expiré
            {
                var countInStock = db.Stock_Magazin.ToList<Stock_Magazin>()
                                    .FindAll(s => s.codeProduit.Equals(item.codeProduit))
                                    .Sum(stk => stk.quantite);
                if (countInStock != 0)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[j].Clone();
                    if (dataGridView2.Columns.Contains(item.libelle))
                    {
                        row.Cells[0].Value = item.libelle + "-" + fix;
                        fix++;
                    }
                    else
                    {
                        row.Cells[0].Value = item.libelle;
                    }
                    totalQNonDispo++;
                    totalPerte += countInStock * item.prixAchat;
                    row.Cells[1].Value = totalQNonDispo;
                    row.Cells[2].Value = countInStock * item.prixAchat;
                    j++;
                        dataGridView2.Rows.Add(row);
                        
                    chart2.Series["Series1"].Points.AddXY(countInStock, countInStock * item.prixAchat);
                }
            }
            chart2.ChartAreas[0].AxisX.Title = "Pertes(dhs)";
            chart2.ChartAreas[0].AxisY.Title = "QuntiteChaqueProduitNonDisponible";
            labelTotalPerte.Text = "Perts Totale :"+ totalPerte + "  Quantité Totale :" + totalQNonDispo + " produits"; 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            chart1.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
            chart2.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
            dataGridView1.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
            dataGridView2.Width = (panelContainerSM_GV_JV.Width / 2) - 50;
            chart2.Location = new Point(chart1.Location.X + chart1.Width + 8, chart2.Location.Y);
            if(checkBoxGraphique.Checked && checkBoxTableu.Checked)
            {
                chart1.Visible = chart2.Visible = true;
                dataGridView1.Width = chart1.Width;
                dataGridView2.Width = chart2.Width;
                dataGridView1.Location = new Point(chart1.Location.X, chart1.Location.Y + chart1.Height +8);
                dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);
            }
         
           if(checkBoxGraphique.Checked == false && checkBoxTableu.Checked)
            {
                dataGridView1.Location = new Point(dataGridView1.Location.X, 132);
                dataGridView2.Location = new Point(dataGridView1.Location.X + dataGridView1.Width + 8, 132);
                
            }

            if (radioButtonGain.Checked)
            {
                chart1.Width = panelContainerSM_GV_JV.Width - 50;
                dataGridView1.Width = chart1.Width ;
                dataGridView1.Location = new Point(dataGridView1.Location.X, chart1.Location.Y + chart1.Height + 8);


            }

            if (radioButtonPerte.Checked)
            {
                chart2.Width = panelContainerSM_GV_JV.Width - 50;
                chart2.Location = new Point(20, chart2.Location.Y);
                dataGridView2.Width = chart2.Width;
                dataGridView2.Location = new Point(chart2.Location.X, chart2.Location.Y + chart2.Height + 8);
            }
        } 
        private void checkBoxGraphique_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Name == "checkBoxTous")
            {
                if((sender as CheckBox).Checked)
                {
                    dateTimePickerD.Enabled = dateTimePickerE.Enabled = false;
                }else
                {
                    dateTimePickerD.Enabled = dateTimePickerE.Enabled = true;

                }
            }
            else
            {
                if ((sender as CheckBox).Checked)
                {
                    radioButtonGain.Checked = radioButtonPerte.Checked = false;
                    radioButtonGain.Enabled = false;
                    radioButtonPerte.Enabled = false;
                }
                else
                {
                    radioButtonGain.Enabled = true;
                    radioButtonPerte.Enabled = true;
                }
            }
        }

        private void radioButtonPerte_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGraphique.Checked = checkBoxTableu.Checked = false;
        }
        private void handel2_AfterCloseForm(object sender, EventArgs e)
        {
            if (a.Visible == false)
            {
                labelBasket.Text = "0";
                nbProduitInBasket = 0;
            }
            if (flowLayoutPagnierProduitVentes.Controls.Count == 0)
            {
                this.pictureBoxBasket.Image = Properties.Resources.cart;
                refreshFlowLayoutPVente();
                flowLayoutPanelVente.Refresh();
            }


        }

        public void LogAll_click(object sender, EventArgs e)
        {
         
            LogForm logform = new LogForm();
            logform.Show();
        }
    }
}
