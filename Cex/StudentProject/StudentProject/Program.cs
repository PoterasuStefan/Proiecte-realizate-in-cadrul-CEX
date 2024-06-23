using System;
class Student
{
    private string nume;
    private int nota;
    private string codStudent;

    public Student (string nume, int nota, string codStudent)
    {
        this.nume = nume;
        SetNota(nota);
        this.codStudent = codStudent;

    }
    public string GetNume()
    {
        return nume;
    }
    public int GetNota()
    {
        return nota;
    }
    public void SetNota(int nouaNota)
    {
        if (nouaNota>=0 && nouaNota<=10) {
        nota=nouaNota;
        }
        else
        {
            Console.WriteLine("Nota invalida. Introduceti o nota intre 0 si 10.");
        }
    }
    public string GetCodStudent()
    {
        return codStudent;
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student("John Doe", 8, "123ABC");

        Console.WriteLine($"Numele studentului: {student.GetNume()}");
        Console.WriteLine($"Nota studentului: {student.GetNota()}");
        Console.WriteLine($"Codul studentului: {student.GetCodStudent()}");
        student.SetNota(11);
        Console.ReadKey();


    }
}