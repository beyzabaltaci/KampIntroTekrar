using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Manav ürünü";

            Urun urun2 = new Urun();

            urun2.Adi = "Armut";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Manav ürünü";
            

            Urun[] urunler = new Urun[] {urun1, urun2};

           foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
                
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu",10,12);

            Console.ReadLine();
        }
    }
}
