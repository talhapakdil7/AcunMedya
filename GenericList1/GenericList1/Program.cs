using GenericList1;

public class Program1
    {


        public static void Main(string[] args)
        {

            List<Car> arabalar = new List<Car>();


            while (arabalar.Count < 3 || DevamEtmekIsterMi())
            {

                Console.WriteLine("araba model gir");
                string modeladi = Console.ReadLine();
                Console.WriteLine("araba marka gir");
                string markaadi = Console.ReadLine();
                Console.WriteLine("100km de yaktıgı yakıt");
                double benzinHarcamasi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("toplam mesafe");
                double toplamMesafe = Convert.ToDouble(Console.ReadLine());

                Model model = new Model { Id = arabalar.Count + 1, Ad = modeladi, ImageUrl = $"{markaadi.ToLower()}.jpg" };
                Marka marka = new Marka { Id = arabalar.Count + 1, Ad = markaadi, ImageUrl = $"{markaadi.ToLower()}.jpg" };

                Car car = new Car(marka, model, benzinHarcamasi, toplamMesafe);

                arabalar.Add(car);



            }
            Console.WriteLine("Araba Listesi");

            foreach (var i in arabalar)
            {

                Console.WriteLine($"Marka: {i.marka.Ad} Model: {i.model.Ad}100 kmde yaktıgı yakıt: {i.benzinHarcamasi} Yakıt Tüketimi: {i.topYakitTuketim()} Litre ");
            }


        }


        public static bool DevamEtmekIsterMi()
        {

            Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            string cevap = Console.ReadLine().ToUpper();
            return cevap == "E" ? true : false;

        }

    }

