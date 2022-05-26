using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikinci_El_Arac_Satis_Sistemi
{
    public partial class frmSistem : Form
    {
        public frmSistem()
        {
            InitializeComponent();
        }


       
        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            AracIslem aracIslem = new AracIslem();
            AracSahibi AracSahibi = new AracSahibi(aracIslem);
            


            
            

            AracYorum aracYorum = new AracYorum();
            AracGoruntule aracGoruntule = new AracGoruntule();

            SistemYöneticisi sistemYöneticisi = new SistemYöneticisi(aracGoruntule,aracYorum);


            Musteri musteri = new Musteri(aracGoruntule, aracYorum);

            

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
