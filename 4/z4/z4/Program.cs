using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Class1.Dodaj(3,4));    
            Class2 class2 = new Class2();
            int reszta = 0;
            int iloraz = 0;
            class2.Metoda2(13,3, reszta, iloraz);

            Class2 cls = new Class2();
            int a = 13;
            int b = 3;
            cls.Metoda3(ref a, ref b);

            Console.WriteLine($"Iloraz: {a}, reszta: {b}");
            try
            {
                int[] tab = new int[4];
                tab[0] = 0;
                tab[1] = 1;
                tab[2] = 2;
                tab[3] = 3;
                tab[4] = 4;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("OutOfRange");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Koniec");
            }
            //zrób 2 dowolneprzypadki (stwórz 1 klase, w środku 2 metody - te metody mają mieć try catche, mają wygenerować jakieś błędy, mająbyć złapane)
            //konwersja stringa na inta ("znak" => liczba)
            //wypisz na konsole tekst " złapano exception
            //w mainaie odpalenie metody, całosć w klasiea"

        } 
            //static void Wypisz(string tekst)
            //{
            //    Console.WriteLine(tekst);
            //}

        //void Wypisz2(string tekst)
        //{
        //    Console.WriteLine(tekst);
        //}
    }
}
