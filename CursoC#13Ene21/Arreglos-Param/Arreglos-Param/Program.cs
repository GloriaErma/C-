using System;

namespace Arreglos_Param
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            // video 40 recibe array
            Console.WriteLine("Arreglo-parametros");
            int[] numeros = new int[4];
            numeros[0] = 0;
            numeros[1] = 1;
            numeros[2] = 2;
            numeros[3] = 3;

            Procesar(numeros);
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            #endregion
            /////////////////////////////////////////////////////
            // video 40 devuelve array
            int[] arrayElementos = Leer();
            Console.WriteLine(" Imprimiendo desde Main");
            foreach (int i in arrayElementos) Console.WriteLine(i);


        }
        //Método static de clase, solo se trabaja con una clase program
        /// NO trabaja con referencias a objetos, xq NO estan creados,
        /// a parte de la q estamos db ser .
        /// 
        /// SI intenta llamar a un método q NO es static, desde el método Main
        /// sin contruir instancia-objeto NO permite.
        #region
        // video 40 recibe array
        static void Procesar(int[] arreglo)  // void NO devuelve NADA
        {
            // recorre para mostrarlo NO para modificarlo
            //foreach (int i in arreglo)
            //{
            //    Console.WriteLine(i);
            //}
            // si queremos modificarlo need for ()
            for (int i=0; i<arreglo.Length; i++)
            {
                arreglo[i] += 10;
            }
        }
        #endregion
        // video 40 devuelve array
        static int [] Leer()
        {
            Console.WriteLine(" ¿Cuanto elementos quieres que tenga el array?");
            string res = Console.ReadLine();   // informacion siemprer String
            int ele = int.Parse(res);
            int[] datos = new int[ele];
            for (int i=0; i<ele; i++)
            {
                Console.WriteLine($" Ingrese Posición {i}");
                res = Console.ReadLine();
                int data = int.Parse(res);
                datos[i] = data;
            }
            return datos;
        }

    }
}
