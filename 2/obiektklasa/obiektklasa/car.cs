using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektklasa
{
    class car
    {
        public int rocznik;
        public string marka;
        public string kolor;

        public void Klakson(string klakson)
        {
            Console.WriteLine(klakson);
        }
    }
}
