using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList. Video 64 ");
            LinkedList<int> numeros = new LinkedList<int>();
            foreach(int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.AddFirst(num);  //el ultimo lo coloca de primeras
            }
            Console.WriteLine("=====AddFirst================");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            LinkedList<int> numeros1 = new LinkedList<int>();
            foreach (int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros1.AddLast(num);  //el ultimo lo coloca de ultimas
            }
            Console.WriteLine("=====AddLast=================");
            foreach (int num in numeros1)
            {
                Console.WriteLine(num);
            }
            LinkedList<int> numeros2 = new LinkedList<int>();
            foreach (int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros2.AddLast(num);  //el ultimo lo coloca de ultimas
            }
            Console.WriteLine("========LinkedListNode==============");
            for(LinkedListNode<int> nodo=numeros2.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
            numeros2.Remove(6);
            Console.WriteLine("========Remove(6)==============");
            for (LinkedListNode<int> nodo = numeros2.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(99);
            numeros2.AddFirst(nodoImportante);
            Console.WriteLine("========Add Node First 99==============");
            for (LinkedListNode<int> nodo = numeros2.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }

    }
}
//////////////////////////
/// listas enlazadas
/// eficiencia 
/// List: almacena posición junta adyacente, pegada.
///       eliminar elemento queda posición vacia.
///       se reacomoda la lista para estar juntos.
///       se desplaza las posiciones que se deban.
/// LinkedList: formadas X NODOS, o ENLACES en polos
///       conectados al ANTERIOR y al SIGUIENTE DATO.
///       NO necesita almacenarse en posición adyacente.
/// El primer elemento LinkedList, tiene el polo anterior apuntando NULO.
/// El último elemento LinkedList, tiene el polo siguiente apuntando NULO.
/// Al ELIMINAR SE actualizan los ENLACES de NODOS.
/// 