using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformism
{
    class Figura
    {
        public virtual double CalculArie()
        {
            return 0.0;
        }
    }
    class Cerc : Figura
    {
        public double Raza { get; set; }
        public Cerc(double raza)
        {
            Raza = raza;
        }
        public override double CalculArie()
        {
            return Math.PI * Raza * Raza;
        }
    }
    class Patrat : Figura
    {
        public double Latura { get; set; }
        public Patrat(double latura)
        {
            Latura = latura;
        }
        public override double CalculArie()
        {
            return Latura * Latura;
        }
    }
    class Program
    {
        static void Main()
        {
            Cerc cerc = new Cerc(5.0);
            Patrat patrat = new Patrat(4.0);

            Console.WriteLine($"Aria cercului: {cerc.CalculArie()}");
            Console.WriteLine($"Aria patratului: {patrat.CalculArie()}");
            Console.ReadKey();
        }
    }


}
