using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public class AracIslem : IAracIslem
    {
        
       

        public void AracEkle(String ArabaMarka, String ArabaModel, String UretimYili, String YakitTuru, int Km, int SatisFiyati,int ID)
        {
                    //            
        }

        public void AracGuncelle(int ID, string ArabaMarka, string ArabaModel, string UretimYili, string YakitTuru, int Km, int SatisFiyati)
        {
            throw new NotImplementedException();
        }

        public void AracSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
