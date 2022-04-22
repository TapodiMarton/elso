using System;
using System.Collections.Generic;
using System.IO;

namespace lottovizsga
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            List<Sorsolas> sorsolas_list = new List<Sorsolas>();
            string[] lines = File.ReadAllLines("sorsolas.txt");

            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Sorsolas sorsolas_object = new Sorsolas(values[0], values[1], values[2], values[3], values[4], values[5]);
                sorsolas_list.Add(sorsolas_object);
            }

            //2.f

            Console.WriteLine("Hét: ");
            string bekert_szam = Console.ReadLine();

            foreach (var item in sorsolas_list)
            {
                if (item.het == bekert_szam)
                {
                    Console.WriteLine($"{item.het}, {item.szam1},  {item.szam2}, {item.szam3}, {item.szam4}, {item.szam5}");
                }
            }

            //3.

            List<Szam> szamok = new List<Szam>();

            int db = 0;
            for (int i = 1; i < 91; i++)
            {
                foreach (var item in sorsolas_list)
                {
                    if (i == item.szam1 || i == item.szam2 || i == item.szam3 || i == item.szam4 || i == item.szam5)
                    {
                        db++;
                    }
                }
                Szam szam_object = new Szam(i, db);
                szamok.Add(szam_object);
                db = 0;
            }

            int max = int.MinValue;
            int legnagyobb_eredmeny = 0;
            foreach (var item in szamok)
            {
                if (max < item.db)
                {
                    max = item.db;
                    legnagyobb_eredmeny = item.szam;
                }
            }
            Console.WriteLine($"A legtöbbször kihúzott: {legnagyobb_eredmeny}: {max}");

            //4.

            int sum = 0;
            foreach (var item in szamok)
            {
                if (item.szam % 2 == 0)
                {
                    sum += item.db;
                }
            }
            Console.WriteLine("Páros szám db: " + sum);

            //5.-6.

            int szam5 = 0;
            int szam46 = 0;
            foreach (var item in szamok)
            {
                if (item.szam == 5)
                {
                    szam5 = item.db;
                }
            }
            Console.WriteLine("5: " + szam5);

            foreach (var item in szamok)
            {
                if (item.szam == 46)
                {
                    szam46 = item.db;
                }
            }
            Console.WriteLine("46: " + szam46);

            //7.

            foreach (var item in szamok)
            {
                Console.WriteLine($"{item.szam}: {item.db}");
            }

        }

    }
    
}