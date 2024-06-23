// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

class Program
{
    static void Main()
    {
        Companie companie = new Companie();
        companie.AdaugaAngajat(new Angajat("Stefan", 1, 25));
        companie.AdaugaAngajat(new Angajat("Ion", 2, 45));

        companie.AfiseazaAngajati();
        companie.StergeAngajat(2);
        companie.AfiseazaAngajati();
        Console.ReadKey();
    }
}