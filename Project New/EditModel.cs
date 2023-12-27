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
    public partial class EditModel : Form
    {
        public EditModel()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        public void loadmodel()
        {
            DataTable dt = new DataTable();
            dt = db.ViewModel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";

        }
        private void EditModel_Load(object sender, EventArgs e)
        {
            loadmodel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var selectedItems = (cb.SelectedItem as DataRowView);

                textBox1.Text = selectedItems["mname"].ToString();
                textBox2.Text = selectedItems["pid"].ToString();
                textBox3.Text = selectedItems["pname"].ToString();
                textBox4.Text = selectedItems["spec"].ToString();
                textBox5.Text = selectedItems["uprice"].ToString();
                textBox6.Text = selectedItems["soh"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.UpdatedModel(int.Parse(comboBox1.Text), textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(x + "Model Updated Sucessfully");
        }
    }
}
