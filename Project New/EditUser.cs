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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Updatedusers(textBox1.Text,textBox2.Text, comboBox1.Text);
            MessageBox.Show(x + "Updated Sucessfully Completed");
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
