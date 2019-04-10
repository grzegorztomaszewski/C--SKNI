using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektklasa
{
    public class Dog
    {
        public int wiek;
        public string rasa;
        public double waga;

        public void Szczekaj(string szczekanie)
        {
            Console.WriteLine(szczekanie);
        }
    }
}
