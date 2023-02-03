using System;
using System.Collections.Generic;
using System.Linq;                          /// <summary>
/// Incluir
/// </summary>


namespace Util_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ VIDEO 100");
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // incluir en lista
            Console.WriteLine( "Numeros Pares:");
            List<int> pares = new List<int>();
            foreach(int i in numeros)
            {
                if(i % 2 == 0)
                {
                    pares.Add(i); 
                }
            }
            foreach(int i in pares)
            {
                Console.WriteLine(i);
            }
            // con LINQ
            Console.WriteLine();
            Console.WriteLine("Numeros Pares utilizando LINQ:");
            IEnumerable<int> paresL = from n in numeros where n % 2 == 0 select n;
            foreach (int i in paresL)
            {
                Console.WriteLine(i);
            }
            // Empresa / Empleados con LINQ
            Console.WriteLine();
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            ce.getCEO();
            Console.WriteLine();
            Console.WriteLine("Empleados ORDENADOS X Nombre utilizando LINQ:");
            ce.getEmplOrden();
            Console.WriteLine();
            Console.WriteLine("Empleados CEO ORDENADOS X Nombre utilizando LINQ:");
            ce.getEmplCeo();
            Console.WriteLine();
            Console.WriteLine("Ingrese parametro de ID");
            String entrada = Console.ReadLine();
            // Exception
            try { 
                int entradaId = Convert.ToInt32( entrada);
                Console.WriteLine("Empleados segun PARAMETRO de EMPRESA  ORDENADOS X Nombre utilizando LINQ:");
                ce.getEmplParam(entradaId);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Por favor, Ingrese un ID válido");
            }
        }
    }
}
//////////////////////////////////////////////////////////////
/// LINQ  .NET MICROSOFT – reducir código, Uniformidad, Legible, Integración C#.
// Languaje Integrated Query .NET, C#, VB.NET guardar y consultar datos de 
/// diferentes orígenes de datos.
// Desde .NET FRAMEWORK 3.5 Y C# 3.0
// ColecciónObjetos, XML, SQL BD, Entidades, RecordSET, otras estructuras
// API LINQ  :    CLASES / Interfaz:  I / Enumerable, I / Queryable.
/// 
///



