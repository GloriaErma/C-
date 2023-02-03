using System;

namespace Metodo
{
    class Program
    {
        // AMBITO LOCAL == ALCANCE LOCAL
        // las variables COMPARTIDAS EN DIFERENTES METODOS se db declarar con AMBITO DE CLASE,............ NO local
        // AL INICIO O AL FINAL DE LA CLASEEEEEEEEEE  = campos de clase
        int numero1 = 5;
        int numero2 = 7;

        // METODO de PUNTO de ENTRADA Main void
        // static pertenece a metodo de clase NO es un objeto, NO se db utilizar un objeto en la llamada.
        static void Main(string[] args)
        {
            mensajePantalla();
            Console.WriteLine("2. Mensaje desde METODO Main");
            mensajePantalla();
            // llamada METODO suma
            suma(7,9);
            // llamada METODO sumaRETURN
            Console.WriteLine(sumaReturn(8,5));
            // llamada METODO divideRETURN
            Console.WriteLine(divideReturn(18, 7));
            // AMBITO = ALCANCE
            //primerMetodo();
            //segundoMetodo();
            // Sobrecarga segun numero patrametros y tipo parametros
            Console.WriteLine(sumaSobre(7,5));
            Console.WriteLine(sumaEj(7, 5.3));
            // parametro opcional AUTOMATICO
            int v1 = 7;
            double v2 = 5.2;
            double v3 = 8.3;
            // llmada al metodo NO pasa v3 para ejecutar METODO
            Console.WriteLine(sumaOpcional(v1,v2));
            // llmada al metodo SI pasa v3 para ejecutar METODO
            Console.WriteLine(sumaOpcional(v1, v2, v3));



        }

        // parametro v3 opcional con igual a valor x defecto, AL FINAL del COMANDO
        private static double sumaOpcional(int v1, double v2, double v3=0) =>
            //throw new NotImplementedException();  // AUTOMATICO
            v1 + v2 + v3;

        // METODO automatico x ERROR LAMBDA
        //private static bool sumaEj(int v1, double v2)  // AUTOMATICO
        private static double sumaEj(int v1, double v2) =>
            //throw new NotImplementedException();  // AUTOMATICO
            v1 + v2;

        // Add static para poderlo llamar
        static void mensajePantalla()
        {
            Console.WriteLine("1. Mensaje METDOD Pantalla");
        }
        // METODO suma VOID sin devolver con return
        static void suma(int num1, int num2)
        {
            Console.WriteLine($"suma es: {num1 + num2}");
        }
        // METODO sumaRETURN
        static double sumaReturn(double num1, int num2)
        {
            return num1 + num2;
        }
        // METODO divideRETURN
        static double  divideReturn(double num1, int num2)
        {
            return num1 / num2;
        }
        // METODO MENOS QUE EL scroll  MODULARIZACION una linea codigo
        static double divideReturnModulo(double num1, int num2) => num1 / num2;
        // AMBITO == ALCANCE SI lo llama db ser satic
        // AMBITO LOCAL == ALCANCE LOCAL
        // las variables COMPARTIDAS EN DIFERENTES METODOS se db declarar con AMBITO DE CLASE,............ NO local
        void primerMetodo()
        {
            //Console.WriteLine(numero1 + numero2);  // ERROR NO han sido declaradas...
            //int numero1 = 5;
            //int numero2 = 7;
            Console.WriteLine($"primerMetodo {numero1+numero2}");
        }

        void segundoMetodo()
        {
            Console.WriteLine($"segundoMetodo {numero1 + numero2}");
        }
        // Sobrecarga diferente numero parametros y tipo parametro diferentes
        static int sumaSobre(int opera1, int opera2) => opera1 + opera2;
        static int sumaSobre(int ope1, int ope2, int ope3) => ope1 + ope2;  // diferente numero parametros
        static double sumaSobre(int ope1, int ope2, double ope3) => ope1 + ope2;   // diferente tipo numero parametros

    }
}
