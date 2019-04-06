using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Ornek_1
{
    //LINQ (Language Integrated Query - Dile Entegre Edilmiş Sorgu) Nedir?
    
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ Expression
            //YOL 1
            var liste = new int[] { 1, 3, 33, 44, 56, 101 };

            var tekler = from sayi in liste //databasedeki bir objecti sorgular gibi 
                         where sayi % 2 == 1 // her objecti sorgulayabiliriz.
                         select sayi;       //foreach ile oluşan collection içinde dönebiliriz.
                                            //LINQ expression databasedeki veriyi sorgulamak için kullanılabilir
                                            //ama bunun için Lambda expression daha populerdir. 
            foreach (var tekSayi in tekler)
            {
                Console.WriteLine(tekSayi);
            }

            Console.ReadKey();

            //YOL 2
            //var liste = new int[] { 1, 3, 33, 44, 56, 101 };

            //foreach (var item in liste)
            //{
            //    if (item % 2 == 1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadKey();

            //YOL 3
            //var liste = new int[] { 1, 3, 33, 44, 56, 101 };

            //for (int i = 0; i < liste.Length; i++)
            //{
            //    if (liste[i] % 2 == 1)
            //    {
            //        Console.WriteLine(liste[i]);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
