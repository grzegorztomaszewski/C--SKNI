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
            Uzytkownik user1 = new Uzytkownik();
            user1.wiek = 34;
            user1.imie = "Kamil";

            Uzytkownik user2 = new Uzytkownik();
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

            Uzytkownik uz1 = new Uzytkownik("Szymon", 21);
            int wartosc = uz1.ObliczSume(10, 20);

            Console.WriteLine(wartosc);

            Console.ReadKey();
        }
    }
    class Uzytkownik
    {
        public Uzytkownik()
        {

        }

        public Uzytkownik(string name)
        {

        }

        public Uzytkownik(string name, int age)
        {
            imie = name;
            wiek = age;
        }
        
        public int wiek;
        public string imie;

        public int ObliczSume(int a, int b)
        {
            return a+b;
        }
    }
}
