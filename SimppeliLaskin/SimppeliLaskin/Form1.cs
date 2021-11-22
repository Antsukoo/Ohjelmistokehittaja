using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimppeliLaskin
{
    public partial class Form1 : Form
    {
        public float text;
        public float text1Int;
        public float text2Int;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1Int = float.Parse(LukuYksiTB.Text);
            text2Int = float.Parse(LukuKaksiTB.Text);

            string ope = LaskuToimitusCB.Text.ToString();

            switch (ope){

                case "+":
                    text = text1Int + text2Int;
                    Tulos.Text = text.ToString();
                    break;

                case "-":
                    text = text1Int - text2Int;
                    Tulos.Text = text.ToString();
                    break;

                case "*":
                    text = text1Int * text2Int;
                    Tulos.Text = text.ToString();
                    break;

                case "/":
                    if (text2Int != 0)
                    {
                        text = text1Int / text2Int;
                        Tulos.Text = text.ToString();   
                    }
                    else
                    {
                        Tulos.Text = "Ei voi jakaa nollalla!";
                    }
                    break;


                default:
                    break;
            }

            Tulos.Visible = true;
        }
    }
}
