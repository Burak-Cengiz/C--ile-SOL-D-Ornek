using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public class AracSahibi 
    {
        private IAracIslem IaracIslem;
        
        public String Ad;
        public String Soyad;
        public String Eposta;
        public String Sifre;
        
        public AracSahibi(IAracIslem aracIslem)
        {
            
            this.IaracIslem = aracIslem;
        }

        public void AracEkle(String ArabaMarka, String ArabaModel, String UretimYili, String YakitTuru, int Km, int SatisFiyati, int ID)
        {
            this.IaracIslem.AracEkle(ArabaMarka, ArabaModel, UretimYili, YakitTuru,Km, SatisFiyati, ID);      
        }

        public void AracGuncelle(int ID, string ArabaMarka, string ArabaModel, string UretimYili, string YakitTuru, int Km, int SatisFiyati)
        {
            this.IaracIslem.AracGuncelle(ID,ArabaMarka, ArabaModel, UretimYili, YakitTuru, Km, SatisFiyati);

        }

        public void AracSil(int ID)
        {
            this.IaracIslem.AracSil(ID);
        }

        public void Kaydol(String Ad, String SoyAd, String eposta, String Sifre)
        {
            this.Ad = Ad;
            this.Soyad = SoyAd;
            this.Sifre = Sifre;
            this.Eposta = eposta;
        }

    }
}
