using System;
using System.IO;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Destructores video 59 ");
            ManejoArchivos objeArch1 = new ManejoArchivos();
            objeArch1.mensaje();

        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        public ManejoArchivos()
        {
            // Abrir conexión
            archivo = new StreamReader(@"D:\GECS-DEV\ProyectoBDprueba\CursoC#13Ene21\Destructor\texto.txt");
            while( (linea = archivo.ReadLine()) != null )
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void mensaje()
        {
            Console.WriteLine("El archivo tiene {0} lineas", contador );
        }
        // destructor alt  
        // Codigo q ejecuta el Garbaje Collection, despues de eliminar el recurso
        ~ManejoArchivos()
        {
            archivo.Close();
        }
        
    }
}
////////////////////////////////
/// Destrutor
/// Garbage Collection..
/// Clase Stack    Heap
/// crear objeto Empleado objemp = new Empleado();
/// new Empleado, se RESERVA ESPACIO EN Heap PARA ALMACENAR EL OBJETO.
/// Empleado objemp, se RESERVA ESPACIO EN STACK, para referenca. por cada objeto.
/// ////
/// saturación memoria Heap, se crea objeto o referencia, con el recolector de basura
/// se detecta y los elimina.
/// ///////// 
///  C# el Garbage Collection es automatico.
///  El destructor, ejecuta codigo a la destruccón de un recurso en mria.
///  como: conexión BBDD, cierres strems en ficheros. eliminaobjetos de coleccion.
///  ///////////////
///  Destructores solo usan en clases 
///  cada clase solo posee 1 destructor.
///  Destructores NO se heredan NI sobrecargan
///  Dstructors NO se llaman. son invocados automaticamente.
///  Destructores NO tienen modificadores acceso Ni parametros.
///  
/// ///
