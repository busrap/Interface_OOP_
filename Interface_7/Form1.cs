using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Interface sadece miras vermek amaçlıdır,tek başına (miras vermeden )kullanımı bir şey ifade etmez.
            //Interfaceler base class olmak için değil,Base class'dan türeyen drived'ların ayrı ayrı özellikleri varsa drived classlara yetenek kazandırmak için türetilir.
            //Interface bir Class değildir, kendine has bir yapıdır enum gibi
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu O = new Oyuncu();
            O.Adi = "Polat";
            O.Yasi = 24;
            O.YasamDegeri = 100;


            //O.OyuncununSilahi = new Kanas();
            Kanas N = new Kanas();//Yukarı da ki tanımlama ile bunun arasında hiç bir fark yoktur
            O.OyuncununSilahi = N;

            MessageBox.Show(O.NisanAl());
        }
    }
}
