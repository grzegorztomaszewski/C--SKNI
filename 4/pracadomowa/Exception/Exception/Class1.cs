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

            }
            catch(Exception)
            {

            }
        }
        public void Metoda2()
        {

        }
    }

}