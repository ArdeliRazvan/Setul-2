using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cp = 0, cn = 0, cz = 0;
            Console.WriteLine("Introdu cat de lung vrei sa fie sirul");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nr;
                nr = Convert.ToInt32(Console.ReadLine());
                if (nr > 0)
                    cp++;

                else if (nr < 0)
                    cn++;

                else if (nr == 0) cz++;
            }

            Console.WriteLine($"Sunt {cn} numere negative, {cp} numere pozitive si {cz} de zerouri");

        }
    }
}
