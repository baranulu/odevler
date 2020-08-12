using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kutuphane
{
    class Kitapkaydi
    {
        public string Kitapadi { get; set; }
        public string Yazaradi { get; set; }
        public string Yayinevi { get; set; }
        public string KitapTuru { get; set; }
        public int Baskisayisi { get; set; }
        public int  sayfasayisi { get; set; }
        public ulong ISBNno { get; set; }
        public string Basimyili { get; set; }

        public override string ToString()
        {
            return this.Kitapadi + " " + this.Yazaradi;
        }
    }
}
