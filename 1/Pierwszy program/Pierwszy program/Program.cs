using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string zmienna1 = "Cześć";
            Console.WriteLine(zmienna1);
            Console.WriteLine("Hello world!");

            //deklaracja
            short a;
            int b;
            double c;

            //inicjalizacja
            a = 10;
            b = 20;
            c = a + b;

            //wypisywanie
            Console.WriteLine("a= {0}, b={1}, c={2}", a,b,c);
            Console.WriteLine($"a= {a}, b={b}, c={c}");

            c = a + b;
            Console.WriteLine($"a+b={c}");

            c = a - b;
            Console.WriteLine($"a-b={c}");

            c = a * b;
            Console.WriteLine($"a*b={c}");

            c = a++;
            Console.WriteLine($"a={a}||c={c}");

            c = ++a;
            Console.WriteLine($"a={a} || c={c}");


            //operatory porównania

            Console.WriteLine("a == b -> {0}", a == b);
            Console.WriteLine("a > b -> {0}", a > b);
            Console.WriteLine("a >= b -> {0}", a >= b);
            */

            string input;
            Console.WriteLine("Podaj swój wiek: ");
            input = Console.ReadLine();
            int wiek = int.Parse(input);
            if (wiek>20)
            {
            Console.WriteLine("Witaj dorosły!");
            }
            else
            {
                Console.WriteLine("Witaj dzieciaku!");
            }

            //if(string.equals()) or if(input == "+"{cw()"Wykonaj dodawanie"});

            Console.ReadLine(); //komentarz
        }
    }
}
