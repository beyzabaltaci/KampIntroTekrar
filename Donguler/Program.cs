using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici " +
                "yetiştirme kursu", 
                "Programlamaya başlangıç için temel kurs", 
                "java" };




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu");
          

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
                Console.ReadLine();
            }
        }
    }
}
