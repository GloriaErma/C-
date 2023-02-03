using System;

namespace Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Generica Video 60 utiliza la herencia un array almacene objetos diferentes tipos");
            AlmacenObjetos objArc = new AlmacenObjetos(4);
            objArc.agregar("Juan");
            objArc.agregar("Sandra");
            objArc.agregar("Nika");
            objArc.agregar("Angela");
            //String nombre = objArc.getElemento(2)  // need CASTING 
            String nombre = (String)objArc.getElemento(2); // need CASTING
            Console.WriteLine(nombre);
            /////////////////////////////////////
            AlmacenObjetos objArc1 = new AlmacenObjetos(4);
            objArc1.agregar(new Empleado(1500));
            objArc1.agregar(new Empleado(2500));
            objArc1.agregar(new Empleado(3500));
            objArc1.agregar(new Empleado(4500));
            //String nombre = objArc.getElemento(2)  // need CASTING 
            //String nombre1 = (String)objArc1.getElemento(2); // need CASTING
            //Console.WriteLine(nombre);
            ///Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Generica.Empleado' to type 'System.String'///////////////////////////
            Empleado salario = (Empleado)objArc1.getElemento(2);
            Console.WriteLine(salario.getSalario());
        }
    }
    class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new Object[z];
        }
        public void agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public Object getElemento(int i)
        {
            return datosElemento[i];
        }
        private Object[] datosElemento;
        private int i = 0;
    }
    class Empleado
    {
        public Empleado (double salario) => this.salario = salario;
        public double getSalario() => salario;
        private double salario;
    }
}
///////////////////////////////////////////////////////
/// Programción Generica es Reutilización de Código
///  crear clases para manejo de cualquier objeto.
///  < TipoObjeto>  </TipoObjeto> q se maneja.
///  Clase <String> archivos = new Clase <String>() ;
///  Clase <File> archivos = new Clase <File>() ;
///  
/// COn Herencia SuperCLaseCosmica.
/// inconvenientes: 1- utiliza casting, 
/// 2- Complicación Código,
/// 3- posibilidad de comprobación Errores.
/// 
////////Progrmacion generica:  código sencillo, reutiliza código, 
///   verifica errores en tiempo ejecución.    
/// ///