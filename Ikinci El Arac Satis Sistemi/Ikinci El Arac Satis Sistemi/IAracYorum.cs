using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public interface IAracYorum
    {
        String AracKarsilastir(Arac[] list,int ID);
        String AracSahibiBilgi(Arac[] list, int ID);
    }
}
