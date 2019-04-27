using System;

namespace consolekolkokrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tab;
            tab = new char[3, 3];
            int liczbaX;
            int liczbaO;
            bool winner = true;

        Console.WriteLine("Witaj w grze kółko i krzyżyk.");
            Console.WriteLine("Pole do gry wygląda następująco:");
            Console.WriteLine("   1.[0,0]   2.[1,0]   3.[2,0]\n   4.[0,1]   5.[1,1]   6.[2,1]\n   7.[0,2]   8.[1,2]   9.[2,2]");
            Console.WriteLine("Zaczyna gracz 'X'.");
            //Runda 1, 2, 3
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Runda {i+1}");
                Console.WriteLine("Ruch gracza 'X'.\nPodaj swoje pole: ");
                back1:
                liczbaX = Convert.ToInt32(Console.ReadLine());
                    if (liczbaX >= 1 && liczbaX <= 9)
                    {
                        WstawZnakX();
                    }
                    else
                    {
                        Console.WriteLine("Podana liczba nie mieści się w zakresie!!\nPodaj liczbę ponownie: ");
                    goto back1;
                    }

                Console.WriteLine("Ruch gracza 'O'.\n Podaj swoje pole: ");
                liczbaO = Convert.ToInt32(Console.ReadLine());
                WstawZnakO();
            }

            //------CheckWin
            CheckWin();

            if (winner == false)
            {
                Console.WriteLine("Runda 4");//Runda 4
                Console.WriteLine("Ruch gracza 'X'.\n Podaj swoje pole: ");
                liczbaX = Convert.ToInt32(Console.ReadLine());
                WstawZnakX();

                Console.WriteLine("Ruch gracza 'O'.\n Podaj swoje pole: ");
                liczbaO = Convert.ToInt32(Console.ReadLine());
                WstawZnakO();

                //------CheckWin
                CheckWin();
            }
            else
            {
                Console.WriteLine("Dziękujemy, koniec gry;)");
            }

            if (winner == false)
            {
                Console.WriteLine("Runda 5");//Runda 5
                Console.WriteLine("Ruch gracza 'X'.\n Podaj swoje pole: ");
                liczbaX = Convert.ToInt32(Console.ReadLine());
                WstawZnakX();
            }
            else
            {
                Console.WriteLine("Dziękujemy, koniec gry;)");
            }

            if (winner == false)
            {
                Console.WriteLine("Mamy remis!");
            }
            else
            {
                Console.WriteLine("Dziękujemy, koniec gry;)");
            }

            //zabezpieczenia:
            //jesli wybrany numer jest juz zajety daj komunikat i wpisz liczbe jeszcze raz
            //zwróć komunikat jeśli liczbaX/liczbaO != int

            void WstawZnakX()
            {
                switch (liczbaX)
                {
                    case 1:
                        Console.WriteLine("Znak postawiony w [0,0]");
                        tab[0, 0] = 'x';
                        break;
                    case 2:
                        Console.WriteLine("Znak postawiony w [1,0]");
                        tab[1, 0] = 'x';
                        break;
                    case 3:
                        Console.WriteLine("Znak postawiony w [2,0]");
                        tab[2, 0] = 'x';
                        break;
                    case 4:
                        Console.WriteLine("Znak postawiony w [0,1]");
                        tab[0, 1] = 'x';
                        break;
                    case 5:
                        Console.WriteLine("Znak postawiony w [1,1]");
                        tab[1, 1] = 'x';
                        break;
                    case 6:
                        Console.WriteLine("Znak postawiony w [2,1]");
                        tab[2, 1] = 'x';
                        break;
                    case 7:
                        Console.WriteLine("Znak postawiony w [0,2]");
                        tab[0, 2] = 'x';
                        break;
                    case 8:
                        Console.WriteLine("Znak postawiony w [1,2");
                        tab[1, 2] = 'x';
                        break;
                    case 9:
                        Console.WriteLine("Znak postawiony w [2,2]");
                        tab[2, 2] = 'x';
                        break;
                    default:
                        break;
                }
            }

            void WstawZnakO()
            {
                switch (liczbaO)
                {
                    case 1:
                        Console.WriteLine("Znak postawiony w [0,0]");
                        tab[0, 0] = 'o';
                        break;
                    case 2:
                        Console.WriteLine("Znak postawiony w [1,0]");
                        tab[1, 0] = 'o';
                        break;
                    case 3:
                        Console.WriteLine("Znak postawiony w [2,0]");
                        tab[2, 0] = 'o';
                        break;
                    case 4:
                        Console.WriteLine("Znak postawiony w [0,1]");
                        tab[0, 1] = 'o';
                        break;
                    case 5:
                        Console.WriteLine("Znak postawiony w [1,1]");
                        tab[1, 1] = 'o';
                        break;
                    case 6:
                        Console.WriteLine("Znak postawiony w [2,1]");
                        tab[2, 1] = 'o';
                        break;
                    case 7:
                        Console.WriteLine("Znak postawiony w [0,2]");
                        tab[0, 2] = 'o';
                        break;
                    case 8:
                        Console.WriteLine("Znak postawiony w [1,2");
                        tab[1, 2] = 'o';
                        break;
                    case 9:
                        Console.WriteLine("Znak postawiony w [2,2]");
                        tab[2, 2] = 'o';
                        break;
                    default:
                        break;
                }
            }

            void CheckWin()
            {
                #region Win X
                if (tab[0,0] == 'x' && tab[1,0] == 'x' && tab[2,0] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (poziomo, pierwszy rząd)");
                    winner = true;
                }
                else if(tab[0, 1] == 'x' && tab[1, 1] == 'x' && tab[2, 1] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (poziomo, drugi rząd)");
                    winner = true;
                }
                else if (tab[0, 2] == 'x' && tab[1, 2] == 'x' && tab[2, 2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (poziomo, trzeci rząd)");
                    winner = true;
                }
                else if (tab[0, 0] == 'x' && tab[0, 1] == 'x' && tab[0, 2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (pionowo, pierwszy rząd)");
                    winner = true;
                }
                else if (tab[1, 0] == 'x' && tab[1, 1] == 'x' && tab[1, 2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (pionowo, drugi rząd)");
                    winner = true;
                }
                else if (tab[2, 0] == 'x' && tab[2, 1] == 'x' && tab[2, 2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (pionowo, trzeci rząd)");
                    winner = true;
                }
                else if (tab[0,0] == 'x' && tab[1,1] == 'x' && tab[2,2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (skośnie, lewa góra-prawy dół)");
                    winner = true;
                }
                else if (tab[2, 0] == 'x' && tab[1, 1] == 'x' && tab[0, 2] == 'x')
                {
                    Console.WriteLine("Wygrał gracz X (skośnie, prawa góra-lewy dół)");
                    winner = true;
                }
                else
                {
                    #region WIN Y
                    if (tab[0, 0] == 'y' && tab[1, 0] == 'y' && tab[2, 0] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (poziomo, pierwszy rząd)");
                        winner = true;
                    }
                    else if (tab[0, 1] == 'y' && tab[1, 1] == 'y' && tab[2, 1] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (poziomo, drugi rząd)");
                        winner = true;
                    }
                    else if (tab[0, 2] == 'y' && tab[1, 2] == 'y' && tab[2, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (poziomo, trzeci rząd)");
                        winner = true;
                    }
                    else if (tab[0, 0] == 'y' && tab[0, 1] == 'y' && tab[0, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (pionowo, pierwszy rząd)");
                        winner = true;
                    }
                    else if (tab[1, 0] == 'y' && tab[1, 1] == 'y' && tab[1, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (pionowo, drugi rząd)");
                        winner = true;
                    }
                    else if (tab[2, 0] == 'y' && tab[2, 1] == 'y' && tab[2, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (pionowo, trzeci rząd)");
                        winner = true;
                    }
                    else if (tab[0, 0] == 'y' && tab[1, 1] == 'y' && tab[2, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (skośnie, lewa góra-prawy dół)");
                        winner = true;
                    }
                    else if (tab[2, 0] == 'y' && tab[1, 1] == 'y' && tab[0, 2] == 'y')
                    {
                        Console.WriteLine("Wygrał gracz Y (skośnie, prawa góra-lewy dół)");
                        winner = true;
                    }
                    else
                    {
                        Console.WriteLine("\nJeszcze nie ma zwycięzcy. Gramy dalej!");
                        winner = false;
                    }
                    #endregion
                }
                #endregion


            }
        }
    }
}