using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_giris
{
    class arac
    {
        public string marka;
        public string model;
        public int modelYil;
        public decimal km;
        public int yakıtTipi;
        public int vitesTipi;
        public decimal alisFiyat;
        public decimal satisFiyat;
        public decimal maxIndirimFiyat;
        public decimal fiyat;
        public decimal kilometre;

        public arac(string marka, string model, int modelYil, decimal km, int yakıtTipi, int vitesTipi, decimal alisFiyat, decimal satisFiyat, decimal maxIndirimFiyat, decimal fiyat, decimal kilometre) : this(marka, model, modelYil, km)
        {
            this.yakıtTipi = yakıtTipi;
            this.vitesTipi = vitesTipi;
            this.alisFiyat = alisFiyat;
            this.satisFiyat = satisFiyat;
            this.maxIndirimFiyat = maxIndirimFiyat;
            this.fiyat = fiyat;
            this.kilometre = kilometre;
        }

        public arac()
        {

        }

        public arac(string _marka,string _model)
        {
            marka = _marka;
            model = _model;

        }

        public arac(string _marka, string _model,int _modelYil)
        {

            marka = _marka;
            model = _model;
            modelYil = _modelYil;

        }

        public arac(string _marka, string _model, int _modelYil,decimal _kilometre)
        {

            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            kilometre = _kilometre;
        }

        public void bilgileriGoruntule()
        {
            Console.WriteLine(" marka{0} -model{1} -yıl{2}",marka ,model ,modelYil );
        }
        
        public void fiyatAta(decimal fiyat)
        {
            decimal fiyatHesapla = satisFiyat - maxIndirimFiyat;
            if (fiyat<fiyatHesapla)
            {
                Console.WriteLine("Fiyat geçersiz!");
            }
            else
            {
                this.fiyat = fiyat;
                Console.WriteLine("Fiyat güncellendi..");
            }
        }
    }
}
