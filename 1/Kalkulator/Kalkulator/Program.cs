using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string znak;

            Console.WriteLine("Witaj w kalkulatorze");
            Console.WriteLine("Wstaw znak:\n dodawania(+)\n odejmowania(-)\n mnożenia(*)\n dzielenia(/)\n modulo(%)"  );
            znak = Console.ReadLine();
            Console.WriteLine("Wpisz pierwszą liczbę: ");
            a = Console.ReadLine();
            Console.WriteLine("Wpisz drugą liczbę: ");
            b = Console.ReadLine();
            int b1 = int.Parse(a);
            int b2 = int.Parse(b);
            char znak1 = char.Parse(znak);
            if(znak == "+")
            {
                Console.WriteLine($"Wynik dodawania to: {b1+b2}");
            }

            if(znak == "-")
            {
                Console.WriteLine($"Wynik odejmowania to: {b1-b2}");
            }

            if(znak == "*")
            {
                Console.WriteLine($"Wynik mnożenia to: {b1*b2}");
            }

            if(znak == "/")
            {
                Console.WriteLine($"Wynik dzielenia to: {b1/b2}");
            }

            if(znak == "%")
            {
                Console.WriteLine($"Wynik z modulo to: {b1%b2}");
            }

            Console.WriteLine("Naciśnij klawisz aby wyjść.");
            Console.ReadKey();
        }
    }
}
//Grzegorz Tomaszewski
