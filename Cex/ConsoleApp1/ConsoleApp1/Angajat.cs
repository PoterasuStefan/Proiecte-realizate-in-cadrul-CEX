using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Angajat
    {
        public string Nume { get; set; }
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
}
