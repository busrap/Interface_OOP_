using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_7
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int YasamDegeri { get; set; }
        public int Yasi { get; set; }
        public Silah OyuncununSilahi { get; set; }//Silah Class'ını dogrudan ya da dolaylı olarak miras almış Class'lar (uzi,kanas,bıçak...) bu özellikten yararlanabilecek
        public string NisanAl()
        {
            //nişan alma işlemleri yapılacak
            if (OyuncununSilahi is IYakinlastirilaBilable)
            {
                IYakinlastirilaBilable iy;
                 iy = (IYakinlastirilaBilable)OyuncununSilahi;
                return iy.Yakinlastir();
            }
            else
          
                return "";
            
            
        }
        public void Saldir()
        {
            //saldirma işlemleri yapılacak
        }
    }
}
