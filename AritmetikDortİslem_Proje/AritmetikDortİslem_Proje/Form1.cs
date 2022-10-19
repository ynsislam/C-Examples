using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AritmetikDortİslem_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bölüm;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bölüm = sayi1 / sayi2;
            MessageBox.Show("TOPLAM :" + toplam+"\n" + "ÇARPIM:" + carpim +"\n"+ "FARK:" + fark +"\n"+ "BÖLÜM:" + bölüm);
        }
    }
}
