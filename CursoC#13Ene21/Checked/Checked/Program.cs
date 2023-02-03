using System;

namespace Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////
            ///Propiedades del proyecto - Compilacion - Boton Avanzadas -
            /// COMPROBAR el desbordamiento y subdesbordamiento aritmetico 
            int edad = ( 55%6);
            Console.WriteLine("HOLA GECS "+edad);
            Console.WriteLine($"HOLA GECS tiene  {edad} años" );

            double temperatura = 34.5;
            int tempMadrid;
            // casting
            tempMadrid = (int)temperatura;
            Console.WriteLine($"temperatura integer {tempMadrid} grados");
            Console.WriteLine("INGRESE PRIMER NÚMERO:  ");
            int numero =int.Parse(Console.ReadLine());    // validar excepción
            Console.WriteLine($"Numero digitado {numero} ***");
            //checked
            //{                // OBLIGAR verificar operacion aritmetica
            //    int num = int.MaxValue;
            //    int res = num + 20;  //overflow
            //    Console.WriteLine(num);
            //    Console.WriteLine(res);
            //}

            //// checked y unchecked solo para Tipos int  y  long..
            //int num = int.MaxValue;
            //int res = checked(num + 20);    //overflow   OBLIGAR   verificar la linea 
            //int res1 = unchecked(num + 20);  //overflow   SALTAR    verificar la linea
            //Console.WriteLine(num);
            //Console.WriteLine(res);
        }
    }
}
////////////////////////////////////////////////////////////////////////////////////////
///  Depurar - Ventanas - Configuracion Excepciones - Common Language Runtime Exceptions