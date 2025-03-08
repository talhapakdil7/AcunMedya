using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
    internal class User
    {

        private string name;


        private string surname;
        private int age;
        public string email;


        public void bilgiGoster()
        {

        }

        public string Name
        {
            get { return name; }

            set { name = value.ToUpper(); }

        }

        public string Surname
        {

            get { return surname; }
            set { surname = value.ToUpper(); }


        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {

                    age = value;

                }
                else
                {

                    Console.WriteLine("gecersiz yas");
                }


            }

        }
            public void BilgiGoster()
        {
            Console.WriteLine("Adi: " + name);
            Console.WriteLine("Soyadi: " + surname);
            Console.WriteLine("Yasi: " + age);
            Console.WriteLine("Email: " + email);
        }


    }
}