using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            Console.WriteLine("Ejemplo Finally");
            try
            {
                string linea;
                int contador = 0;
                string path = @"D:\ProyectoBDprueba\CursoC#13Ene21\Finally\Archivo\tirar.txt";
                //ERROR string path = @"D:\ProyectoBDprueba\CursoC#13Ene21\Finally\Archivo\tirarrr.txt";
                archivo = new System.IO.StreamReader(path);
                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR con la lectura del archivo");

            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("SIEMPRE SE DB cerrar Conexión con el fichero **CERRADA");
            }

        }
    }
}
