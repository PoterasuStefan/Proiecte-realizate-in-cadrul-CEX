using System;
using System.Collections.Generic;
using System.Net.Security;

class Actiune
{
    public string Nume { get; set; }
    public double Pret { get; set; }
    public int Cantitate { get; set; }
    public Actiune(string nume, double pret, int cantitate)
    {
        Nume = nume;
        Pret = pret;
        Cantitate = cantitate;

    }
}
class Portofoliu
{
    private List <Actiune> actiuni = new List<Actiune>();
    
    public void AdaugaActiune(string nume, double pret, int cantitate)
    {
        Actiune actiune = new Actiune(nume, pret, cantitate);
        actiuni.Add(actiune);
    }
    public void StergeActiune(string nume)
    {
        Actiune actiuneDeSters = actiuni.Find(a=>a.Nume == nume);
        if (actiuneDeSters !=null)
        {
            actiuni.Remove(actiuneDeSters);
        }
    }
    public void AfiseazaPortofoliu()
    {
        Console.WriteLine("Portofoliu:");
        foreach (var actiune in actiuni)
        {
            Console.WriteLine($"Nume: {actiune.Nume},Pret:{actiune.Pret:C},Cantitate:{actiune.Cantitate}");
        }
    }
}
class Program
{
    static void Main()
    {
        Portofoliu portofoliu = new Portofoliu();
        portofoliu.AdaugaActiune("APPLE", 120.0, 10);
        portofoliu.AdaugaActiune("GOOGLE", 1120.0, 4);
        portofoliu.AdaugaActiune("TESLA", 420.0, 12);

        portofoliu.AfiseazaPortofoliu();
        Console.WriteLine("\nStergere actiune APPLE");
        portofoliu.StergeActiune("APPLE");

        portofoliu.AfiseazaPortofoliu();
        Console.ReadKey();


    }
}