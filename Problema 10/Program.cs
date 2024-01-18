using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea secventei: ");
            int lungimeSecventa = int.Parse(Console.ReadLine());
            int rezult = NumarMaxConsecutive(lungimeSecventa);

            Console.WriteLine($"Numarul maxim de numere consecutive egale: {rezult}");

        }

        static int NumarMaxConsecutive(int lungimeSecventa)
        {
            if (lungimeSecventa == 0)
            {
                return 0;
            }

            int numarMaxConsecutive = 1;
            int numarCurentConsecutive = 1;
            Console.Write("Introdu numarul 1: ");
            int numarPrecedent = int.Parse(Console.ReadLine());

           
            for (int i = 1; i < lungimeSecventa; i++)
            {
                Console.Write($"Introdu numarul {i + 1}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent == numarPrecedent)
                {
                    numarCurentConsecutive++;
                }
                else
                {
                    numarCurentConsecutive = 1;
                }

                numarMaxConsecutive = Math.Max(numarMaxConsecutive, numarCurentConsecutive);
                numarPrecedent = numarCurent;
            }

            return numarMaxConsecutive;
        }
    }
}
        
