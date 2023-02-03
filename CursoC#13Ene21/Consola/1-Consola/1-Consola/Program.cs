// namespace predefinida
using System;

// namespace unico
namespace _1_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /* GECS instancia . metodo...
            // Console clase predefinida o API viene con el lenguaje programacion
            // System.Console **************  hay boton de comentario y boton reverso comentario */
            int edad = 28;
            Console.WriteLine("GECS" + edad );
            Console.WriteLine("Multiplica:  " + 7*5);
            Console.WriteLine("Division entera:  " + 7 * 5);
            Console.WriteLine("Division decimal:  " + 7 / 5.0);
            Console.WriteLine("Residuo::: " + 9 % 4);
            edad = 19;
            edad++;
            // flujo ejecucion linea de izquierda a derecha------------------------>>>>
            Console.WriteLine($"Interpolación: edad de {++edad} años");
            Console.WriteLine($"****1-******TIPO DE DATO*********************************************");
            // clase 6
            int e1;
            int e2;
            int e3;
            int e4;
            e1 = e2 = e3 = e4 = 27;  // si utilizamos con (,) NO asigna a todas las variables
            Console.WriteLine(e4);
            Console.WriteLine($"*****2-********IMPLICITA**var* asigna en tiempo de ejecución** db declara y asigna*************************************");
            var edadPersona = 30;
            Console.WriteLine(edadPersona);
            var edadPersonaS = "GECS";
            Console.WriteLine(edadPersonaS);
            Console.WriteLine($"*****3-********Casting****NO redondea*********************************");
            double tempDouble = 34.9;
            int tempInt;
            tempInt = (int)tempDouble;
            Console.WriteLine(tempDouble);
            Console.WriteLine(tempInt);
            Console.WriteLine($"*****4-********implicita***tipos homologos x presicion********************************");
            int habitantesInt = 100000;
            long habitantesLon = habitantesInt;
            Console.WriteLine($"enteros {habitantesLon}");
            float pesoFlo = 5.78F;
            double pesoDou = pesoFlo;
            Console.WriteLine($"decimales {pesoDou}");

            //Console.WriteLine($"*****5-********texto-objeto a numericos *****parse**tipos NO homologos *******************************");
            //Console.WriteLine("Ingrese numero recibe como string:::");
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese numeroDOS recibe como string:::");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"RESULTADO ES NUMERICO CON int.parse():::{numero + numero2}");
            //Console.WriteLine("RESULTADO ES NUMERICO CON int.parse()"+ (numero + numero2));
            // contantes
            const int K0 = 99;
            const int K1 = 1000;
            Console.WriteLine("K es:::{0}", K0, K1);
            Console.WriteLine("K es:::{1}", K0, K1);
            const double PI = 3.1416;
            Console.WriteLine("radio:::");
            double radio = double.Parse(Console.ReadLine());
            //double area = radio * radio * PI;
            // Potencia es Pow 
            // double area = Math.Pow(radio, 2) * PI;
            // Constante PI;
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"el area es:: {area}");
            // METODO: TipoDevuelto Nombre(Parametros) {return}
            // METODO db ir dentro de una clase
            // METODO = FUNCION
            // SI NO devuelve valor VOID en vez de TipoDevuelto

        }
    }
}
/*  identificadores nombres para identificar: Namespaces, clases, metodos, variables, constantes. 
*  utiliza: letras, numeros, guion bajo
*  azul palabra reservada */
/* *****************************************
* Tipos de datos por valor: primitivos: Enteros(Con signo, son positivos y Sin signo, de positivos a negativos), 
* Reales(float, double, decimal) y Booleanos(true, false).
* int, long, float, double, decimal.
* string(X referencia), char(UTF16), bool.
* ****************************************
* declaracion Variables case sensity: espacio almacenar valor. 
* int edad = 28;    edad = 28;
* ****************************************
* convencion y buenas practicas: flujo de ejecucion programa de arriba a abajo.
*/

/* **************************************** 
/* Operadortes aritmeticos:  +,-,*,/.
*  Residuo/Modulo: %
*  Concatenacion string: +
*  incremento: ++ suma  una unidad
*  decremento: -- resta una unidad
*  +=5
*  -=9
*  Operador =
*  Declaracion implicitas: utiliza var RESPETAR VALOR EN TODO EL PROGRAMA
*  Conversiones implicitas con var db declara y asigna.....en tiempo de ejecución, EN VEZ del tipo de dato.
*  y explicitas: casting NO redondea.     
* **************************************** 
*   constantes:   const  tipo 
* **************************************** 
*  METODO: TipoDevuelto Nombre(Parametros)  {return}
*  
*  
* */
