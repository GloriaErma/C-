using System;

namespace Generica_Rstriccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generica -- Restricciones. Video 62");
            GenericaEmpleados<Director> objDir = new GenericaEmpleados<Director>(3);
            objDir.agregar(new Director(4500));
            objDir.agregar(new Director(1500));
            objDir.agregar(new Director(2500));
            GenericaEmpleados<Secretaria> objSec = new GenericaEmpleados<Secretaria>(3);
            objSec.agregar(new Secretaria(4500));
            objSec.agregar(new Secretaria(1500));
            objSec.agregar(new Secretaria(2500));
            GenericaEmpleados<Electricista> objEle = new GenericaEmpleados<Electricista>(3);
            objEle.agregar(new Electricista(4500));
            objEle.agregar(new Electricista(1500));
            objEle.agregar(new Electricista(2500));
            GenericaEmpleados<Estudiante> objEst = new GenericaEmpleados<Estudiante>(3);
            objEst.agregar(new Estudiante(4500));
            objEst.agregar(new Estudiante(1500));
            objEst.agregar(new Estudiante(2500));
        }
    }
    // clase Genérica RESTRICCIÓN
    /////// izquierda  Y derecha ///////
    //AlmacenObjetos<Empleado> objArc = new AlmacenObjetos<Empleado>(4);
    class GenericaEmpleados <T> where T : IRestriccionEmpleados
    {
        public GenericaEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        public void agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }
        public T getEmpleado(int i) => datosEmpleado[i];
        private int i = 0;
        private T[] datosEmpleado;
    }

    class Director : IRestriccionEmpleados
    {
        public Director(double salario) => this.salario = salario;
        public double getSalario() => salario;
        private double salario;
    }
    class Secretaria : IRestriccionEmpleados
    {
        public Secretaria(double salario) => this.salario = salario;
        public double getSalario() => salario;
        private double salario;
    }
    class Electricista : IRestriccionEmpleados
    {
        public Electricista(double salario) => this.salario = salario;
        public double getSalario() => salario;
        private double salario;
    }
    class Estudiante
    {
        public Estudiante(double edad) => this.edad = edad;
        public double getEdad() => edad;
        private double edad;
    }
    interface IRestriccionEmpleados
    {
        double getSalario();
    }

}
////////////////////////////////////////////////////////////////////
/// Problemática
/// tenemos clase genérica AlmacenEmpleados <T>
/// Secretaria
/// Director
/// Profesor
/// Electricista
/// Caracteristica comun método getSalario, se puede implementar Interfaz.
/// Pero puede recibir clases NO adecuadas para la clase Genérica
/// como Jubilado o Estudiante.
/// Todos instancias-Objetos: deben Tener Salario.
/// 