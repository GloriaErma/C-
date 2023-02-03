using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda. Video 69 ");

            // uso delegado
            OperacionMat operacion3 = new OperacionMat(Cuadrado);
            Console.WriteLine(operacion3(4));
            // simplifica funcion Cuadrado con lambda
            OperacionMat operacion4 = new OperacionMat(num => num * num);
            Console.WriteLine("Lambda:::" + operacion4(4));
            /////////////////////////////
            OperacionMat1 operacion1 = new OperacionMat1(Suma);
            Console.WriteLine(operacion1(8, 5));
            // expreson Lambda mas de un parametro db ir entre parentesis
            OperacionMat1 operacion2 = new OperacionMat1((n1, n2) => n1 + n2);
            Console.WriteLine("Lambda:::" + operacion2(8, 5));
            /////////////////////////////
            /// Lista valor numérico
            /// 
            List<int> Lista0 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> ListaPar = Lista0.FindAll(i => i % 2 == 0);  //pares
            foreach (int num in ListaPar) Console.WriteLine(num);
            ListaPar.ForEach(num => Console.WriteLine("Lambda:::" + num));
            //// EL trabajo varias líneas db ir: en llaves, separados x ";"
            ///
            ListaPar.ForEach(num =>
            {
                Console.WriteLine("Lambda:::");
                Console.WriteLine("El número PAR es:::" + num);
            });
            //// Instancias-Objeto
            ///EL trabajo varias líneas db ir: en llaves, separados x ";"
            ///
            Persona objP1 = new Persona();
            objP1.Nombre = "Juanita";
            objP1.Edad = 8;
            Persona objP2 = new Persona();
            objP2.Nombre = "Nika";
            objP2.Edad = 8;
            Persona objP3 = new Persona();
            objP3.Nombre = "Santiago";
            objP3.Edad = 88;
            /// delegadoE
            ComparaPersonasE Compara = (p1, p2) => p1 == p2;
            Console.WriteLine("Edad Igual::"+Compara(objP1.Edad, objP2.Edad));
            /// delegadoN
            ComparaPersonasN ComparaN = (p1, p2) => p1 == p2;
            Console.WriteLine("Nombre Igual::"+ComparaN(objP1.Nombre, objP2.Nombre));


        }

        public delegate int OperacionMat(int num);
        // simplifica funcion Cuadrado con lambda
        public static int Cuadrado(int num) => num * num;
        public static int Suma(int n1, int n2) => n1 + n2;
        public delegate int OperacionMat1(int n1, int n2);
        ////
        ////// delegado persona edad igual true / false
        ///
        public delegate bool ComparaPersonasE(int e1, int e2);
        public delegate bool ComparaPersonasN(string n1, string n2);


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
//////////////////////////////////////////////////////
/// Lambda
/// expresión anónima
/// crear delegados 
/// 
/// expresiones LINQ query
/// 
///  parámetros " => " expresión Funcion
///  parámetros " => " bloq sentencia.
///  
//// EL trabajo de sentencia tiene varias líneas db ir: en llaves, separados x ";"
