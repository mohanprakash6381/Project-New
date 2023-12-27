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
    public partial class modelwiseRPT : Form
    {
        public modelwiseRPT()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.modelwiseRPT();
            dataGridView1.DataSource = dt;
        }
    }
}
