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
    public partial class FormAddBadge : Form
    {
        public FormAddBadge()
        {
            InitializeComponent();
        }

        private void btnAddNewBadge_Click(object sender, EventArgs e)
        {
            using (OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {
                ctx.Badges.Add(new Badges()
                {
                    Naam = txtNewBadge.Text
                });
                ctx.SaveChanges();
            }
            Close();
        }
    }
}
