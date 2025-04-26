namespace form1
{
    public partial class Form1 : Form
    {
        string adiniz = "";
        string soyadiniz = "";
        string gozRengi = "";
        string
            kulak = "";
        string burun = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSoyadiniz_Click(object sender, EventArgs e)
        {

        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            adiniz = textBoxadiniz.Text;
            soyadiniz = textBoxSoyadin.Text;

            sonuC.Text = "Adýnýz: " + adiniz + "\n" +
                "Soyadýnýz: " + soyadiniz + "\n" +
                "Göz Rengi: " + gozRengi + "\n" +
                "Kulak: " + kulak + "\n" +
                "Burun: " + burun;
        }

        private void comboBoxGoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            gozRengi = comboBoxGoz.SelectedItem.ToString();

        }

        private void comboBoxburun_SelectedIndexChanged(object sender, EventArgs e)
        {
            burun = comboBoxburun.SelectedItem.ToString();

        }

        private void comboBoxkulak_SelectedIndexChanged(object sender, EventArgs e)
        {
            kulak= comboBoxkulak.SelectedItem.ToString();
        }
    }
}
