using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikos_Darbas
{
    public partial class Rezultatas : Form
    {
 
        public Rezultatas(int pirmas)
        {
            var antras = 0.15;
            var trecias = 0.06;
            var ketvirtas = 0.03;
            var penktas = 0.30;
            var sestas = 0.02;
            var septintas = 0.05;
            

            var vmi = pirmas * antras;
            var sodSveikDrau = pirmas * trecias;
            var sodPencDrau = pirmas * ketvirtas;
            var iRankas = pirmas + (pirmas * antras) + (pirmas * trecias) + (pirmas * ketvirtas);
            var darbSodra = iRankas + (pirmas * penktas) + (pirmas * sestas) + (pirmas * septintas);
            

            InitializeComponent();
            textBox1.Text = vmi.ToString();
            textBox2.Text = sodSveikDrau.ToString();
            textBox3.Text = sodPencDrau.ToString();
            textBox4.Text = iRankas.ToString();
            textBox5.Text = darbSodra.ToString();
            textBox6.Text = "0";

        }

        
    }
}
