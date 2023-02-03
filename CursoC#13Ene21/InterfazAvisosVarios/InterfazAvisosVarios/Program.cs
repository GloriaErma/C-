using System;

namespace InterfazAvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejmplo Interfaz- Avisos Varios");
            AvisoTrafico objAviso1 = new AvisoTrafico(); // contructor X defecto;
            objAviso1.MostrarAviso();
            AvisoTrafico objAviso2 = new AvisoTrafico("Provincia Madrid", "Sanción Velocidad", "25-Ene-21");
            objAviso2.MostrarAviso();
            Console.WriteLine(objAviso2.GetFecha());


        }
    }
}
