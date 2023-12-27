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
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.CHKLogin(textBox1.Text,textBox2.Text,comboBox1.Text);
            if (x >= 1 ) 
            {
                if (comboBox1.Text =="ADMIN")
                {
                    MDIAdmin m = new MDIAdmin();
                    m.Show();
                }
                else
                {
                    MDIUser u = new MDIUser();
                    u.Show();
                }
            }
            else
            {
                MessageBox.Show("--Invalid UID/PWD--- ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
