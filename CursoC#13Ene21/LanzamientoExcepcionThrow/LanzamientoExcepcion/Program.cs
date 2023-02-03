using System;

namespace LanzamientoExcepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Numero de mes:::");
            int num = int.Parse(Console.ReadLine());
            // se obliga a controlar excepcion
            try
            {
                Console.WriteLine(NombreMes(num));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception valores de 1 a 12  :" + ex.Message);
            }
            // finally siempre ejecuta logica, util para: BD y ficheros externos
            // liberar recursos cuando se deja de utilizar BD




        }
        //////////////////////////////
        ///  .net framework library
        ///  System Espacio de nombres
        ///  https://docs.microsoft.com/es-es/dotnet/api/system?view=net-5.0
        ///  /////////////////////////
        public static string NombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    ////return "Mes NO existe"; throw ******LANZAR OBJETO Excepcion **new contructor class
                    throw new ArgumentOutOfRangeException();
            }

        }
    }
}
