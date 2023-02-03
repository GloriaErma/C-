using System;
using static System.Math;        // Métodos static-class
using static System.Console;     // Métodos static-class

namespace ModFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Modulacion x ficheros");
            //tarea();  // comentario 
            // metodos static-class de la clase
            double raiz = Sqrt(9);          // Math.Sqrt(9);
            double potencia = Pow(3, 4);    // Math.Pow(3, 4);
            WriteLine($" Raiz:: {raiz}");           // Console.WriteLine
            WriteLine($" Potencia:: {potencia}");   // Console.WriteLine
            // Instanciar CLASS ANÓNIMA en var, NO TIENE NOMBRE
            // declarar campo e iniciarlos   var
            var variable = new { Nombre = "Juan", Edad = 19 };
            WriteLine(variable.Nombre + " y " + variable.Edad);
            var otravar = new { Nombre = "GECS", Edad = 25 };    // OTRA INSTANCIA OBJETO ANÓNIMA
            // numero, tipo y orden DE CAMPOS determina misma clase ANÓNIMA
            variable = otravar;   // SI fuera Edad = "25" NO sería la misma clase anónima };
            // requisitos ANÓNIMAS: solo contener campos públicos, 
            // todos los campos deben estar iniciados, 
            // los campos NO pueden ser static-class.
            // NO se pueden definir métodos

        }
        #region
        static void tarea()
        {
            // continuar Aqui
            // comentar TODO:  VER- Lista de Tareas identifica el comentario
            // TODO:
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otroPunto = new Punto();

            //origen.ContadorObjetos();   //En una instancia-Objeto, ERROR NO permite POR SER STATIC DE CLASE

            // metodo llamado por una instancia
            double distancia = origen.DistanciaHasta(destino);
            // metodo llamado por una clase
            WriteLine($" La distancia entre los puntos es: {distancia}");
            // clase Punto para acceder a metodo static-class
            WriteLine($" Numero objetos creados { Punto.ContadorObjetos()}");
            // otroPunto.K;  cons es static
            // todo:
        }
        #endregion
        ///////////////////////////////////////
        ///  crear otra clase en otro fichero fuente independiente.MODULARIZACION
        ///  1. Botón derecho en tipo proyecto con opción Agregar - Clase
        ///  2. Menu Proyecto Agragar - Clase
        ///////////////////////////////////////
        /// metodos y variables static
        /// Si static la variable es compartida por todos las INSTANCIAS - OBJETO, NInguna instancia objeto es dueño 
        /// de la variable, pero SI es dueña la clase.
        /// static son de CLASE.
        /// Clase.contador= 9  ...SI es static of Class.
        /// clases con metodos, variables sean static,  NO se puedan modificar x instancia objeto
        /// 
    }
}
/////////////////////////////////////
/// importar métodos static
/// clases anónimas, expresión query.
/// ////////////////////////////////
/// Arrays, video 36