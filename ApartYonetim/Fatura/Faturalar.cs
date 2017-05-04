using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartYonetim.Fatura
{
    class Faturalar
    {
        string aboneNo, isim, faturaDonemi, fiyat;

        public string FaturaDonemi
        {
            get
            {
                return faturaDonemi;
            }

            set
            {
                faturaDonemi = value;
            }
        }

        public string Fiyat
        {
            get
            {
                return fiyat;
            }

            set
            {
                fiyat = value;
            }
        }

        public string AboneNo
        {
            get
            {
                return aboneNo;
            }

            set
            {
                aboneNo = value;
            }
        }

        public string Isim
        {
            get
            {
                return isim;
            }

            set
            {
                isim = value;
            }
        }
        public override string ToString()
        {
            return aboneNo + "=> İsim: " + isim + " Fatura Dönemi: " + faturaDonemi + " Borç: " + fiyat + " TL";
        }
        public Faturalar(string aboneNo, string isim, string faturaDonemi, string fiyat)
        {
            this.AboneNo = aboneNo;
            this.Isim = isim;
            this.FaturaDonemi = faturaDonemi;
            this.Fiyat = fiyat;
        }
    }
}
