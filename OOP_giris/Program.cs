using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_giris
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç Sınıfı Güncelleme

            //arac a1 = new arac("opel","korsa",2010,56000);
            //a1.alisFiyat = 28000;
            //a1.satisFiyat = 32000;
            //a1.maxIndirimFiyat = 1500;
            ////a1 Fiyat kapsulleme
            //a1.fiyatAta(31000);
            //a1.bilgileriGoruntule();

            #endregion


            //prop yazınca public int get set geliyor
            fruit meyve1 = new fruit();
            meyve1.FruitName = "elma";
            meyve1.MeyveRengi = "kırmızı";
            meyve1.OlusturmaTarihi = DateTime.Now;

             fruit meyve2 = new fruit();
            meyve2.FruitName = "çilek";
            meyve2.MeyveRengi = "pembe";
            meyve2.OlusturmaTarihi = DateTime.Now;

            Console.WriteLine(meyve2.FruitName);
            Console.WriteLine(meyve2.OlusturmaTarihi);
            Console.WriteLine("_____________");
            Console.WriteLine(meyve1.FruitName);
            Console.WriteLine(meyve1.OlusturmaTarihi);
            
            Console.ReadKey();
        }
    }
}
