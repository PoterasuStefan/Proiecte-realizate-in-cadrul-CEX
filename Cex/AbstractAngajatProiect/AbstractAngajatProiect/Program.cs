using System;
public abstract class Angajat
{
    public string Nume {  get; set; }
    public decimal Salariu { get; set; }
    public string Departament {  get; set; }
    public Angajat (string nume, decimal salariu, string departament)
    {
        Nume = nume;
        Salariu = salariu;
        Departament = departament;
    }
    public abstract void AfiseazaDetalii();
}
public class Programator : Angajat
{
    public string LimbajDeProgramare { get; set; }
    public Programator(string nume, decimal salariu, string departament, string limbajDeProgramare)
    : base(nume, salariu, departament)
    {
        LimbajDeProgramare = limbajDeProgramare;
    }
    public override void AfiseazaDetalii()
    {
        Console.WriteLine($"Programator: {Nume}, Salariu: {Salariu}, Departament: {Departament}, Limbaj de Programare: {LimbajDeProgramare}");

    }
}
public class Manager : Angajat
{
    // Atribut specific managerilor
    public int NivelExperienta { get; set; }

    // Constructor pentru manageri
    public Manager(string nume, decimal salariu, string departament, int nivelExperienta)
        : base(nume, salariu, departament)
    {
        NivelExperienta = nivelExperienta;
    }

    // Implementarea metodei abstracte
    public override void AfiseazaDetalii()
    {
        Console.WriteLine($"Manager: {Nume}, Salariu: {Salariu}, Departament: {Departament}, Nivel de Experiență: {NivelExperienta}");
    }
}

// Clasa pentru vânzători
public class Vanzator : Angajat
{
    // Atribut specific vânzătorilor
    public int NumarVanzari { get; set; }

    // Constructor pentru vânzători
    public Vanzator(string nume, decimal salariu, string departament, int numarVanzari)
        : base(nume, salariu, departament)
    {
        NumarVanzari = numarVanzari;
    }

    // Implementarea metodei abstracte
    public override void AfiseazaDetalii()
    {
        Console.WriteLine($"Vânzător: {Nume}, Salariu: {Salariu}, Departament: {Departament}, Număr de Vânzări: {NumarVanzari}");
    }
}

// Exemplu de utilizare
class Program
{
    static void Main()
    {
        // Creare programator
        Angajat programator = new Programator("John Doe", 5000, "IT", "C#");

        // Afisare informatii programator
        programator.AfiseazaDetalii();

        // Creare manager
        Angajat manager = new Manager("Jane Doe", 8000, "Management", 5);

        // Afisare informatii manager
        manager.AfiseazaDetalii();

        // Creare vanzator
        Angajat vanzator = new Vanzator("Alex Smith", 3000, "Vânzări", 100);

        // Afisare informatii vanzator
        vanzator.AfiseazaDetalii();
        Console.ReadKey();
    }
}
