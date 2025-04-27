using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
namespace SerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {

                    adi = textBox1Ad.Text,
                    soyadi = textBoxTel.Text,
                    dogumTarihi = dateTimePicker1.Value,
                    departman = textBoxDepartman.Text,
                    maas = Convert.ToInt32(textBoxMaas.Text),
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                FileStream filestream = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                using (filestream)
                {
                    xmlSerializer.Serialize(filestream, employee);
                    textBox1Ad.Text = "";
                    textBoxTel.Text = "";
                    textBoxDepartman.Text = "";
                    textBoxMaas.Text = "";
                    MessageBox.Show("Kayýt Baþarýlý");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeserialze_Click(object sender, EventArgs e)
        {
            try
            {
                Employee em = new Employee();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                FileStream filestream = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

                using (filestream)
                {
                    em = (Employee)xmlSerializer.Deserialize(filestream);
                    textBox1Ad.Text = em.adi;
                    textBoxTel.Text = em.soyadi;
                    textBoxDepartman.Text = em.departman;
                    textBoxMaas.Text = em.maas.ToString();
                    dateTimePicker1.Value = em.dogumTarihi;
                    MessageBox.Show("deserilization Baþarýlý");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message.ToString());
            }
        }

        private void btnjsonOlustur_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "apple";
            product.price = 3500;
            product.ExpirationDate = DateTime.Now;

            JsonSerializer jsonserializer = new JsonSerializer();




        }
    }
}
