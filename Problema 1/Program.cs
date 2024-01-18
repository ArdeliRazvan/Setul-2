using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere doriti sa aiba sirul ?");
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                int nr;
                nr = Convert.ToInt32(Console.ReadLine());
                if (nr % 2 == 0)
                    contor++;
            }
            Console.WriteLine($"Sunt exact {contor} numere pare");

        }
    }
}
