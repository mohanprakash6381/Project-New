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
    public partial class InsUser : Form
    {
        public InsUser()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Insertusers(textBox1.Text, textBox2.Text, comboBox1.Text);
            MessageBox.Show("User Inserted Sucessfully");
        }
    }
}
