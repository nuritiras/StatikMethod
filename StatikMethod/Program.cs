using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ogrenci = new
            {
                Numara = 35,
                Ad = "Yasin",
                Ortalama = 80.5
            };

            Yaz(ogrenci);
        }
        static void Yaz(dynamic ogr)
        {
            Console.WriteLine("Öğrencinin adı: "+ogr.Ad);
        }
    }
}
