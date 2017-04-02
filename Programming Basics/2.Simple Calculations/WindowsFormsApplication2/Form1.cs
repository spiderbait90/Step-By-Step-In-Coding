﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }
        private void ConvertCurrency()
        {
            var amountBGN = this.numericUpDown1.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.label1.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + " EUR";
        }
    }
}
