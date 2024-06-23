using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Companie
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
}
