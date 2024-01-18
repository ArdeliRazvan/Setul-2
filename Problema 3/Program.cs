using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num = int.Parse(Console.ReadLine());
            int suma = 0;
            int produs = 1;
            for (int i = 1; i <= num; i++) 
            {
                suma += i;
                produs *= i;    
            }
            Console.WriteLine($"suma este {suma}, iar produsul este {produs}");

        }
    }
}
