﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public class Musteri
    {
        public IGoruntuleme Igoruntuleme;
        public IAracYorum IAracYorum;

        public void YorumYap()
        {
            //
        }

        public Musteri(IGoruntuleme goruntuleme, IAracYorum aracYorum)
        {
            this.Igoruntuleme = goruntuleme;
            this.IAracYorum = aracYorum;
        }
        public void aracArama(Arac[] list,int ID)
        {
            this.Igoruntuleme.AracAra(list,ID);
        }

        public void AracKarsilastir(Arac[] list, int ID)
        {
            this.IAracYorum.AracKarsilastir(list,ID);
        }

        public void AracSahibiBilgiGetir(Arac[] list, int ID)
        {
            this.IAracYorum.AracSahibiBilgi(list,ID);
        }

    }
}
