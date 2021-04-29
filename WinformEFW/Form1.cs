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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd())
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    formAdd.Close();
                }
            }
            
            
            
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            using (FormEdit formEdit = new FormEdit())
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    formEdit.Close();
                }
            }
        }

        private void btnAddBadge_Click(object sender, EventArgs e)
        {
            using (FormAddBadge formAddBadge = new FormAddBadge())
            {
                if (formAddBadge.ShowDialog() == DialogResult.OK)
                {
                    formAddBadge.Close();
                }
            }
        }
    }
}
