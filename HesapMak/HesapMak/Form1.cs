using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Matematik mt = new Matematik();
            int s1= Convert.ToInt16(textBox1.Text);
            int s2= Convert.ToInt16(textBox2.Text); 

          int gelen=  mt.topla(s1,s2);

            MessageBox.Show("toplam"+gelen);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
