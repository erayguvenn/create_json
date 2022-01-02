using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace jsonCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doktor id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("doktor ad:");
            string ad = Console.ReadLine();
            Console.WriteLine("doktor soyad:");
            string soyad = Console.ReadLine();
            Console.WriteLine("doktor poliklinik:");
            string poliklinik = Console.ReadLine();
            doktor doc = new doktor();
            doc.docEkle(id, ad, soyad, poliklinik);
            doc.dosyaKaydet();
            Console.ReadLine();

        }
    }

   
}
