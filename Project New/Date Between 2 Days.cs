﻿using System;
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
    public partial class Date_Between_2_Days : Form
    {
        public Date_Between_2_Days()
        {
            InitializeComponent();
        }
        DBcon db = new DBcon();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Date_Between_2_Days();
            dataGridView1.DataSource = dt;
        }

        private void Date_Between_2_Days_Load(object sender, EventArgs e)
        {
            
        }
    }
}
