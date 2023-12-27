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
    public partial class Viewprod : Form
    {
        public Viewprod()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.ViewproductBypid(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Viewproduct();
            dataGridView1.DataSource = dt;
        }

        private void Viewprod_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Viewproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
    }
}
