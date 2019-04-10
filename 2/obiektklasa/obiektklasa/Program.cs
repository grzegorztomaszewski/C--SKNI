using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektklasa
{
    class Program
    {
        static void Main(string[] args)
        {
            uzytkownik user1 = new uzytkownik();
            user1.wiek = 34;
            user1.imie = "Kamil";

            uzytkownik user2 = new uzytkownik();
            user2.wiek = 10;
            user2.imie = "Michał";

            Dog husky = new Dog();
            husky.Szczekaj("hau hau");

            Dog mopsik = new Dog();
            mopsik.Szczekaj("mopsik szczeka");

            //
            car auto1 = new car();  //konstruktor - tworzy obiekt
            auto1.kolor = "red";    //definiowanie obiektu: kolor - red
            auto1.marka = "audi";   //^^
            auto1.rocznik = 2015;   //^^

            auto1.Klakson("beep");

            Console.ReadKey();
        }
    }
    class uzytkownik
    {
        public int wiek;
        public string imie;
    }
}
