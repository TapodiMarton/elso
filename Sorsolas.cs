using System;
using System.Collections.Generic;
using System.Text;

namespace lottovizsga
{
    public class Sorsolas
    {
        public string het;
        public int szam1;
        public int szam2;
        public int szam3;
        public int szam4;
        public int szam5;

        public Sorsolas(string week, string num1, string num2, string num3, string num4, string num5)
        {
            this.het = week;
            this.szam1 = int.Parse(num1);
            this.szam2 = int.Parse(num2);
            this.szam3 = int.Parse(num3);
            this.szam4 = int.Parse(num4);
            this.szam5 = int.Parse(num5);
        }

    }
}