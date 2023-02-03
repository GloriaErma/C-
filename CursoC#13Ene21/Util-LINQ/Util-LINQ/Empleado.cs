using System;
using System.Collections.Generic;
using System.Text;

namespace Util_LINQ
{
    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        // Clave Foranea
        public int EmpresaID { get; set; }


        public void getDatos()
        {
            Console.WriteLine("Empleado {0} con ID {1}, Cargo {2} con Salario {3}," +
                " pertenece a Empresa: {4} ", Nombre, Id, Cargo, Salario, EmpresaID);

        }
    }
}
