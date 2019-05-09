using System;
using System.Collections.Generic;
using System.Text;

namespace z4
{
    public class Class1
    {
        public int Dodaj(int x, int y)
        {
            return x + y;
        }
    }

    public class Class2
    {
        public void Metoda1(int a, int b, out int re, out int ilor)
        {
            int reszta = a % b;
            int iloraz = a / b;

            re = reszta;
            ilor = iloraz;
        }
        public void Metoda2(int a, int b, int re, int ilor)
        {
            int reszta = a % b;
            int iloraz = a / b;

            re = reszta;
            ilor = iloraz;
        }
        public void Metoda3(ref int re,ref int ilor)
        {
            int a =re;
            int b =ilor;

            int reszta = a % b;
            int iloraz = a / b;

            re = iloraz;
            ilor = reszta;
        }
    }
}
