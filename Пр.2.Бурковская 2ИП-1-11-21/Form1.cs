﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр._2.Бурковская_2ИП_1_11_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = 1 + (Math.Sin(x + y) * Math.Sin(x + y));
            double b =Math.Abs(x-((2*y)/1+(x*x)*(y*y)));
            double c = Math.Pow(x, Math.Abs(y));
            double d =(a/b)*c;
            double f = Math.Cos(Math.Atan(1 / z)) * Math.Cos(Math.Atan(1 / z));
            double u = ((a / b) * c) + f;
            textBox4.Text += Environment.NewLine + "Результат U = " + u.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
