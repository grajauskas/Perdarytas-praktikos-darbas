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
    public partial class AntPop : Form
    {
        public AntPop(int pirmas)
        {
            var antras = 0.15;
            var trecias = 0.06;
            var ketvirtas = 0.03;

            var vmi = pirmas * antras;
            var sodSveikDrau = pirmas * trecias;
            var sodPencDrau = pirmas * ketvirtas;
            var antPop = pirmas - (pirmas * antras) - (pirmas * trecias) - (pirmas * ketvirtas);

            InitializeComponent();
            textBox1.Text = vmi.ToString();
            textBox2.Text = sodSveikDrau.ToString();
            textBox3.Text = sodPencDrau.ToString();
            textBox4.Text = antPop.ToString();
        }
    }
}
