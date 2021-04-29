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
    public partial class FormEditBadges : Form
    {
        public FormEditBadges()
        {
            InitializeComponent();

            using (OefeningEFWEntities1 ctx = new OefeningEFWEntities1())
            {
                List<Badges> badges = ctx.Badges.ToList();
                foreach (Badges item in badges)
                {
                    clbBadges.Items.Add(item.Naam);
                }
                
                
            }

                

        }

        private void clbBadges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
