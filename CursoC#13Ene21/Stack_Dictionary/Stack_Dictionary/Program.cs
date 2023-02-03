using System;
using System.Collections.Generic;

namespace Stack_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack. Video 66");
            Stack<int> Pila = new Stack<int>();
            // Ingresar a pila
            foreach(int num in new int[5] {1,2,3,4,5})
            {
                Pila.Push(num);
            }
            // Recorrer Pila
            Console.WriteLine("Recorrer Pila LIFO ");
            foreach (int num in Pila)
            {
                Console.WriteLine(num);
            }
            //Eliminando Pila
            Console.WriteLine("Eliminar elementos pila LIFO");
            Pila.Pop();
            foreach ( int num in Pila)
            {
                Console.WriteLine(num);
            }
            ////////////////////////////////////////////////////////////
            ///  DICTIONARY
            ///  clave: nombre
            ///  valor: edad
            Dictionary<string, int> edades = new Dictionary<string, int>();
            // Rellenar 
            edades.Add("Ana", 18);
            edades.Add("Bianca", 35);
            edades["Maria"] = 33;
            edades["Antonio"] = 29;
            // Recorrer
            foreach(KeyValuePair<string, int> p in edades)
            {
                Console.WriteLine("Nombre: " + p.Key + " Edad: " + p.Value);
                Console.WriteLine("*******Nombre: {0} Edad: {1}" ,p.Key,p.Value);
            }

        }
    }
}
/////////////////7777/////////////////////////
/// LIFO -- pila de platos.
/// Ingresar con Push()
/// Eliminar Pop()
/// 
////////////////////////////////////////////////////////////
///  DICTIONARY ****    Más recursos
///  CLAVE Y VALOR
///  Add(Tkey,TValue)
///  Tkey:  NO repetir
///  