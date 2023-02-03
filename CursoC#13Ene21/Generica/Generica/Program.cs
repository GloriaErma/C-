using System;

namespace Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Generica Video 61 utiliza la herencia un array almacene objetos diferentes tipos");

            /////// izquierda  Y derecha ///////
            AlmacenObjetos<Empleado> objArc = new AlmacenObjetos<Empleado>(4);
            objArc.agregar(new Empleado(1500));
            objArc.agregar(new Empleado(2500));
            objArc.agregar(new Empleado(3500));
            objArc.agregar(new Empleado(4500));
            Empleado salario = objArc.getElemento(2);
            Console.WriteLine(salario.getSalario());
            ///////////////////////
            AlmacenObjetos<String> objArc1 = new AlmacenObjetos<String>(4);
            objArc1.agregar("Juan");
            objArc1.agregar("Sandra");
            objArc1.agregar("Nika");
            objArc1.agregar("Angela");
            String nombre = objArc1.getElemento(2);
            Console.WriteLine(nombre);
            ///////////////////////
            AlmacenObjetos<DateTime> objArc2 = new AlmacenObjetos<DateTime>(4);
            objArc2.agregar(new DateTime());
            objArc2.agregar(new DateTime());
            objArc2.agregar(new DateTime());
            objArc2.agregar(new DateTime());
            DateTime fecha = objArc2.getElemento(2);
            Console.WriteLine(fecha);
        }
    }
    /// <summary>
    ///  GENERICA, convensiÓn <T>
    /// </summary>
    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new  T[z];
        }
        public void agregar(T  obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T  getElemento(int i)
        {
            return datosElemento[i];
        }
        private T[] datosElemento;
        private int i = 0;
    }
    class Empleado
    {
        public Empleado(double salario) => this.salario = salario;
        public double getSalario() => salario;
        private double salario;
    }
}