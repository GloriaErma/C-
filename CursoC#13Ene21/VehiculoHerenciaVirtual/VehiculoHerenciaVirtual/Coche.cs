using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoHerenciaVirtual
{
    class Coche: Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("ACELERANDO");
        }
        public void Frenando()
        {
            Console.WriteLine("FRENAR");
        }
        public override void Conducir()
        {
            //base.Conducir();  // llama método clase padre Vehículo.Conducir
            Console.WriteLine("CONDUCIR COCHE");
        }
    }
}
