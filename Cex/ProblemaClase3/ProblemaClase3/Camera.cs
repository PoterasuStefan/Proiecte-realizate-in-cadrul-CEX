using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProblemaClase3
{
    internal class Camera
    {
        public int NumarCamera { get;set; } 
        public double PretPeNoapte {  get;set; }    
        public int Capacitate { get;set; }  
        public bool EsteDisponibila { get;set; }    

        public Camera (int numarCamera, int capacitate, double pretPeNoapte)
        {
            NumarCamera = numarCamera;
            Capacitate = capacitate;
            PretPeNoapte = pretPeNoapte;
            EsteDisponibila=true;
        }
        public void RezervaCamera()
        {
            if (EsteDisponibila)
            {
                EsteDisponibila = false;
                Console.Write($"Camera {NumarCamera} a fost rezervata.");

            }
            else Console.WriteLine($"Camera{NumarCamera} nu e disponibila.");

        }

    }
    public void ElibereazaCamera()
    {
        EsteDisponibila = true;
        Console.WriteLine($"Camera {NumarCamera} a fost eliberata.");

    }
    public override string ToString()
    {
        return $"Numar camera: {NumarCamera}, Capacitate: {Capacitate}, Pret/noapte: {PretPeNoapte:C},Disponibila:{EsteDisponibila}";
    }

}
class Rezervare
{
    public int NumarRezervare { get; set;}
    public DateTime DataCheckIn { get; set;}
    public DateTime DataCheckOut { get; set;}   
    public int NumarCameraRezervata { get; set;}
    public int NumarPersoane { get; set; }
    public Rezervare (int numarRezervare, DateTime, dataCheckIn, DateTime dataCheckOut, int numarCameraRezervata, int numarPersoane)
        {
        NumarRezervare = numarRezervare;
        DataCheckIn = dataCheckIn;
        DataCheckOut = dataCheckOut;
