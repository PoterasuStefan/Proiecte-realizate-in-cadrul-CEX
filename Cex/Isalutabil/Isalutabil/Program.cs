using System;

interface Isalutabil
{
    void Saluta();

}

class Student : Isalutabil 
{
    public void Saluta()
    {
        Console.WriteLine("Buna ziua!");
    }
}

class Profesor : Isalutabil
{
    public void Saluta()
    {
        Console.WriteLine("Buna!");
    }
} 


class Program
{
    static void Main()
    {
        Student student = new Student();
        Profesor profesor = new Profesor();
        Console.WriteLine("Studentul spune:");
        student.Saluta();
        Console.WriteLine("Profesorul spune:");
        profesor.Saluta();
        Console.ReadKey();
    }
}