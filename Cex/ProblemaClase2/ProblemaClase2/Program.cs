// See https://aka.ms/new-console-template for more information
using ProblemaClase2;

class Program
{
   
        static void Main()
        {
            MagazinOnline magazin = new MagazinOnline();
            magazin.AdaugaProdus(new Produs("Laptop", 2500, 3));
            magazin.AdaugaProdus(new Produs("Telefon", 800, 5));

            magazin.AfiseazaProduse();
            double pretTotal = magazin.CalculPretTotal();
            Console.WriteLine($"Pretul total al produselor din magazin: {pretTotal:C}");
            Console.ReadKey();
        }

    
}
