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
    public partial class DelModel : Form
    {
        public DelModel()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }
        private void DelModel_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DeleteModel(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "Model Deleted Sucessfully");
            Loaddata();
        }
    }
}
