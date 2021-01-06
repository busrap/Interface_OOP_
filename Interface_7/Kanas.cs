using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_7
{
    class Kanas : AtesliSilahlar, IYakinlastirilaBilable
    {
        public string Yakinlastir()
        {
            return "Yakınlastırıldı";
        }
    }
}
