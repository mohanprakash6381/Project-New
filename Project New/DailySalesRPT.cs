using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_New
{
    public partial class DailySalesRPT : Form
    {
        public DailySalesRPT()
        {
            InitializeComponent();
        }
        DBcon db =  new DBcon();
        private void DailySalesRPT_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                dt = db.DailySalesRPT();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
