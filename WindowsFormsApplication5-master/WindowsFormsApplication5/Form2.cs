﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2(string opt1,string opt2,string opt3,string opt4)
        {
            InitializeComponent();
            label1.Text = opt1;
            label2.Text = opt2;
            label3.Text = opt3;
            label4 .Text = opt4;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
