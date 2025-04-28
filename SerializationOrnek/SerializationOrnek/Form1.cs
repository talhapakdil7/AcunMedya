using System.Xml.Serialization;
using Newtonsoft.Json;
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

            try
            {




                Product product = new Product
                {
                    Name = "apple",
                    ExpirationDate = DateTime.Now,
                    price = 3500
                };



                JsonSerializer jsonserializer = new JsonSerializer();
                using (StreamWriter st = new StreamWriter(@"C:\Users\pakdi\Desktop\AcunMedyaAkademi\product.json"))

                {

                }
                using (JsonWriter jsonWriter = new JsonTextWriter(st))
                {

                     jsonserializer.Serialize(jsonWriter, product);
                    MessageBox.Show("seeri tamam");


                }
            }
            catch (Exception ex) {
            
            
            }





        }
    }
}
