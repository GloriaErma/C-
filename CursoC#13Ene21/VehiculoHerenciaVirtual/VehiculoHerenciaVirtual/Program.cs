using System;

namespace VehiculoHerenciaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Herencia Vehiculo: coche y avion- video 47");
            Console.WriteLine("probando AVION");
            Avion objAvion1 = new Avion();
            objAvion1.Arrancar("shuuuuuuuuuuuuuuuuu");
            objAvion1.Despegar();
            objAvion1.Conducir();   /// cada clase es diferente
            objAvion1.Aterrizar();
            objAvion1.Parar("choccccccccccc");
            Console.WriteLine();
            Console.WriteLine("probando COCHE");
            Coche objCoche1 = new Coche();
            objCoche1.Arrancar("rrrrrruuuuuuuuuuunnnnnn");
            objCoche1.Acelerar();
            objCoche1.Conducir();   /// cada clase es diferente
            objCoche1.Frenando();
            objCoche1.Parar("IIIIIIiiiiiiiiii");
            Console.WriteLine();
            Console.WriteLine("POLIMORFISMO en ACCIÓN");
            Vehiculo objVehiculo1 = new Vehiculo();   // SuperClaseHerencia
            //////////////////////////////////////////////////////////////
            Vehiculo objVehiculo2 = objCoche1;   // SuperClaseHerencia
            // guarda un objecto coche en un objeto vehiculo.
            objVehiculo2.Conducir();
            objVehiculo2 = objAvion1;
            objVehiculo2.Conducir();
        }
    }
}
