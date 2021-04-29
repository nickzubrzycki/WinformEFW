using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformEFW
{
    public partial class FormEdit : Form
    {
        
        public FormEdit()
        {
            InitializeComponent();

            using ( OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {               

                List<Persoon> personen = ctx.Persoon.ToList();                    
                cbPersonen.ValueMember = "PersoonId";
                cbPersonen.DisplayMember = "Voornaam";
                cbPersonen.DataSource = personen;

            }          
            
            
            
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void cbPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPersonen.DataSource != null)
            {             
                Persoon selected = cbPersonen.SelectedItem as Persoon;
                txtVoornaam.Text = selected.Voornaam.ToString();
                txtAchternaam.Text = selected.Achternaam.ToString();
                numLeeftijd.Value = (int)selected.Leeftijd;                
                
            }
        }

        private void txtVoornaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void numLeeftijd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            using (OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {
                ctx.Persoon.Remove(ctx.Persoon.FirstOrDefault(p => p.PersoonId == (int)cbPersonen.SelectedValue));
                ctx.SaveChanges();
            }
            Close();
        }

        private void btnBewerk_Click(object sender, EventArgs e)
        {
            using (OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {
                ctx.Persoon.FirstOrDefault(p => p.PersoonId == (int)cbPersonen.SelectedValue).Voornaam = txtVoornaam.Text.ToString();
                ctx.Persoon.FirstOrDefault(p => p.PersoonId == (int)cbPersonen.SelectedValue).Achternaam = txtAchternaam.Text.ToString();
                ctx.Persoon.FirstOrDefault(p => p.PersoonId == (int)cbPersonen.SelectedValue).Leeftijd = (int)numLeeftijd.Value;
                ctx.SaveChanges();
            }
            Close();
        }
       
                
        private void btnBewerkBdg_Click(object sender, EventArgs e)
        {
            //using (FormEditBadges formEditBadges = new FormEditBadges())
            //{
            //    if (formEditBadges.ShowDialog() == DialogResult.OK)
            //    {
            //        formEditBadges.Close();
            //    }
            //}

            MessageBox.Show("Under construction");
        }

        private void txtBadges_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
