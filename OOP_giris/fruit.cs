using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_giris
{
    class fruit
    {

        //public string fruitName { get; set; }
        //public string meyveRengi { get; set; }
        //public DateTime olusturmaTarihi { get; set; }

        private string fruitName;
        private string meyveRengi;
        private DateTime olusturmaTarihi;

        public string FruitName { get => fruitName; set => fruitName = value; }
        public string MeyveRengi { get => meyveRengi; set => meyveRengi = value; }
        public DateTime OlusturmaTarihi { get => olusturmaTarihi; set => olusturmaTarihi = value; }
    }
}
