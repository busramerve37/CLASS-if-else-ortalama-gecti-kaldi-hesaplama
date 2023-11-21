using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sinav sinav= new Sinav();
            sinav.yazili1 = Convert.ToInt32(txtYazili1.Text);
            sinav.yazili2 = Convert.ToInt32(txtYazili2.Text);

            lblOrtalama.Text = "Ortalama " + sinav.OrtalamaHesapla();

            if (sinav.OrtalamaHesapla()>50)
            {
                lblDurum.Text = "Kaldı ";
            }
            else
            {
                lblDurum.Text = "Geçti ";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
