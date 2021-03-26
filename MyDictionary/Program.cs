using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sehirler = new MyDictionary<string>();
            sehirler.Add("Eskişehir");
            Console.WriteLine(sehirler.Count);
            Console.WriteLine("Yeni şehir eklendi!");
            Console.ReadLine();
            
        }
    }
}
