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
    public partial class Konfiguracija : Form
    {
        public int Skaicius { get; set; }


        public Konfiguracija()
        {
            InitializeComponent();
        }

        private void Konfiguracija_Load(object sender, EventArgs e)
        {

        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            Skaicius = Convert.ToInt32(textBox1.Text);
            
        }
    }
}
