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
                    case 2:label2.Text = "Þubat";
                    break;
                case 3:label2.Text = "Mart"; 
                    break;
                    case 4:label2.Text = "nisan";
                    break;
                    case 5:label2.Text = "mayýs";
                    break;
                case 6:label2.Text = "Haziran";
                    break;
                case 7:label2.Text = "Temmuz";
                    break;
                case 8:label2.Text = "aðustos";
                    break;
                case 9:label2.Text = "eylül"; 
                    break;
                case 10:label2.Text = "ekim";
                    break;
                case 11:label2.Text = "kasým";
                    break;
                case 12:label2.Text = "aralýk";
                    break;
                default:
                    MessageBox.Show("Bir yýl 12 aydýr,Lütfen Doðru bir ay deðeri giriniz !!");

                    break;
            }
        }
    }
}