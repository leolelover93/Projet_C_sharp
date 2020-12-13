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
    public partial class Espace_Fournisseur : MetroFramework.Forms.MetroForm
    {
        public Espace_Fournisseur()
        {
            InitializeComponent();
        }

        private void Espace_Fournisseur_Load(object sender, EventArgs e)
        {
            using (dbContext db = new dbContext())
            {
                fournisseurBindingSource.DataSource = db.Fournisseurs.ToList();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fournisseurBindingSource.Add(new Fournisseur() );
            fournisseurBindingSource.MoveLast();
            txtLastName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
            Fournisseur obj = fournisseurBindingSource.Current as Fournisseur;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fournisseurBindingSource.ResetBindings(false);
            Espace_Fournisseur_Load(sender, e);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Est ce que tu es sur de la suppression de cet objet ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (dbContext db = new dbContext())
                {
                    Fournisseur obj = fournisseurBindingSource.Current as Fournisseur;
                    if(obj !=null)
                    {
                        if (db.Entry<Fournisseur>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Fournisseur>().Attach(obj);
                        db.Entry<Fournisseur>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        fournisseurBindingSource.RemoveCurrent();

                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (dbContext db = new dbContext())
            {
                Fournisseur obj = fournisseurBindingSource.Current as Fournisseur;
                if(obj !=null)
                {
                    if (db.Entry<Fournisseur>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Fournisseur>().Attach(obj);
                  
                        db.Entry<Fournisseur>(obj).State = System.Data.Entity.EntityState.Added;
          
                   /*     db.Entry<Fournisseur>(obj).State = System.Data.Entity.EntityState.Modified; */
                    db.SaveChanges();
                    metroGrid1.Refresh();
                    


                }
            }
        }
    }
}
