using System;
using System.Collections.Generic;

class Angajat
{
    public virtual double CalculSalariu()
    {
        return 0.0;
    }
}

class Programator : Angajat
{
    public override double CalculSalariu()
    {
        return 50000.0 + 20000.0;
    }
}

class Manager : Angajat
{
    public override double CalculSalariu()
    {
        return 60000.0 + 30000.0;
    }
}
class Program
{
    static void Main()
    {
        Programator programator = new Programator(); ;
        Manager manager = new Manager();

        List<Angajat> angajati = new List<Angajat>()
        {
            programator, manager
        };
        double sumaSalarii = 0.0;
        foreach (Angajat angajat in angajati)
        {
            sumaSalarii += angajat.CalculSalariu();

        }
        Console.WriteLine($"Suma totala a salariilor: {sumaSalarii}");
    }
}