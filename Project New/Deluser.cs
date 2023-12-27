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
    public partial class Deluser : Form
    {
        public Deluser()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.Viewusers();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DeleteUsers(comboBox1.Text);
            MessageBox.Show(x + "Users Deleted Sucessfully");
            Loaddata();
        }

        private void Deluser_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
