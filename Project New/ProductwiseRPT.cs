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
    public partial class ProductwiseRPT : Form
    {
        public ProductwiseRPT()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
                dt = db.productwiseRPT();
                dataGridView1.DataSource = dt;
        }
    }
}
