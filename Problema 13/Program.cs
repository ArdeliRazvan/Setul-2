using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea secventei: ");
        int lung = int.Parse(Console.ReadLine());

        if (lung < 2)
        {
            Console.WriteLine($"Secventa este o secventa crescatoare rotita: true");
            return;
        }

        Console.Write("Introdu elementul 1: ");
        int primulNumar = int.Parse(Console.ReadLine());
        int ultimulNumar = primulNumar;
        int numarCurent = 0;
        bool AvutLocRotire = false;

        for (int i = 1; i < lung; i++)
        {
            Console.Write($"Introdu elementul {i + 1}: ");
            numarCurent = int.Parse(Console.ReadLine());

            if (ultimulNumar > numarCurent)
            {
                AvutLocRotire = true;
            }

            ultimulNumar = numarCurent;
        }

        // Verificăm dacă secvența poate fi ordonată crescător prin rotiri succesive
        if (!AvutLocRotire || (AvutLocRotire && (numarCurent >= primulNumar || numarCurent <= ultimulNumar)))
        {
            Console.WriteLine($"Secventa este o secventa crescatoare rotita: true");
        }
        else
        {
            Console.WriteLine($"Secventa nu este o secventa crescatoare rotita");
        }
    }
}
