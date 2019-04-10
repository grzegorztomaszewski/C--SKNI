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
            dzieleniezero:
            b = Console.ReadLine();
            float b1 = float.Parse(a);
            float b2 = float.Parse(b);
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

            if(znak == "/" && b2 != 0)
            {
                Console.WriteLine($"Wynik dzielenia to: {b1/b2}");
            }
            else{
                Console.WriteLine("Nie dziel przez zero!");
                goto dzieleniezero;
            }

            if(znak == "%" && b2 != 0)
            {
                Console.WriteLine($"Wynik z modulo to: {b1%b2}");
            }
            else
            {
                Console.WriteLine("Nie dziel przez zero!");
                goto dzieleniezero;
            }

            Console.WriteLine("Naciśnij klawisz aby wyjść.");
            Console.ReadKey();
        }
    }
}
//Grzegorz Tomaszewski
