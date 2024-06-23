using System;
class ContBancar
{
    private decimal sold;
    private string numeTitular;

    public ContBancar(string numeTitular, decimal soldInitial   )
    {
        this.numeTitular = numeTitular;
        this.sold = soldInitial;
    }
    public decimal GetSold()
    {
        return sold;
    }

    public string GetNumeTitular()
    {
        return numeTitular;
    }
    public void Depune (decimal suma)
    {
        if (suma > 0)
        {
            sold += suma;
            Console.WriteLine($"Depunere reusita. Sold actual: {sold}");
        }
        else
        {
            Console.WriteLine("Suma de depus trebuie sa fie mai mare decat zero.");

        }
    }
    public void Retrage(decimal suma)
    {
        if (suma > 0 && suma <= sold)
        {
            sold -= suma;
            Console.WriteLine($"Retragere reusita. Soldul actual: {sold}");
        }
        else
        {
            Console.WriteLine("Suma invalida sau insuficient fonduri.");
        }
    }
}
class Program
{
    static void Main()
    {
        ContBancar cont = new ContBancar("John Doe", 1000.0m);

        Console.WriteLine($"Titularul contului: {cont.GetNumeTitular()}");
        Console.WriteLine($"Soldul contului: {cont.GetSold()}");

        cont.Depune(500.0m);
        cont.Retrage(200.0m);
        Console.ReadKey();

    }
}


