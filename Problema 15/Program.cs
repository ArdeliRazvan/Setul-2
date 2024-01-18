using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea secventei: ");
        int lung = int.Parse(Console.ReadLine());

        if (lung < 3)
        {
            Console.WriteLine("Secventa este bitonica: false");
            return;
        }

        Console.Write("Introdu elementul 1: ");
        int primulNumar = int.Parse(Console.ReadLine());
        int numarCurent = 0;
        bool aInceputCrescator = false;
        bool aInceputDescrescator = false;

        for (int i = 1; i < lung; i++)
        {
            Console.Write($"Introdu elementul {i + 1}: ");
            numarCurent = int.Parse(Console.ReadLine());

            if (numarCurent > primulNumar)
            {
                aInceputCrescator = true;
            }
            else if (numarCurent < primulNumar)
            {
                aInceputDescrescator = true;
            }

            // Verificăm dacă ambele condiții pentru o secvență bitonică sunt îndeplinite
            if (aInceputCrescator && aInceputDescrescator)
            {
                Console.WriteLine("Secventa este bitonica: true");
                return;
            }

            primulNumar = numarCurent;
        }

        Console.WriteLine("Secventa este bitonica: false");
    }
}
