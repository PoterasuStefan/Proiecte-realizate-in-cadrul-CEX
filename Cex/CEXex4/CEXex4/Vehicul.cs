using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEXex4
{
    class Vehicul
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public double Pret { get; set; }

        public Vehicul(string marca, string model, int anFabricatie, double pret)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            Pret = pret;

        }
        public void AfiseazaDetalii()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"An de fabricatie: {AnFabricatie}");
            Console.WriteLine($"Pret: {Pret: C}");

        }
    }

        class Masina : Vehicul

        {
            public int NumarUsi { get; set; }
            public Masina(string marca, string model, int anFabricatie, double pret, int numarUsi)
                : base(marca, model, anFabricatie, pret)
            {
                NumarUsi = numarUsi;

            }
            public void AfiseazaDetaliiMasina()
            {
                AfiseazaDetalii();
                Console.WriteLine($"Numar de usi: {NumarUsi}");
            }
        }
        class Motocicleta : Vehicul
        {
            public string TipMotor { get; set; }
            public Motocicleta(string marca, string model, int anFabricatie, double pret, string timpMotor)
                : base(marca, model, anFabricatie, pret)
            {
                TipMotor = TipMotor;
            }
            public void AfiseazaDetaliiMotocicleta()
            {
                AfiseazaDetalii();
                Console.WriteLine($"Tip motor: {TipMotor}");

            }

        }
        class Camion : Vehicul
        {
            public double TonajMaxim { get; set; }
            public Camion(string marca, string model, int anFabricatie, double pret, double tonajMaxim)
                : base(marca, model, anFabricatie, pret)
            {
                TonajMaxim = tonajMaxim;
            }
            public void AfiseazaDetaliiCamion()
            {
                AfiseazaDetalii();
                Console.WriteLine($"Tonaj maxim: {TonajMaxim} tone");
            }
        }
        class Program
        {
            static void Main()
            {
                Masina masina = new Masina("Ford", "Focus", 2022, 250000.0, 4);
                Motocicleta motocicleta = new Motocicleta("Harley-Davidson", "Sportster", 2021, 12000.0, "V-Twin");
                Camion camion = new Camion("Volvo", "FH16", 2020, 10000.0, 40.0);

                Console.WriteLine("Detalii Masina:");
                masina.AfiseazaDetaliiMasina();

                Console.WriteLine("\nDetalii Motocicleta:");
                motocicleta.AfiseazaDetaliiMotocicleta();

                Console.WriteLine("\nDetalii Camion:");
                camion.AfiseazaDetaliiCamion();
                Console.ReadKey();

            }
        }
    
}

