using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ARRAYS ");
            //int[] edades;
            //edades = new int[4];
            //edades[0] = 15;
            //edades[1] = 27;
            // otra forma de inicializar el array
            int[] edades = { 15, 27, 19, 40 };  // == int[] edades  = new int[4] { 15, 27, 19, 40 }; 

            Console.WriteLine($" Arreglo tiene:: {edades} y {edades[2]}" );
            // Acceder a una posición que NO existe crea una excepción de Rango
            //////////////////////////////////////////////////////////////////
            ///  array 
            //var a_Implicito = new[] { "Juan", "Dias", "España", 15 };  //ERROR x Tipo
            var valores = new[] { 1, 4, 6, 7.01, 30.30, 99.9};  // NO ERROR 
            // array instancia-Objeto
            Empleados Ana = new Empleados("Ana", 27);        // CREAR Instancia-objeto
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("sara", 37);   // CREAR mientras almacenar Instancia-objeto en array
            arrayEmpleados[1] = Ana;    // Primero CREAR y luego almacenar
            arrayEmpleados[2] = new Empleados("Nica", 22);
            // crear arreglo de la clase String, o Date
            ////////////////////////////////////////////////////////
            ///  array Anónimas
            var anonimo = new[]
            {
                new {Nombre="Pepe",  Edad=19},  // la sintaxis igual en cada elemento
                new {Nombre="María", Edad=98},  // la sintaxis igual en cada elemento
                new {Nombre="Diana", Edad=35},  // la sintaxis igual en cada elemento
            };
            Console.WriteLine(anonimo[2]);
            // video 38 - 40 ciclo for

            for (int i = 0; i <= 4; i++)  // === i<5;
            //for (int i = 15; i <= 11; i--)  // === i<5/*;*/
            {
                Console.WriteLine(valores[i]);

            }
            for (int i=0; i<valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
            for (int i = 0; i < anonimo.Length; i++)
            {
                Console.WriteLine(anonimo[i]);
            }
            // NO imprime las propiedades del 
            // imprime los objetos como tal
            // se puede cambiar el acceso a las propiedades de la clase como 
            // public String nombre; en la class Empleados, pero 
            // permitiria:: arrayEmpleados[0].nombre = "Leo Messi";
            for (int i=0; i<arrayEmpleados.Length; i++)
            {
                // permitiria:: arrayEmpleados[0].nombre = "Leo Messi";
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }
            // para VER que hay en arreglo NO modificarlo     
            // variable iterador del mismo tipo del array
            foreach (Empleados iterador in arrayEmpleados)
            {
                Console.WriteLine( iterador.getInfo());
            }
            foreach (double iterad in valores)
            {
                Console.WriteLine(iterad);
            }
            foreach (var iter in anonimo)
            {
                Console.WriteLine(iter);
            }
        }
    }
    class Empleados
    {
        // Contructor Método con el nombre de la clase
        public Empleados ( String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        // las propiedades d clase, DB estar encapsuladas con private
        private String nombre;
        private int edad;
        // se declara getters
        public string getInfo()
        {
            return "Nombre Empleado: " + nombre + " y Edad: " + edad;
        }
    }
}
