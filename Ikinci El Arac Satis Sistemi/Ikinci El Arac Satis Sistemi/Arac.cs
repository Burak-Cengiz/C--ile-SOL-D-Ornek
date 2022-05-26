using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public class Arac
    {
        public String ArabaMarka;
        public String ArabaModel;
        public String UretimYili;
        public String YakitTuru;
        public int Km;
        public int SatisFiyati;
        public int ID;

        public AracDonanimBilgileri AracDonanim;
        public Arac()
        {
            AracDonanim = new AracDonanimBilgileri();
        }
    }
}
