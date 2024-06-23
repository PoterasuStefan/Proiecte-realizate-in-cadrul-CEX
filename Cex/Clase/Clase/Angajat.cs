using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEXprobleme5
{
    internal class Angajat
    {
        public string Nume {  get; set; }
        public int Id { get; set; }
        public double Salariu { get; set; }
        public Angajat(string nume, int id, double salariu)
        {
            Nume = nume;
            Id = id;
            Salariu = salariu;
        }

        public override string ToString()
        {

            return $"ID: {Id}, Nume: {Nume}, Salariu: {Salariu}";


        }
    }
    class Companie
    {
        private List<Angajat> angajati = new List<Angajat>();
        public void AdaugaAngajat(Angajat angajat)
        {
            angajati.Add(angajat);
        }
        public void StergeAngajat(int id)
        {
            Angajat angajat = angajati.Find(a => a.Id == id);
            if (angajat != null)
            {
                angajati.Remove(angajat); 

            }
        }
        public void AfiseazaAngajati()
        {
            Console.WriteLine("Lista angajatilor:");
            foreach (Angajat angajat in angajati)
            {
                Console.WriteLine(angajat);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Companie companie = new Companie();

            //adaugare angajati 
            companie.AdaugaAngajat(new Angajat("John doe", 1, 500000));
            companie.AdaugaAngajat(new Angajat("Stefan Poterasu", 2, 00000));

        }
    }
}
