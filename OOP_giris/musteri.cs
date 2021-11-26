using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_giris
{
    class musteri
    {
        public string tc;
        public string isim;
        public string soyisim;
        public int cinsiyet;


        //yapıcı method constructor
        public musteri(string tc, string isim, string soyisim, int cinsiyet) : this(tc, isim, soyisim)
        {
            this.cinsiyet = cinsiyet;
        }

        public musteri(string tc, string isim, string soyisim) : this(tc, isim)
        {
            this.soyisim = soyisim;
        }

        public musteri(string tc, string isim) : this(tc)
        {
            this.isim = isim;
        }

        public musteri(string tc)
        {
            this.tc = tc;
        }
        public musteri() { }
        

        public bool musteriKontrol()
        {
            bool kontrol = musteriKontrolDatabase(tc);
            return true;
        }

        private bool musteriKontrolDatabase(string tckimlik)
        {
            return true;
        }
    }
}
