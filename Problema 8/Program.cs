using System;

class Program
{
    static int[,] m = new int[2, 2];
    static int[,] rasp = new int[2, 2];
    static int n;
    //Va fi efficienta O(log n^2)
    static void Main()
    {
        Console.Write("Introdu al n lea termen: ");
        if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
        {
            //Matricea la inceput 
            //   |Fn+1  Fn   |
            //   |Fn    Fn-1 |
            m[0, 0] = 1; m[0, 1] = 1;
            m[1, 0] = 1; m[1, 1] = 0;

            //Matricea raspuns = I2
            rasp[0, 0] = 1; rasp[0, 1] = 0;
            rasp[1, 0] = 0; rasp[1, 1] = 1;

            //Ridicam matricea la n
            Ridicare(n);

            //Raspunsul 
            Console.WriteLine(rasp[0, 1]);
        }
        else
        {
            Console.WriteLine("N traba sa fie pozitiv sau mai mic.");
        }
    }

    static void InmultireMatrice(int[,] a, int[,] b)
    {
        int[,] aa = { { a[0, 0], a[0, 1] }, { a[1, 0], a[1, 1] } };
        int[,] bb = { { b[0, 0], b[0, 1] }, { b[1, 0], b[1, 1] } };

        a[0, 0] = (int)(((long)aa[0, 0] * bb[0, 0] + aa[0, 1] * bb[1, 0]));
        a[0, 1] = (int)(((long)aa[0, 0] * bb[0, 1] + aa[0, 1] * bb[1, 1]));
        a[1, 0] = (int)(((long)aa[1, 0] * bb[0, 0] + aa[1, 1] * bb[1, 0]));
        a[1, 1] = (int)(((long)aa[1, 0] * bb[0, 1] + aa[1, 1] * bb[1, 1]));
    }

    static void Ridicare(int n)
    {
        while (n > 0)
        {
            if (n % 2 == 1)
                InmultireMatrice(rasp, m);
            InmultireMatrice(m, m);
            n /= 2;
        }
    }
}
