﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = Convert.ToString(a + b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = Convert.ToString(a - b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            label1.Text = Convert.ToString(Math.Cos(a));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = Convert.ToString(a / b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            label1.Text = Convert.ToString(a * b);
        }
    }
}
