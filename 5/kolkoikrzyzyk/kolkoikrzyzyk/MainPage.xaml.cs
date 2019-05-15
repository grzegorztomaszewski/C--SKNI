using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace kolkoikrzyzyk
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();        
        }
    }

    public class Game2
    {
        private char[,] gameTab;
        public char WinnerMark;
        public Game2()
        {
            gameTab = new char[3, 3]; 
        }
        public bool AddToTabb(int x, int y, char mark)
        {
            if (!Char.IsLetter(gameTab[x,y])) //sprawdza, czy w danym polu znajduję się juz jakiś znak
            {
                gameTab[x, y] = mark;
                return true;
            }
            return false;   //jeśli tak, zwraca false
        }

        private bool CheckRows()    //sprawdza poziomo
        {
            char mark = 'X';
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (gameTab[i,0] == mark && gameTab[i,1] == mark && gameTab[i,2] == mark)
                    {
                        WinnerMark = mark;
                        return true;
                    }
                }
                mark = 'O';
            }
            return false;
        }

        private bool CheckCols()    //sprawdza pionowo
        {
            char mark = 'X';
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (gameTab[0, i] == mark && gameTab[1, i] == mark && gameTab[2, i] == mark)
                    {
                        WinnerMark = mark;
                        return true;
                    }
                }
                mark = 'O';
            }
            return false;
        }
        private bool CheckCross()   //sprawdza skosy
        {
            char mark = 'X';
            for (int i = 0; i < 2; i++)
            {
                if (gameTab[0, 0] == mark && gameTab[1, 1] == mark && gameTab[2, 2] == mark)
                {
                   WinnerMark = mark;
                   return true;
                }else if (gameTab[0, 2] == mark && gameTab[1, 1] == mark && gameTab[2, 0] == mark)
                {
                   WinnerMark = mark;
                   return true;
                }
                    mark = 'O';
            }
            return false;
        }

    }
}
