﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            int par1=Convert.ToInt32(textBox1.Text);
            label1.Text=obj.param_kvad(par1).ToString()+"  "+obj.param_kubi(par1).ToString();

        }
    }
}
