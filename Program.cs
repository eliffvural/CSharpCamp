using System;

namespace CsharpCamp
{

    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 20000;
            double faizOrani = 1.15;
            bool sistemeGirisYapmisMi = false;


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }

            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
            


        }
    }
}