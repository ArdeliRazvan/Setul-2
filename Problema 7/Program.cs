using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Care este lungimea dorita a vectorului ? : ");
            int lung = int.Parse(Console.ReadLine());
            sec(lung, out int min, out int max);
        }

        static void sec(int lung,out int min,out int max)
        {   min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < lung; i++) 
            {   
                Console.Write($"Introduceti elementul de pe pozitita {i}: ");
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                    min = num;
                if (num > max)
                    max = num;

            }
            Console.WriteLine($"Numarul maxim din secventa este {max}");
            Console.WriteLine($"Numarul minim din secventa este {min}");
        }
    }

}
