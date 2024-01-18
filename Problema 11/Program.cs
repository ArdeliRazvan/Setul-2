using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea secventei: ");
            int lungume = int.Parse(Console.ReadLine());

            double suma = SumaSecventa(lungume);
            Console.WriteLine($"Suma inverselor este {suma}: ");
        }

       static double SumaSecventa(int lungume)
        {
            double suma = 0;
            for (int i = 0; i < lungume; i++)
            {
                Console.Write($"Introdu numarul {i + 1}: ");
                double numar = double.Parse(Console.ReadLine());

                double invers = 1 / numar;
                suma += invers;
            }
            return suma; 
        }
      
    }
}
