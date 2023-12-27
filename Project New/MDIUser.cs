using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_New
{
    public partial class MDIUser : Form
    {
        public MDIUser()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewprod v = new Viewprod();
            v.Show();
        }

        private void viewModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserViewmodel v = new UserViewmodel();
            v.Show();
        }
    }
}
