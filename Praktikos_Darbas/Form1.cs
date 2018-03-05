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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSkaiciavimas_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBoxIRank.Text);

            textBoxIRank.Text = "";

            var forma = new Rezultatas(pirmas);
            
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBoxAntPop.Text);

            textBoxAntPop.Text = "";

            var forma = new AntPop(pirmas);
            forma.ShowDialog();
        }

        private void buttonKonf_Click(object sender, EventArgs e)
        {


            using (var forma = new Konfiguracija())
            {

                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {

                }
            }
        }
    }
}
