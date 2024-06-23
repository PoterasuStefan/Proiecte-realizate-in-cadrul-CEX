using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaClase2
{
    internal class Produs
    {
        public string Nume { get; set; }
        public double Pret { get; set; }
        public int Cantitate { get; set; } 
        public Produs(string nume, double pret, int cantitate)
        {
            Nume = nume;
            Pret = pret;
            Cantitate = cantitate;
        }
        public double CalculPretTotal()
        {
            return Pret * Cantitate;
        }
        public override string ToString()
        {
            return $"Nume:{Nume},Pret: {Pret:C}, Cantitate: {Cantitate}";


        }
    }
    class MagazinOnline
    {
        private List<Produs> produse = new List<Produs>();
        public void AdaugaProdus(Produs produs)
        { produse.Add(produs); }
        public double CalculPretTotal()
        {
            double pretTotal = 0;
            foreach (Produs produs in produse)
            {
                pretTotal += produs.CalculPretTotal();

            }
            return pretTotal;

        }
        public void AfiseazaProduse()
        {
            Console.WriteLine("Produse disponibile:");
            foreach (Produs produs in produse)
            {
                Console.WriteLine(produs);
            }
        }
    }
    
}
