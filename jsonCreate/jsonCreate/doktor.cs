using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace jsonCreate
{
   public class doktor
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string poliklinik { get; set; }

        public void docEkle(int id,string ad,string soyad,string poliklinik)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.poliklinik = poliklinik;

        }
        public void dosyaKaydet()
        {
            var obj = new doktor()
            {
                id = this.id,
                ad = this.ad,
                soyad = this.soyad,
                poliklinik = this.poliklinik,
               
            };

            string JSONsonuc = JsonConvert.SerializeObject(obj);
            string yol = @"D:\D Bilgiler\ders\jsonCevir\doktor.json";

            using (var tw = new StreamWriter(yol, true))
            {
                tw.WriteLine(JSONsonuc.ToString());
                tw.Close();
            }
        }


    }
}
