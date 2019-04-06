using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace Basit_Ornek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> ogrenciler = Class1.OgrencileriGetir();
            //LINQ Expression
            var query = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55
                        orderby ogrenci.Notlar[0] 
                        select ogrenci;

            foreach (var ogrenci in query)
            {
                Console.WriteLine(ogrenci.Adi);
            }

            Console.ReadKey();
            //LAMBDA Expression(LINQ Yöntem Sözdizimi)
            //var query1 = ogrenciler.Where(ogr => ogr.Notlar[0] >= 55).OrderBy(ogr => ogr.Notlar[0]);

            //foreach (var ogrenci1 in query1)
            //{
            //    Console.WriteLine(ogrenci1.Adi);
            //}

            //Console.ReadKey();
            //LINQ Expression(DESC HALİ)
            var queryDESC = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55
                        orderby ogrenci.Notlar[0] descending
                        select ogrenci;

            foreach (var ogrenci2 in queryDESC)
            {
                Console.WriteLine(ogrenci2.Adi);
            }

            Console.ReadKey();

            //LAMBDA Expression(LINQ Yöntem Sözdizimi)(DESC HALİ)
            var queryDESC1 = ogrenciler.Where(ogr => ogr.Notlar[0] >= 55).OrderByDescending(ogr => ogr.Notlar[0]);

            foreach (var ogrenci1 in queryDESC1)
            {
                Console.WriteLine(ogrenci1.Adi);
            }

            Console.ReadKey();
        }
    }
}
