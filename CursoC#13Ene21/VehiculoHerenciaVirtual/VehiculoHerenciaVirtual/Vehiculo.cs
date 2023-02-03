using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoHerenciaVirtual
{
    class Vehiculo
    {
        public void Arrancar(string sonidoA)
        {
            Console.WriteLine($" ARRANCAR MOTOR: {sonidoA}");
        }
        public void Parar(string sonidoP)
        {
            Console.WriteLine($" PARAR MOTOR: {sonidoP}");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("GENERICO PARA MÉTODO CONDUCIR");
        }

    }
}
///////////////////////////////////////////
/// MÉTODO VIRTUAL ES UN COMPORTAMIENTO COMÚN PARA VEHICULO
/// CREAR VIRTUAL EN CLASE VEHICULO
/// Y SOBREESCRIBIR OVERRIDE EN CLASE AVION Y COCHE
/// SuperClaseCosmica: Object