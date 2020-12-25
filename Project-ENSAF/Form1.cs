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
        FormAcheterProduits b; 
        int nbProduitInBasket = 0; 
        FlowLayoutPanel flowLayoutPagnierProduitVentes;
        public List<Produit> produitVentes = new List<Produit>();
        List<Produit> listeProduitsPagnier = new List<Produit>();
        dbContext db; 

        public Form1()
        {
            InitializeComponent();
            checkedLinePanel.Height = BtnGestionProduits.Height;
            checkedLinePanel.Top = BtnGestionProduits.Top;
            try
            {
                db = new dbContext();
                produitVentes = db.Produits.ToList<Produit>();
                //groupin by libelle
                var query = (from p in db.Produits
                             group p by new { p.libelle, } into grp
                             select new { first = grp.FirstOrDefault() });
                int quantity = 0; 
                if (query.Count()>0)
                {
                    foreach (var elm in query)
                    {
                        foreach (var s in db.Stock_Magazin)
                        {
                            if (db.Produits.Find(s.codeProduit).libelle.Equals(elm.first.libelle)) quantity += s.quantite;
                        }
                        this.flowLayoutPanel1.Controls.Add(new produit_cardUC(elm.first, this, quantity));
                        quantity = 0;
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connection! " + ex.Message);
                this.Close();
            }
            

        }  
        private void Form1_Load(object sender, EventArgs e)
        { 
            panelGestionVentes.Visible = false; 
            panelCommandes.Visible = false;
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text == "Gestion Produits")
            {
                panelGestionVentes.Visible = false;
                panelSM_GV.Visible =false; 
                panelCommandes.Visible = false;
                panelGestionProduit.Visible = true;

            }
            if ((sender as Button).Text == "Gestion Ventes")
            { 
                panelGestionProduit.Visible = false;
                panelCommandes.Visible = false;
                panelGestionVentes.Visible = true;
                panelSM_GV.Visible = true;
                
                var dbase = new dbContext();
                var NonExpireProds = dbase.Produits
                        .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) > 0)
                        .ToList<Produit>();
                var query = (from p in NonExpireProds
                                group p by new { p.libelle, } into grp
                                select new { first = grp.FirstOrDefault(), all = grp.ToList<Produit>() });
                int quantity = 0;
                produitVentes.Clear();
                flowLayoutPanelVente.Controls.Clear();
                foreach (var elm in query)
                {
                    produitVentes.Add(elm.first);
                    foreach (var s in dbase.Stock_Magazin)
                    {
                        if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>() != null)
                        {
                            if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>().libelle.Equals(elm.first.libelle))
                                quantity += s.quantite;
                        }
                    }
                    this.flowLayoutPanelVente.Controls.Add(new produit_Vente(elm.first,quantity));
                    quantity = 0;
                }
                if (a == null)
                {
                    a = new FormPagnierVentes();
                    flowLayoutPagnierProduitVentes = (FlowLayoutPanel)a.Controls[1];
                    a.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.handel_AfterCloseForm);
                    a.VisibleChanged += new System.EventHandler(this.handel2_AfterCloseForm);


                }
            }
            if((sender as Button).Text == "Gestion Commandes")
            {
                if(b == null)
                {
                    b = new FormAcheterProduits(); 
                }
                panelGestionProduit.Visible = false;
                panelGestionVentes.Visible = false;
                panelSM_GV.Visible = false;
                var db = new dbContext();
                UC_Gestion_Commades uc_Commandes = new UC_Gestion_Commades(db.Commandes.ToList<Commande>(),b);
                panelCommandes.Controls.Clear();
                panelCommandes.Controls.Add(uc_Commandes);
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
            List<Produit> ToRender  =  produitVentes.Where(p => p.libelle.ToLower().Contains(produitArech.ToLower())).ToList();
            flowLayoutPanelVente.Controls.Clear();
            foreach(var prd in ToRender)
            {
                flowLayoutPanelVente.Controls.Add(new produit_Vente(prd));  
            }
        } 
        private void btnAjouterAuPagnier_Click(object sender, EventArgs e)
        { 
            this.pictureBoxBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
        }   
        public void btnViewAll_Click(object sender, EventArgs e)
        {
            if (sender !=null) filter_style_click( sender,  e);  
            produitVentes = new List<Produit>();
            var dbase = new dbContext();//fix alot of stuff
            var query = (from p in dbase.Produits
                         group p by new { p.libelle, } into grp
                         select new { first = grp.FirstOrDefault() });
            int quantity = 0;
            flowLayoutPanel1.Controls.Clear();
            foreach (var elm in query)
            {
                produitVentes.Add(elm.first);
                foreach (var s in dbase.Stock_Magazin)
                {
                    if (dbase.Produits.Find(s.codeProduit).libelle.Equals(elm.first.libelle)) quantity += s.quantite;
                }
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(elm.first, this, quantity));
                quantity = 0;
            }
        }
        public void btnDisponible_Click(object sender, EventArgs e)
        { 
            if (sender != null) filter_style_click(sender, e);
            var dbase = new dbContext();
            var NonExpireProds = dbase.Produits
                   .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) > 0)
                   .ToList<Produit>(); 
            var query = (from p in NonExpireProds
                         group p by new { p.libelle, } into grp
                         select new { first = grp.FirstOrDefault(), all = grp.ToList<Produit>() });
            int quantity = 0;
            produitVentes.Clear();
            flowLayoutPanel1.Controls.Clear();
            foreach (var elm in query)
            {
                produitVentes.Add(elm.first);
                foreach (var s in dbase.Stock_Magazin)
                {
                    if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>() != null)
                    {
                        if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>().libelle.Equals(elm.first.libelle))
                            quantity += s.quantite;
                    }
                }
                if(quantity>0)
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(elm.first, this, quantity));
                quantity = 0;
            }

                

        } 
        private void tbSearch_TextChanged(object sender, EventArgs e)
        { 
            string cle = tbSearch.Text;
            Console.WriteLine("\ncle: "+cle);
            var dbase = new dbContext();
            List<Produit> prodTrouves = produitVentes.Where(p => p.libelle.ToLower().IndexOf(cle.ToLower()) !=-1)
                                                   .ToList(); 
            var query = (from p in prodTrouves
                         group p by new { p.libelle, } into grp
                         select new
                         { 
                             first = grp.FirstOrDefault()
                         });
            flowLayoutPanel1.Controls.Clear(); 
            int quantity = 0;
            foreach (var elm in query)
            { 
                foreach (var s in dbase.Stock_Magazin)
                {
                    if (dbase.Produits.Find(s.codeProduit).libelle.Equals(elm.first.libelle)) quantity += s.quantite;
                } 
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(elm.first, this, quantity));
                quantity = 0;
            }
        } 
        public void btnNonDisponible_Click(object sender, EventArgs e)
        {
            if (sender != null) filter_style_click(sender, e);
            var dbase = new dbContext();
            var NonExpireProds = dbase.Produits
                    .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) < 0)
                    .ToList<Produit>();
            var query = (from p in NonExpireProds
                         group p by new { p.libelle, } into grp
                         select new { first = grp.FirstOrDefault(), all=grp.ToList<Produit>() });
            int quantity = 0;
            produitVentes.Clear();
            flowLayoutPanel1.Controls.Clear();
            foreach (var elm in query)
            {
                produitVentes.Add(elm.first);
                foreach (var s in dbase.Stock_Magazin)
                {
                    if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>() != null)
                    {
                        if (elm.all.Where(p => p.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>().libelle.Equals(elm.first.libelle))
                        quantity += s.quantite;  
                    }
                }
                this.flowLayoutPanel1.Controls.Add(new produit_cardUC(elm.first, this, quantity));
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
                this.pictureBoxBasket.Image = Properties.Resources.cart__full;
                Produit p = produitVentes.Where(pa => pa.codeProduit == int.Parse(listBoxItemProduct.Text.Split(' ')[0])).ToList()[0];
                labelBasket.Text = ++nbProduitInBasket + "";
                var dbase = new dbContext();
                var NonExpireProds = dbase.Produits
                        .Where(pa => pa.codeProduit == p.codeProduit)
                        .ToList<Produit>();
                var query = (from paa in NonExpireProds
                             group paa by new { paa.libelle, } into grp
                             select new { first = grp.FirstOrDefault(), all = grp.ToList<Produit>() });
                int quantity = 0;
                foreach (var elm in query)
                {
                    foreach (var s in dbase.Stock_Magazin)
                    {
                        if (elm.all.Where(pb => pb.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>() != null)
                        {
                            if (elm.all.Where(pc => pc.codeProduit.Equals(s.codeProduit)).FirstOrDefault<Produit>().libelle.Equals(elm.first.libelle))
                                quantity += s.quantite;
                        }
                    }
                  
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
                    if (epv.Title == elmnt.Title)
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
        private void buttonSearchGP_Click_1(object sender, EventArgs e)
        {
            string produitArech = textBoxSearchProduitVentes.Text;
            Console.WriteLine(produitArech);
            List<Produit> ToRender = produitVentes.Where(p => p.libelle.Contains(produitArech)).ToList();
            if (ToRender.Count > 0) flowLayoutPanel1.Controls.Clear();
            foreach (var prd in ToRender)
            {
                flowLayoutPanel1.Controls.Add(new produit_Vente(prd));
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
            produitVentes = db.Produits
                .Where(p => DateTime.Compare(p.dateExpiration, DateTime.Now) < 0)
                .ToList<Produit>();
                int j = 0, totalQNonDispo = 0;
                decimal totalPerte = 0;
                int fix = 1;
                foreach (var item in produitVentes)
                {
                    var countInStock = db.Stock_Magazin
                                    .Where(s => s.codeProduit == item.codeProduit)
                                     .Select(p => p.quantite).FirstOrDefault();
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
                       row.Cells[1].Value = countInStock * item.prixAchat;
                        j++;
                         dataGridView2.Rows.Add(row);
                        
                        chart2.Series["Series1"].Points.AddXY(countInStock, countInStock * item.prixAchat);

                    }

                }
                chart2.ChartAreas[0].AxisX.Title = "Pertes(dhs)";
                chart2.ChartAreas[0].AxisY.Title = "QuntiteChaqueProduitNonDisponible";
                labelTotalPerte.Text = "Perts Totale :"+totalPerte + "---" + totalQNonDispo + " produits";
               
           
           

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
                produitVentes.Clear(); 
                flowLayoutPanelVente.Controls.Clear();
                button1_Click(BtnGestionVentes, e);
                flowLayoutPanelVente.Refresh();

            }


        }



    }
}
