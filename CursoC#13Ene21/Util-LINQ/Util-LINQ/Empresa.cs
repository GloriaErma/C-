using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;                          /// <summary>
/// Incluir
/// </summary>

namespace Util_LINQ
{
    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
   
        public void getDatos()
        {
            Console.WriteLine("Empresa {0} con ID {1}", Nombre, Id);
        }

    }
}
