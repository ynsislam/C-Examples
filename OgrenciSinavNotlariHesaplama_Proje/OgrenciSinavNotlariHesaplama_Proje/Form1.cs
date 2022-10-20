using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavNotlariHesaplama_Proje
{
    public partial class OrtalamaHesaplama : Form
    {
        public OrtalamaHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            double sinav1, sinav2, proje, ort;
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text); ;
            ort =(sinav1 + sinav2 + proje) / 3;
            
            listBox1.Items.Add("AD:  "+ad+"  "+soyad+ "  ORTALAMASI :  "+ ort);
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
