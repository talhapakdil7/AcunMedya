using ClassLibrary1;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Matematik mt= new   Matematik();

            int s1=  Convert.ToInt32(textBox1.Text); 
            int s2= Convert.ToInt32(textBox2.Text);

            int gelen = mt.topla(s1, s2);
            MessageBox.Show("sonuc"+ gelen);
        }
    }
}
