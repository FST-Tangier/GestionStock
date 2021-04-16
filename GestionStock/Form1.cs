using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        DCDataContext dc = new DCDataContext();
        double pu;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Afficher();
        }

        private void Afficher()
        {
            grd.DataSource = dc
                .article
                .Where(e => e.Libelle.StartsWith("p"))
                .ToList();

            cmb.DisplayMember = "Libelle";
            cmb.DataSource = dc.article.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            article art = new article();
            art.Libelle = txtLib.Text;
            art.PU = Double.Parse(txtPU.Text);

            dc.article.InsertOnSubmit(art);
            
            dc.SubmitChanges();

            Afficher();

        }

        private void txtPU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pu = Double.Parse(txtPU.Text);
                btnAjouter.Visible = true;
                error.SetError(txtPU, "");
                Text = "";
            }
            catch (Exception ex)
            {
                btnAjouter.Visible = false;
                error.SetError(txtPU, "Prix invalide !");
                Text = ex.Message;
            }
           
        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            grd.DataSource = dc
               .article
               .Where(unArt => unArt.Libelle.StartsWith(txtFiltre.Text.Trim()))
               .ToList();
        }
    }
}
