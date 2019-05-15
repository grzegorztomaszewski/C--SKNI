using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class Class1
    {
        //NullPointerException — rzucany kiedy próbujesz wywołać metodę na zmiennej, której wartość to null
        //IllegalArgumentException — rzucany, kiedy przekazywany argument jest z jakiegoś powodu nieprawidłowy(walidacja wewnątrz metod)
        //IOException(wyjątki po nim dziedziczące) — rzucany w przypadku problemów z systemem wejścia/wyjścia, czyli najogólniej rzecz ujmując, kiedy wystąpi problem przy pracy z plikami lub z transmisją danych za pośrednictwem internetu
        //NumberFormatException — rzucany, kiedy próbujemy zamienić na liczbę np.obiekt typu String, który zawiera nie tylko cyfry
        //IndexOutOfBoundException — rzucany, kiedy próbujemy się odwołać do nieistniejącego elementu tablicy lub listy
        public void Metoda1()
        {
            try
            {
                Console.WriteLine("Witaj w kalkulatorze");
                Console.WriteLine("Wpisz pierwszą liczbę: ");
                string a = Console.ReadLine();
                Console.WriteLine("Wpisz drugą liczbę: ");
                string b = Console.ReadLine();
                int b1 = int.Parse(a);
                int b2 = int.Parse(b);
                Console.WriteLine($"Wynik to: {b1 / b2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Złapano Exception (Nie dziel przez 0)");
            }
        }
        public void Metoda2()
        {
            try
            {
                Console.WriteLine("Witaj w kalkulatorze");
                Console.WriteLine("Wpisz pierwszą liczbę: ");
                string a = Console.ReadLine();
                Console.WriteLine("Wpisz drugą liczbę: ");
                string b = Console.ReadLine();
                int b1 = int.Parse(a);
                int b2 = int.Parse(b);
                Console.WriteLine($"Wynik to: {b1 / b2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Złapano Exception (string zamiast inta)");
            }
        }
    }

}