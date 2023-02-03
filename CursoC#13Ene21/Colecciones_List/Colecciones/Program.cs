using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones.  Video 63");
            List<int> numeros = new List<int>();  //Declara lista
            numeros.Add(5);
            numeros.Add(7);
            numeros.Add(9);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            // almacena un array
            Console.WriteLine("================");
            List<int> collecNumeros = new List<int>();  //Declara lista
            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };
            for (int i=0; i<5; i++)
            {
                collecNumeros.Add(listaNumeros[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(collecNumeros[i]);
            }
            Console.WriteLine("================");
            List<int> collecEle = new List<int>();  //Declara lista
            Console.WriteLine("¿Cuantos elementos ingresan?  ");
            int ele = Int32.Parse(Console.ReadLine());   //Int32.Parse
            Console.WriteLine("================");
            for (int i=0; i<ele; i++)
            {
                collecEle.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("================");
            for (int i = 0; i < collecEle.Count; i++)
            {
                Console.WriteLine(collecEle[i]);
            }
            Console.WriteLine("====================");
            List<int> collec = new List<int>();  //Declara lista
            Console.WriteLine("Ingresar elementos, para salir 0");
            int elem = 1;
            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());
                collec.Add(elem);
            }
            collec.RemoveAt(collec.Count - 1);   // ELIMINAR ULTIMO ELEMENTO
            Console.WriteLine("===FIN...ingreso 0 =============");
            foreach(int e in collec)
            {
                Console.WriteLine(e);
            }
        }
    }
}
///////////////////////////////////////////////////////////////////
/// Colecciones
/// Pertenecen al namespace System.Collection.Generic
/// permite almacenas elementos Genéricos:
/// ordenar
/// añadir
/// elimina
/// buscar
/// ..... Collection ========================
/// List<T>
/// Queue<T>
/// Stack<T>
/// LinkedList<T>
/// HashSet<T>
/// Dictionary<Tkey,Tvalue>
/// SortedList<Tkey,Tvalue>
/// Buscar: collections en Explorador de APi de .NET Framework 4.8
/// 
 /// 