using System;

namespace PropiedadAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propiedades Acceso Video 55 ");
            Empleado objEmpleado = new Empleado("Juan");
            //objEmpleado.SetSalario(1200);
            //Console.WriteLine
            //    ("El Salario del Empleado: " + objEmpleado.GetNombre() + ", es: $"+ objEmpleado.GetSalario() );
            ////Se aumenta el salario nueva variable
            //double nuevoSalario = objEmpleado.GetSalario() + 2000;
            //Console.WriteLine
            //   ("El NUEVO Salario del Empleado: " + objEmpleado.GetNombre() + ", es: $" + nuevoSalario);
            ////NO permite por nivel d protección, pero si lo convertirmos en public permite...
            //objEmpleado.salario += 2000;
            //objEmpleado.salario += -2000;
            /// aplicando properties, se comenta getter y setter
            /// 
            objEmpleado.SALARIO = 1200;
            Console.WriteLine
          ("El Salario del Empleado: " + objEmpleado.GetNombre() + ", es: $"+ objEmpleado.SALARIO );
            
            objEmpleado.SALARIO += 2500;
            Console.WriteLine
          ("El Salario del Empleado: " + objEmpleado.GetNombre() + ", es: $" + objEmpleado.SALARIO);

            objEmpleado.SALARIO -= 7950;
            Console.WriteLine
          ("El Salario del Empleado: " + objEmpleado.GetNombre() + ", es: $" + objEmpleado.SALARIO);

        }
    }
    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        // se comenta para explicación de properties
        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("Salario NO puede ser negativo. Se asigna 0 como Salario");
        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}
        //public double GetSalario() => salario;
        public string GetNombre() => nombre;

        // crea método de control encapsulado, evalua salario.
        private double EvaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
        // crear propiedad
        //public double SALARIO
        //{
        //    get { return this.salario; }
        //    set { this.salario = EvaluaSalario(value); }
        //}
        //simplificar propiedad
        // se puden creasr propiedades de solo get o solo set.
        public double SALARIO
        {
            get => this._salario;
            set => this._salario = EvaluaSalario(value);

        }

        ////private double salario;
        //public double salario;
        private double _salario;  //X CONVENCIÓN para Nombre de Campo
        private string nombre;   
    }
}
///////////////////////////////////////////////////////////////////
/// private === encapsulación.
/// 
/// Incrementar salario. Sin modificar Class Empleado. Solo en Main.
///  
/// Las properties NO permite acceder al campo desde otra clase, para violar las reglas programadas
/// Y permite utilizar sintaxis más sencilla.
/// 






