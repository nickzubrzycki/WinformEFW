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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

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

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            using (OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {
                ctx.Persoon.Add(new Persoon()
                {
                    Voornaam = txtVoornaam.Text,
                    Achternaam = txtAchternaam.Text,
                    Leeftijd = (int)numLeeftijd.Value
                });
                ctx.SaveChanges();
            }
            Close();
            
        }
    }
}
