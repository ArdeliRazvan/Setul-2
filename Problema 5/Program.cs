using System;

class Program
{
    static void Main()
    {
        Console.Write("Lungimea \"vectorului\" este de :" );
        int lungime = int.Parse(Console.ReadLine());
     
            int rezultat = verifica_numere_poz(lungime);
            Console.WriteLine($"Cate numere sunt egale cu pozitia: {rezultat}");
        
       
        
    }

    static int verifica_numere_poz(int lungime)
    {
        int k = 0;

        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"Introdu un numar pe pozitia {i}: ");
            int number = int.Parse(Console.ReadLine());

            if (number == i)
            {
                k++;
            }
        }

        return k;
    }
}
