using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 10;
            //NO se ejecuta nunca
            while (z < 10)
            {
                Console.WriteLine("bucle while Numero z" + z);
                z++;
            }
            //SI se ejecuta la primera vez por el do{}
            do
            {
                Console.WriteLine("bucle Do-while Numero z es: " + z);
                z++;
            } while (z < 10) ;
            // al cambiar la condicion de z<15---SI se ejecuta la primera vez por el do{}
            do
            {
                Console.WriteLine("bucle Do-while Numero z es: " + z);
                z++;
            } while (z < 15);
            ///////////////////////////////////////////////////////////////////
            //////////traer de proyecto While//////////////////////////////////
            /// adivinar el numero aleatorio
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            Console.WriteLine(aleatorio);
            //int Mio = 101;
            int Mio;
            int intentos = 0;
            Console.WriteLine("Ingrese numero entre 0  y 100");
            // Eejcuta el bucle mientras se cumple la condicion
            do
            {
                intentos++;

                try
                {
                    Mio = int.Parse(Console.ReadLine());   //////////////Excepc, puede quedar SIN inicializarse
                }
                //////// DB IR PRIMERO LA EXCEPCION PARTICULAR QUE LA GENERAL 
                //catch (FormatException ex)                 //////// DB IR PRIMERO LA EXCEPCION PARTICULAR QUE LA GENERAL        
                //{
                //    Console.WriteLine("Solo se reciben numeros");
                //    Mio = 0;
                //}
                catch (Exception ex)  when (ex.GetType()!=typeof(FormatException)) 
                {
                    Console.WriteLine("ERROR, toma el valor 0");
                    //Console.WriteLine(ex.Message);
                    Mio = 0;                                //////////////Excepc, puede quedar SIN inicializarse
                }
                ////// YA queda cubierto el ERROR CON EXCEPCION GENERAL.DB IR ANTES
                catch (FormatException ex)                   //////// YA queda cubierto el ERROR CON EXCEPCION GENERAL.DB IR ANTES
                {
                    Console.WriteLine("Solo se reciben numeros");
                    Mio = 0;
                }

                //int mes = Int32.Parse(Console.ReadLine());
                if (Mio > aleatorio) Console.WriteLine("Aleatorio es menor");
                if (Mio < aleatorio) Console.WriteLine("Aleatorio es mayor");
            } while (aleatorio != Mio) ;
            Console.WriteLine($"Llegaste al aleatorio {aleatorio} en {intentos} ");
            Console.WriteLine(":::::::::::::::::FIN PROGRAM:::::::::::::::::::: ");
        }
    }
}
/////////////////////////////////////////
/// Excepciones   try...catch
///  Errores en tiempo de ejecución
///  memoria corrupta
///  desbordamiento de pila
///  sectores de disco defectuosos
///  conexion a bd interrumpidas
///  acceso ficheros inexistentes.
///  Jerarquia Excepcion-- SystemException-- FormatException y OverflowExcepcion.
///   
//try
//{
//    Mio = int.Parse(Console.ReadLine());   //////////////Excepc, puede quedar SIN inicio
//}
//                catch (FormatException ex)      // 
//{
//    Console.WriteLine("Ingrese valor numérico válido, toma el valor 0");
//    Mio = 0;                                //////////////Excepc, puede quedar SIN inicio
//}
//catch (OverflowException ex)    // 
//{
//    Console.WriteLine("Ingrese valor numérico menor a 100-- menor, toma el valor 0");
//    Mio = 0;                                //////////////Excepc, puede quedar SIN inicio
//}


//////// DB IR PRIMERO LA EXCEPCION PARTICULAR QUE LA GENERAL 
//catch (FormatException ex)                 //////// DB IR PRIMERO LA EXCEPCION PARTICULAR QUE LA GENERAL        
//{
//    Console.WriteLine("SOlo se reciben numeros");
//    Mio = 0;
//}
//catch (Exception ex)      //  catch(Exception ex)  === catch  *****tratamiento GENERAL
//{
//    Console.WriteLine("ERROR, toma el valor 0");
//    //Console.WriteLine(ex.Message);
//    Mio = 0;                                //////////////Excepc, puede quedar SIN inicializarse
//}
//////// YA queda cubierto el ERROR CON EXCEPCION GENERAL.DB IR ANTES
//catch (FormatException ex)                   //////// YA queda cubierto el ERROR CON EXCEPCION GENERAL.DB IR ANTES
//{
//    Console.WriteLine("SOlo se reciben numeros");
//    Mio = 0;
//}