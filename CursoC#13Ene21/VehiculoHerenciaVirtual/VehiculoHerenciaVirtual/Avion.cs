using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoHerenciaVirtual
{
    class Avion: Vehiculo
    {
        public void Aterrizar()
        {
            Console.WriteLine("ATERRIZANDO");
        }
        public void Despegar()
        {
            Console.WriteLine("DESPEGANDO");
        }
        public override void Conducir()
        {
            //base.Conducir();  // llama método clase padre Vehículo.Conducir
            Console.WriteLine("CONDUCIR AVION");
        }

    }
}
