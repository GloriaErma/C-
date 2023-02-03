using System;
using System.Collections.Generic;
using System.Text;

namespace ModFicheros
{
    class Punto
    {
        public Punto(int x, int y)
        {
            Console.WriteLine($" Recibe parametros X:: {x}, Y:: {y}");
            this.x = x;                 //campos de clase ambito class Punto
            this.y = y;                 //campos de clase ambito class Punto
            contadorObjetos++;          // var static of class Contador general de objetos
        }
        public Punto()
        {
            Console.WriteLine("Este es el contructor x defecto");
            this.x = 0;
            this.y = 0;
            contadorObjetos++;          // var static of class Contador general de objetos
        }
        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distancia = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distancia;
        }

        // campos de clase encapsulados entre el ambito de class Punto
        private int x, y;
        // private: 1- encapsulada y static of Class NO obedece a instancia Objeto.
        private static int contadorObjetos = 0;
        // 2- metodo acceso; convesión de acceso: public, static, Tipo dato NO importa ORDEN MODIFICADORES.
        // metodo get....getsetting   Metodo Clase:
        //public static int ContadorObjetos()
        //{
        //    return contadorObjetos;
        //}
        // simplificar una unica instrucción:
        // devolver var static-class, NO necesario q el metodo sea static-class
        public static int ContadorObjetos() => contadorObjetos;
        // todas las const son static, NO need agrafgar static
        public const int K = 7;



    }
}
