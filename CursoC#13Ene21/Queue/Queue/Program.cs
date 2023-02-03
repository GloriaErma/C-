using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue.  Video 65 ");
            Queue<int> Cola = new Queue<int>();
            // Ingresar elementos
            foreach( int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                Cola.Enqueue(num);
            }
            // Recorriendo FIFO
            Console.WriteLine("Recorrer Queue");
            foreach (int num in Cola){
                Console.WriteLine(num);
            }
            //Eliminando
            Console.WriteLine("Eliminando primero Queue");
            Cola.Dequeue();
            foreach (int num in Cola)
            {
                Console.WriteLine(num);
            }


        }
    }
}
/////////////////////////////////////////////////////
/// Queue
/// FIFO. procesos secuenciales. Control de procesos.
/// 