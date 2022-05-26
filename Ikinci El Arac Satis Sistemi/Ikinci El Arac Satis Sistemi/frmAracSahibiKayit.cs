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
    public partial class frmAracSahibiKayit : Form
    {
        
        public frmAracSahibiKayit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            
            frmSistem frmSistem = new frmSistem();
            frmSistem.Show();
            

        }
    }
}
