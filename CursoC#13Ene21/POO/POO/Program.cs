using System;

namespace POO
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello World!");
        //    // Declaracion objeto clase circulo = instancia clase circulo
        //    // nombre clase, nombre objeto ==== variable objeto tipo circulo.
        //    Circulo objCirculo;
        //    // iniciar **Instanciar Clase: nombre Variable, simbolo =, "new", clase y parentesis.
        //    objCirculo = new Circulo();
        //    Console.WriteLine($" objCirculo.Area(5)");
        //    Console.WriteLine($" Area Circulo: {objCirculo.Area(5)}");
        //    // otras instancias del objeto Circulo
        //    Circulo objCirculo1 = new Circulo();
        //    Console.WriteLine($" Area Circulo1: {objCirculo.Area(9)}");
        //    // acceder a propiedades del objeto
        //}
        static void Main(string[] args)
        {
            ConvertirEuroDolar obj = new ConvertirEuroDolar();
            // acceder a public vrEuro
            obj.CambiaValor(1.45);

            Console.WriteLine($" valor convertido en dolares {obj.Convierte(50)}");
        }




    }
    class Circulo
    {
        // PROPIEDAD  = variable class circulo. Campos de clase.
        //public double Pi = 3.1416;
        // convertir Pi en constante NO db ser accecible, 
        // se encapsula con ""private"" solo visible en esta clase.
        // se db encapsular siempre const y var, se modifica el acceso x metodo.
        private const double Pi = 3.1416;
        // METODO de clase, comportamiento, accecible desde fuera
        public double Area(int radio)
        {
            Console.WriteLine($"Radio Metodo 'Circulo.Area':  { radio}"); 
            return Pi * radio * radio;
        }
    }
    class ConvertirEuroDolar
    {
        //public double vrEuro = 1.253;
        // para encapsular public pasa a private NO accecible desde Main
        private double vrEuro = 1.253;
        public double Convierte(double cantEuros)
        {
            return cantEuros * vrEuro;
        }
        // el acceso a propiedad vrEuro Se realiza por un metodo
        public void CambiaValor(double nuevoVr)
        {
            if (nuevoVr < 0) vrEuro = 1.253;
            else vrEuro = nuevoVr;
        }
    }



}
//////////////////////////////////////
/// POO vs. Procedimientos
/// Clase: modelo o plantilla. características comunes de los coches.
/// Objeto: derivan de clase o plantilla. Características propias peso,color. 
///         Comportamientos son métodos o funciones: arrancar, frenar, girar, acelerar.
/// PSEUDOCODIGO:        
///         Nomenclatura del punto, accede a propiedad o comportamientos.
///         
/// Ejemplar de clase, Instancia clase.
/// Modularización, dividir partes.
/// Encapsulación, bloquear acceso.
/// Herencia, padre e hijo.
/// Polimorfismo
/// 
/// NUEVA CLASE ANTES O DESPUES DE Class Program
/// ///////////////////////////////////////////
/// Encapsulación
/// public const, var, metodo db comenzar mayúscula.
/// private db comenzar minúscula.
/// 
///////////////////////////////////////////////
/// Constructores
/// 





