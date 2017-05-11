using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartYonetim
{
    public class Sikayet
    {
        public string Apart_Adi { get; set; }
        public string Daire { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }

        public Dictionary<string,Sikayetler> Sikayetler { get; set; }

    }
}
