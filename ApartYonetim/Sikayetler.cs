using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartYonetim
{
   public class Sikayetler
    {
        public Sikayetler(string sikayet, long tarih, bool yapildi)
        {
            Sikayet = sikayet;
            Tarih = tarih;
            Yapildi = yapildi;
        }
        public Sikayetler()
        {

        }

        public string Sikayet { get; set; }
        public long Tarih { get; set; }
        public bool Yapildi { get; set; }
    }
}
