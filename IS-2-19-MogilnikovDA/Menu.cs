﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_MogilnikovDA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            newform.ShowDialog();
        }
    }
}
