using System;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegados.  Video 67");
            // target== DEstino
            // Creacion objeto delegado apúnta mensaje bienvenida
            objDelegado ElDelegado = new objDelegado(MensajeBienvenida.Saludar);
            //utiliza Delegado llama método saludo bienvenida
            ElDelegado();
            // otra delegación
            ElDelegado = new objDelegado(MensajeDespedida.Despedir);
            ElDelegado();
            // target== DEstino
            // Creacion objeto delegado apúnta mensaje bienvenida
            objDelegadoPar ElDelegado_Par = new objDelegadoPar(MensajeBienvenida.Saludar);
            ElDelegado_Par("Hola, Acabo de llegar!!!");
            ElDelegado_Par = new objDelegadoPar(MensajeDespedida.Despedir);
            ElDelegado_Par("Chao, Ya me voy!!!");
        }
        // definición del objeto delegado
        delegate void objDelegado();
        delegate void objDelegadoPar(string msj);
    }
    class MensajeBienvenida
    {
        public static void Saludar()  // Metodo de clase sin instancia-Objeto 
        // sin parametros void
        {
            Console.WriteLine("Hola");
        }
        public static void Saludar(string msj)  // Metodo de clase sin instancia-Objeto 
        // sin parametros void
        {
            Console.WriteLine("Mensaje Bienvenida: {0}", msj);
        }
    }
    class MensajeDespedida
    {
        public static void Despedir()  // Metodo de clase sin instancia-Objeto 
        // sin parametros void
        {
            Console.WriteLine("Chao");
        }
        public static void Despedir(string msj)  // Metodo de clase sin instancia-Objeto 
        // sin parametros void
        {
            Console.WriteLine("Mensaje Despedida:: {0}", msj);
        }
    }
}
/////////////////////////////////////////////////////////
/// Funciones q delegan tareas a otras funciones.
/// Delegado REFERENCIA a un método.
/// Para:  llamar a eventos.
///        reducir codigo X manjar diferentes escenarios.
///        código reutilizable.
///  delegate TIPO NombreDelegado(parametros);
///  El delegado db tener mismo TIPO del método al que apunta.
///  EL numero parametros ===.
///  
