using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public interface IAracIslem
    {
       
        void AracGuncelle(int ID,String ArabaMarka, String ArabaModel, String UretimYili, String YakitTuru, int Km, int SatisFiyati);
        void AracEkle(String ArabaMarka, String ArabaModel, String UretimYili, String YakitTuru, int Km, int SatisFiyati,int ID);
        
        void AracSil(int ID);

    }
}
