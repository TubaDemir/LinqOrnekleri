using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;
namespace Basit_Ornek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> Ogrenciler = Class1.OgrencileriGetir();
            //LINQ Expression
            var ogrenciGruplari = from ogr in Ogrenciler
                                  where ogr.Yasi > 30
                                  group ogr by ogr.Soyadi[0] into

                                  basHarfGrubu

                                  where basHarfGrubu.Count() > 1
                                  orderby basHarfGrubu.Key
                                  select basHarfGrubu;
            //-------------------------------------------------------------------------------------
            //LINQ Expression için ilk foreach denemesi
            //foreach (var ogrenci in ogrenciGruplari)
            //{
            //    Console.WriteLine(ogrenci);
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------------------------------
            //LAMBDA Expression
            //var ogrenciGruplari1 = Ogrenciler.Where(ogr => ogr.Yasi > 30).GroupBy(ogr => ogr.Soyadi[0]).Where(basHarfGrubu => basHarfGrubu.Count() > 1).OrderBy(basHarfGrubu => basHarfGrubu.Key);


            //foreach (var ogrenci1 in ogrenciGruplari1)
            //{
            //    Console.WriteLine(ogrenci1);
            //}

            //Console.ReadKey();
            //-----------------------------------------------------------------------------------------
            foreach (var ogrenciGrubu in ogrenciGruplari) //Farklı bir foreach denemesi
            {
                Console.WriteLine(ogrenciGrubu.Key);
                foreach (var ogr in ogrenciGrubu)
                {
                    Console.WriteLine("{0}, {1}, {2}", ogr.Soyadi, ogr.Adi, ogr.Yasi);
                }
            }
            Console.ReadKey();
        }
    }
}
