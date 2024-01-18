using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu dimensiunea secventei: ");
        int n = int.Parse(Console.ReadLine());
        int numarCurent, numarPrecedent;
        bool esteMonotona = true;

       
        Console.Write("Introdu primul numar: ");
        numarCurent = int.Parse(Console.ReadLine());
       
        for (int i = 1; i < n; i++)
        {
            Console.Write($"Introdu numarul {i + 1}: ");
            numarPrecedent = int.Parse(Console.ReadLine());
  
            if (numarCurent > numarPrecedent && esteMonotona)
            {
             
                numarPrecedent = numarCurent;
            }
            else if (numarCurent < numarPrecedent && esteMonotona)
            {
              
                numarPrecedent = numarCurent;
            }
            else
            {
               
                esteMonotona = false;
                break;
            }
        }

       
        if (esteMonotona)
        {
            Console.WriteLine("Secventa este monotona.");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }
    }
}
