using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");     
                
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
