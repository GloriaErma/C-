using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar al bucle SI/NO ??");
            string res = Console.ReadLine();
            while (res != "NO")
            {
                Console.WriteLine("...Ejecutandose bucle");
                Console.WriteLine("...Ingrese Nombre");
                string nom = Console.ReadLine();
                Console.WriteLine($"{nom} Para salir del bucle responda 'NO' a la pregunta");
                Console.WriteLine("Deseas repetir bucle SI/NO ??");
                res = Console.ReadLine();
            }
            Console.WriteLine("...Termino ejecución bucle...");
            ///////////////////////////////////////////7
            /// adivinar el numero aleatorio
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            Console.WriteLine(aleatorio);
            int Mio = 101;
            int intentos = 0;
            Console.WriteLine("Ingrese numero entre 0  y 100");
            // Eejcuta el bucle mientras se cumple la condicion
            while (aleatorio != Mio)
            {
                intentos++;
                Mio = int.Parse(Console.ReadLine());
                //int mes = Int32.Parse(Console.ReadLine());
                if (Mio > aleatorio) Console.WriteLine("Aleatorio es menor");
                if (Mio < aleatorio) Console.WriteLine("Aleatorio es mayor");
            }
            Console.WriteLine($"Llegaste al aleatorio {aleatorio} en {intentos} ");
        }
    }
}
