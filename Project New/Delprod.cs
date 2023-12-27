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
    public partial class Delprod : Form
    {
        public Delprod()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.Viewproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }
        private void Delprod_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Deleteprodct(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "product Deleted Sucessfully");
            Loaddata();
        }
    }
}
