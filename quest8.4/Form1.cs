﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quest8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string answer;

        private void radioButton1_CheckedChanged(object sender, EventArgs e) /// Остаток от деления
        {
            answer = Convert.ToString(Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) /// Степень
        {
            answer = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble( textBox2.Text)));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) /// Конкатенация
        {
            answer = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) /// Деление
        {
            answer = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) /// Выполнить 
        {
            textBox3.Text = answer;
        }
    }
}
