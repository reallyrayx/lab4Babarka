﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1111_Click(object sender, EventArgs e)
        {
            string name = (textBox11111.Text);

            string name3 = (name.ToLower());
            textBox22222.Text = name3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (textBox12.Text);
         
      
            textBox123.Text = name.ToUpper();

        }
    }
}
