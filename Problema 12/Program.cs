using System;

namespace Problema_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu lungimea secventei: ");
            int lung = int.Parse(Console.ReadLine());

            int rezult = NumarGrupeDifZero(lung);
            Console.WriteLine($"Numarul de grupe este {rezult}");
        }

        static int NumarGrupeDifZero(int lung)
        {
            int numarGrupe = 0;
            Console.Write("Introdu numarul de pe pozitia 1: ");
            int numar = int.Parse(Console.ReadLine());

            for (int i = 1; i < lung; i++)
            {
                Console.Write($"Introdu numarul de pe pozitia {i + 1}: ");
                int numar_urm = int.Parse(Console.ReadLine());

                if (numar != 0 && numar_urm == 0)
                {
                    numarGrupe++;
                }

                numar = numar_urm;
            }

            return numarGrupe;
        }
    }
}
