// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static double CalculMedie(List<double>numere)
    {
        if(numere.Count == 0)
        {
            throw new InvalidOperationException("Lista de numere e goala.");

        }
        double medie = numere.Average();
        return medie;

    }
    static void Main ()
    {
        List<double> numere = new List<double> { 12.5, 6.3, 8.9, 10.2, 15.7 };
        try
        {
            double medie = CalculMedie(numere);
            Console.WriteLine($"Media nr e: {medie}");
        }
        catch ( InvalidOperationException)
        {
            Console.WriteLine("Invalid" );
        }
        Console.ReadKey();
    }
}
