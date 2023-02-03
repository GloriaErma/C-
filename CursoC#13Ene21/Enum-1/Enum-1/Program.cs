using System;

namespace Enum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Video 58");
            Empleado objEmp = new Empleado(Bonos.extra, 1900.5);
            Console.WriteLine(" Salario empleado es:" + objEmp.getSalario());
        }
    }
    class Empleado
    {
        public Empleado (Bonos bonosEmpleado, double salario )
        {
            // bonos = (double)bonosEmpleado;  // casting
            // ERROR SI SE DEFINE TIPO Bonos Enum

            this.bonos = bonosEmpleado;
            this.salario = salario;
        }
        public double getSalario()
        {
            //return (salario + bonos) // ERROR SI SE DEFINE TIPO Bonos Enum
            return (salario + (double)bonos);  //casting pasarlo de Bono Enum a double

        }
        //private double salario, bonos
        private double salario;
        private Bonos bonos;   // SI ccambiamos declaracion double a Bonos Enum
    }
    enum Bonos { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };
}
