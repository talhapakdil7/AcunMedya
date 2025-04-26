namespace WinFormAraba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araba Bilgileri:\n" +
                "Marka: " + comboBox1.Text + "\n" +
                "Model: " + comboBox2.Text + "\n" +
                "Renk: " + comboBox3.Text + "\n" +
                "Kapi ayisi: " + comboBox4.Text
                +" \n " +" 100km yakýt " + textBox1.Text + "\n" +   
                "pencere sayisi ", MessageBoxButtons.OK + comboBox6.Text) ;
        }
        Dictionary<string, string[]> arabalar = new Dictionary<string, string[]>
        {

            { "BMW", new string[] { "X5", "M3", "M4" } },
            { "Mercedes", new string[] { "C-Class", "E-Class", "S-Class" }
            },
            { "Audi", new string[] { "A3", "A4", "A6" } },
            { "Toyota", new string[] { "Corolla", "Camry", "RAV4" } },
            {
                "Honda", new string[] { "Civic", "Accord", "CR-V" } }

        };

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form acýldý");
            foreach (string marka in arabalar.Keys)
            {
                comboBox1.Items.Add(marka);

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBox1.SelectedItem.ToString();

            foreach(var model in arabalar[marka])
            {
                comboBox2.Items.Add(model);
            }   
        }
    }

}