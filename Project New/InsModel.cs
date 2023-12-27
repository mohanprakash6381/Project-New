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
    public partial class InsModel : Form
    {
        public InsModel()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        
        private void InsModel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Viewproduct();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selectedItems = (cb.SelectedItem as DataRowView);

                textBox1.Text = selectedItems["pname"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.InsertModel(int.Parse(textBox2.Text),textBox3.Text,int.Parse(comboBox1.Text),textBox1.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text));
            MessageBox.Show(x + "product Inserted Sucessfully");
        }
        public void Clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
