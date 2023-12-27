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
    public partial class MDIAdmin : Form
    {
        public MDIAdmin()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insprod i = new Insprod();
            i.Show();
        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editprod ee = new Editprod();
            ee.Show();
        }

        private void dELPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delprod d = new Delprod();
            d.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewprod v = new Viewprod();
            v.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsModel i = new InsModel();
            i.Show();
        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditModel ee = new EditModel();
            ee.Show();
        }

        private void dELMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelModel d = new DelModel();
            d.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel v = new ViewModel();
            v.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsUser i = new InsUser();
            i.Show();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser ee= new EditUser();
            ee.Show();
        }

        private void dELUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deluser d = new Deluser();
            d.Show();
        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewUser v = new viewUser();
            v.Show();
        }

        private void MDIAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dailySalesRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailySalesRPT d = new DailySalesRPT();  
            d.Show();
        }

        private void productWiseRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductwiseRPT p = new ProductwiseRPT();
            p.Show();
        }

        private void modelWiseRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelwiseRPT m = new modelwiseRPT();
            m.Show();
        }

        private void dateBetween2DatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Date_Between_2_Days d = new Date_Between_2_Days();
            d.Show();
        }
    }
}
