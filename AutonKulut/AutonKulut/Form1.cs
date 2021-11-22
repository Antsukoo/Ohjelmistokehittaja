using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutonKulut
{
    public partial class Form1 : Form
    {
        double laina, nesteet, vakuutus, muut, poltto, pesut, huollot, renkaat, kilometrit, tulos;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void kilometritCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            laina = Convert.ToDouble(lainaLyhBox.Text);
            nesteet = Convert.ToDouble(lisNesteetBox.Text);
            vakuutus = Convert.ToDouble(vakuutusBox.Text);
            muut = Convert.ToDouble(muutKulutBox.Text);
            poltto = Convert.ToDouble(polttoNesteBox.Text);
            pesut = Convert.ToDouble(pesutBox.Text);
            huollot = Convert.ToDouble(huollotBox.Text);
            renkaat = Convert.ToDouble(renkaatBox.Text);
            kilometrit = Convert.ToDouble(kilometritCBox.Text);
            tulos = (laina + nesteet + vakuutus + muut + poltto + pesut + huollot + renkaat) / (kilometrit / 12);
            tulosLB.Text = "Kustannukset kilometriä kohti ovat: " + tulos;
        }
    }
}
