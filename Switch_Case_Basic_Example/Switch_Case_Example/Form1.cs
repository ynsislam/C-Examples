namespace Switch_Case_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(textBox1.Text);
            switch (ay)
            {
                case 1:label2.Text = "Ocak";
                    break;
                    case 2:label2.Text = "�ubat";
                    break;
                case 3:label2.Text = "Mart"; 
                    break;
                    case 4:label2.Text = "nisan";
                    break;
                    case 5:label2.Text = "may�s";
                    break;
                case 6:label2.Text = "Haziran";
                    break;
                case 7:label2.Text = "Temmuz";
                    break;
                case 8:label2.Text = "a�ustos";
                    break;
                case 9:label2.Text = "eyl�l"; 
                    break;
                case 10:label2.Text = "ekim";
                    break;
                case 11:label2.Text = "kas�m";
                    break;
                case 12:label2.Text = "aral�k";
                    break;
                default:
                    MessageBox.Show("Bir y�l 12 ayd�r,L�tfen Do�ru bir ay de�eri giriniz !!");

                    break;
            }
        }
    }
}