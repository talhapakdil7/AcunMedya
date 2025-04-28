using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace JsonOdev11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string dosyaYolu = @"C:\Users\pakdi\Desktop\AcunMedyaAkademi\urunler.json";
                string jsonString;

                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    jsonString = sr.ReadToEnd(); // Tüm dosyayı oku
                }

                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

               listBox1.Items.Clear();



                foreach (var urun in urunler)
                {
                   
                    comboBox1.Items.Add($" urun fiyat:{urun.Fiyat }- {urun.UrunAdi}");
                    listBox1.Items.Add($"{urun.Fiyat}- {urun.UrunAdi}");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
    }
}
