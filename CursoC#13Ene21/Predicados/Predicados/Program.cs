using System;
using System.Collections.Generic;

namespace Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Predicados. Video 68");
            List<int> ListaNum = new List<int>();
            ListaNum.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            // declarar delegado predicado
            Predicate<int> ElPredicado = new Predicate<int>(VerificaPar);
            List<int> Pares = ListaNum.FindAll(ElPredicado);
            foreach (int num in Pares)
            {
                Console.WriteLine(num);
            }
            // Delegado en clases
            List<Persona> gente = new List<Persona>();
            Persona objP1 = new Persona();
            objP1.Nombre = "Juanita";
            objP1.Edad = 1;
            Persona objP2 = new Persona();
            objP2.Nombre = "Nika";
            objP2.Edad = 8;
            Persona objP3 = new Persona();
            objP3.Nombre = "Santiago";
            objP3.Edad = 8;
            gente.AddRange(new Persona[] { objP1, objP2, objP3 });
            Predicate<Persona> Prdicado = new Predicate<Persona>(ExisteJuan);
            bool existe = gente.Exists(Prdicado);
            if (existe) Console.WriteLine("SI existe Juan");
            else Console.WriteLine("No hay nadie Juan");
            Predicate<Persona> Prdicado1 = new Predicate<Persona>(ExisteMayEdad);
            bool existe1 = gente.Exists(Prdicado1);
            if (existe1) Console.WriteLine("SI existe Mayores de edad");
            else Console.WriteLine("No hay nadie Mayor de edad");
        }
        // NO instancia-Objeto
        static bool VerificaPar(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
        // Delegado en clases static xq llama desde Main.
        static bool ExisteJuan(Persona persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
        static bool ExisteMayEdad(Persona persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
        }

        // Delegado en clases
        class Persona
        {
            private string nombre;
            private int edad;
            // acciones Rapidas -- Encapsular campo y usasr propiedad
            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
        }
    }
}
/////////////////////////////////////////////////////////
/// funciones tipo boolean
/// true, false
/// Predicate<T> NombrePredicado = new Predicate<T>(funcionDelegado);
/// trabajar clases
/// 