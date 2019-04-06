using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Ornek_3
{
    class Program
    {
        class Ogrenci
        {
            public string adi { get; set; }
            public string soyAdi { get; set; }
            public int No { get; set; }
        }

        static void Main(string[] args)
        {
            //YOL 1 Initialization
            //Object Initialization ( aynı anda Instance ve Initialization )
            var ogrenciler = new List<Ogrenci>
            {
                new Ogrenci() {adi = "Ali" , soyAdi = "Ünlü" , No = 112},
                new Ogrenci() {adi = "Veli" , soyAdi = "Yeşil" , No = 116},
                new Ogrenci() {adi = "Selami" , soyAdi = "Sağlam" , No = 132}
            };

            //YOL 2 Initialization
            //List<Ogrenci> ogrenciler = new List<Ogrenci>();
            //Ogrenci ogr = new Ogrenci();
            //ogr.adi = "Ali";
            //ogr.soyAdi = "Ünlü";
            //ogr.No = 112;
            //ogrenciler.Add(ogr);

            //Ogrenci ogr2 = new Ogrenci();
            //ogr.adi = "Veli";
            //ogr.soyAdi = "Yeşil";
            //ogr.No = 116;
            //ogrenciler.Add(ogr);

            //Ogrenci ogr3 = new Ogrenci();
            //ogr.adi = "Selami";
            //ogr.soyAdi = "Sağlam";
            //ogr.No = 132;
            //ogrenciler.Add(ogr);

            //LINQ Expression
            var query = from ogrenci in ogrenciler
                        select ogrenci.soyAdi;

            //LAMBDA Expression
            //var query = ogrenciler.Select(ogr => ogr.soyAdi);

            foreach (var ogrenci_s in query)
            {
                Console.WriteLine(ogrenci_s);
            }
            Console.ReadKey();

        }
    }
}
