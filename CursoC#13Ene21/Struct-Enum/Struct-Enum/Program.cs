using System;

namespace Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structuras  Video 57");
            Empleado objEmp1 = new Empleado(1200, 250);
            Console.WriteLine(objEmp1);
            // 
            objEmp1.cambiaSalario(objEmp1, 100);
            Console.WriteLine(objEmp1);
        }
    }
    //public class Empleado
    //public struct Empleado
    //public class Empleado
    public struct Empleado
    {
        public double salarioBase, comision;
        public Empleado ( int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }
        public override string ToString()
        {
            return string.Format
          ("Salario y Comisión del empleado({0},{1})", this.salarioBase,this.comision);
        }
        // crear método nuevo
        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }

}
///////////////////////////////////////////////////////////
/// clases y estructuras
/// clases almacenan memoria Heap-ACCESO LENTO
/// struct almcenan memoria stack-ACCESO RAPIDO- TEMPORAL -FORMA PILA LIFO, como tipo primitivo o referencia
/// ////////////////
/// variable tipo primitivo RESERVA ESPACIO en Stack.
/// 
/// Empleado objEmp1 = new Empleado();
/// clase instrucción new   RESERVA ESPACIO en Heap.
/// Empleado objEmp1 se CREAR REFERENCIA A ESE OBJETO CREADO Heap en Stack.
/// 
////Empleado objEmp2 = new Empleado
// otra clase instrucción new RESERVA ESPACIO en Heap.
/// Empleado objEmp2 se CREAR otra REFERENCIA A ESE OBJETO CREADO Heap en Stack.
/// 
/// Empleado objEmp1 = Empleado objEmp2
/// Las 2 REFERENCIAS SE PIERDEN Y APUNTAN AL MISMO OBJETO ALMACENADO EN Heap.
/// 
/// Loc cambios en clase repercute directamente en la almcanado en Heap.
/// 
/// 
/// 
/// ////////////////////////////////////
/// struct 
/// almacena en Stack.
/// Al crear cada instancia-objeto, se crea una copia de la struct Empleado.en Stack.
/// Cuando se hacen cambios en struct, repercute en la copia.
/// La estructura original queda inalterable.
/// NO permite declarar constructor X defecto.
/// El compilador NO inicia los campos. Puedes iniciarlos en el contructor.
/// NO puede haber sobrecarga d constructores.
/// NO heredan de otras clses pero SI implementan Interfaz
/// SON selladas- sealed.......
/// //////  USAR..
/// NEED trabajar cantidad elevada de datos en memoria.(arreglos)
/// Representación primitivos, Números complejos, punto tridimensionales.
/// Cuando las instancias-Objeto NO deban cambiar
/// Cuando instancia tenga tamaño inferior a 16 bytes.
/// cuando NO necesites convertir a objeto-- boxed
/// X razones de rendimiento.
///////////////////////////////////
