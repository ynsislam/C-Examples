﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2_UçakRezervasyonSistemiBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " SAAT :" + maskedTextBox1.Text + "Yolcu Bilgileri~ Ad Soyad : " + textBox1.Text + " TC : " + maskedTextBox2.Text + " TEL : " + maskedTextBox3.Text);
            MessageBox.Show("YOLCU KAYDI BAŞARIYLA YAPILDI.");
        
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;

        }
    }
}
