using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti lungimea secventei:");
        int lungimeSecventa = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti numarul cautat:");
        int numarCautat = int.Parse(Console.ReadLine());

        int pozitie = GasestePozitie(numarCautat, lungimeSecventa);

        if (pozitie != -1)
        {
            Console.WriteLine($"Numarul {numarCautat} se afla pe pozitia {pozitie} in secventa.");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }

    static int GasestePozitie(int numarCautat, int lungimeSecventa)
    {
        for (int i = 0; i < lungimeSecventa; i++)
        {
            Console.WriteLine($"Introduceti numarul de pe pozitia {i}:");
            int numar = int.Parse(Console.ReadLine());

            if (numar == numarCautat)
            {
                return i;
            }
        }
        return -1;
   }
}
