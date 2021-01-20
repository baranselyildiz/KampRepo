using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç Kursu";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            // array (Dizi / Liste)

            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4, kurs5 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
        }
    }
}
