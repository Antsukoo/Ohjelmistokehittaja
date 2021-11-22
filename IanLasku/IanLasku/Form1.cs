using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IanLasku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime date = dateTimePicker1.Value;

            double erotusD = Math.Round((nyt - date).TotalDays);

            double erotusY = erotusD / 365.25;
            double erotusMo = erotusY * 12;
            
            double erotusH = Math.Round((nyt - date).TotalHours);
            double erotusM = Math.Round((nyt - date).TotalMinutes);
            double erotusS = Math.Round((nyt - date).TotalSeconds);

            Vuosissa.Text += erotusY + "";
            Kuukausissa.Text += erotusMo + "";
            Paivissa.Text += erotusD + "";
            Tunneissa.Text += erotusH + "";
            Minuuteissa.Text += erotusM + "";
            Sekunneissa.Text += erotusS + "";

            Vuosissa.Visible = true;
            Kuukausissa.Visible = true;
            Paivissa.Visible = true;
            Tunneissa.Visible = true;
            Minuuteissa.Visible = true;
            Sekunneissa.Visible = true;
        }
    }
}
