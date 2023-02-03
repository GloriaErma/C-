using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herencia video 41-46");
            Caballo objCaballo = new Caballo("Bella");
            Humano objHumano = new Humano("Nika");
            Gorila objGorila = new Gorila("Richard");
            objGorila.trepar();
            // siempre cree Jerarquía de Herencia estan dentro de 
            // SuperClase Cósmica OBJECT
            // los métodos de esta clase son Heredados.
            //obGorila.Equals;  // segun métodos de clase Object
            objHumano.getNombre("Humano");
            objCaballo.getNombre("Caballo");   
            objGorila.getNombre("Gorila");
            // principio de sustitución
            //Caballo animalNO = new Mamiferos("Otro Caballo");  // ::::::NOOOOOOOOOOOOOOOOOOOOOO
            Mamiferos objAnimal = new Caballo("Otro Caballo");  //::::::SIIIIIIIIIIIIIIIIIIIIII
            //////////////////////////////////////////
            Mamiferos objPersona = new Humano("Vero");   // acceso métodos Mamiferos, NO persona
            Mamiferos objAni = new Mamiferos("Bucéfalo");
            Caballo objCaballo1 = new Caballo("Bucéfalo1");   //*
            Humano objHumano1 = new Humano("Marina");
            Gorila objGorila1 = new Gorila("Gorila1");
            objAni = objCaballo1;  // OK;
            //objCaballo1 = objAni;  //  ERROR;  
            //NO se puede asignar un instancia-objeto Mamifero igual instancia-objeto caballo
            // segun métodos de Superclase Object
            Object objA = new Caballo("Caballo1");
            Object objP = new Humano("humano1");
            Object objM = new Gorila("Mamifero1");
            //////////////////////////////////////////////////
            ///
            //Caballo[] objAlmacen = new Caballo[3];
            //objAlmacen[0] = objCaballo1;                    //*
            //objAlmacen[1] = objHumano1;                     //ERROR
            //objAlmacen[2] = objGorila1;                     //ERROR
            //////////////////////////////////////////////////
            ///
            Mamiferos[] objAlmacen1 = new Mamiferos[3];
            objAlmacen1[0] = objCaballo1;                    //*  SOLO ACCEDER métodos Mamiferos
            objAlmacen1[1] = objHumano1;                     //ERROR
            objAlmacen1[2] = objGorila1;                     //ERROR
            //////////////////////////////////////////////////
            /// tienen acceso a métodos Mamiferos X ser Tipo Mamifero
            objAlmacen1[1].respirar();
            objAlmacen1[2].cuidaCrias();
            //////////////////////////////////////////////////
            objAlmacen1[1].getNombre("Almacen");
            ////////////////////////////////////////////////////////////
            /// POLIMORFISMO
            /// virtual      override
            ///
            Mamiferos[] objAlmacen2 = new Mamiferos[3];
            objAlmacen2[0] = objCaballo1;       // pensar Mamiferos
            objAlmacen2[1] = objHumano1;        // pensar Humano            
            objAlmacen2[2] = objGorila1;        // pensar Gorila
            // Polimorfismo...
            for (int i=0; i<3; i++)
            {
                objAlmacen2[i].pensar();
            }
            Mamiferos objMamifero1 = new Mamiferos("");
            objMamifero1.respirar();  // NO accede al declarar protected void respirar() en Mamiferos


        }
    }
    // clase cuspide de jerarquia herencia, Hereda de Object.
    class Mamiferos
    {
        // reemplazar construtor X defecto invisible por el siguiente...
        // las subclases marcan ERROR, x q tienen :base() implicitamente
        // que llaman el contructor x defecto padre.
        // En cada subclase se db llamar el new contructor 
        public Mamiferos(String nombre) =>    nombreSerVivo = nombre;
            
        ////public void respirar()
        /// pasarlo de public a protected
        /// accecible clases: Mamiferos,Caballo,Humano
        /// NO accesible clase Main q NO hereda de Mamiferos.
        /// SI en Caballo, metodo galopar  
        /// protected void respirar()
        // NO aparecen en el menu contextual de las instancias-Objeto.
        //private void respirar()   : solo accessible desde Mamiferos
        protected void respirar()
        {
            Console.WriteLine("RESPIRO");
        }
        // declarar método pensar para delfín
        //public void pensar() => Console.WriteLine("pensamiento Delfín");
        // Este método es diferente de los otros métodos pensar...modificado
        // se declara en padre como método virtual
        // indica q todas las SubClases Mamiferos db tener método pensar que 
        // modifiq el método de Padre Mamiferos, agrege o quite algo del comportamiento.
        public virtual void pensar() => Console.WriteLine("pensamiento Delfín");

        public void cuidaCrias() => Console.WriteLine("CUIDAR CRIAS");
      
        public void getNombre(string obj)  => Console.WriteLine($" El nombre del {obj} es:: "+ nombreSerVivo );
        // campo de Clase encapsulado
        private String nombreSerVivo;
    }
    // clases que heredan de Mamiferos
    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo):base(nombreCaballo) { }

        //public void galopar() => Console.WriteLine("GALOPAR");

        public void galopar()
        {
            respirar();   // accede al declarar protected void respirar() en Mamiferos
        }     
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano): base(nombreHumano) { }

        // oculta método x ingreso en Mamiferos de método pensar().
        // SI recibe parametros seria sobrecarga public void pensar(String nombre)
        //public void pensar()  => Console.WriteLine("PENSAR"); // advertencia-green étodo mismo nombre q Mamiferos
        // SI llamar método pensar, saldria en consola este mensaje: "PENSAR"
        // NO el Mamiferos.pensar()
        //new public void pensar() => Console.WriteLine("PENSAR");
        // para aplicar el virtual del método Mamiferos.pensar se db
        // corresponder a estos métodos que son sus modificaciones la 
        // palabra override
        //public void pensar() => Console.WriteLine("PENSAR HUMANO");
        public override void pensar() => Console.WriteLine("PENSAR HUMANO");

    }  
    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }

        public void trepar() => Console.WriteLine("TREPAR");
        // CREAR método pensar
        // para aplicar el virtual del método Mamiferos.pensar se db
        // corresponder a estos métodos que son sus modificaciones la 
        // palabra override
        //public void pensar() => 
        public override void pensar() => Console.WriteLine("PENSAR GORILA");


    }


}
////////////////////////////////////////////////////////////
/// Herencia
/// 
// principio de diseño de herencia "es un"
// SI respuesta es SI db heredar
// un empleado es un director, NO db heredar de director.
// un director es un empleado, SI director db heredar de empleado.
//     empleado
// jefe        director   ------  SI es un empleado.
//  empleado -- jefe(SI es un empleado.) -- director(SI es un empleado.)
// caracteristicas comunes: nombre, edad, fecha inicio, salario, trabajar, generar informas.
// se definen en la clase cuspide::: empleado.
//////
// caballo, humano, gorila.
// crear clase mamifero: vertebrado, sangre caliente,mamar.   
// clase para herencia mamifero.
///////////////////////////////////////////////
// SuperClase: Mamiferos
// Subclases: Caballo,Humeno, Gorilla.
////////////////////////////////
// Contructor por defecto: NO parámetros y esta totalmente vacio.
// Indica el estado inicial de los objetos.
////////////////////////////////
// Todas las clses tiene su constructor por defecto
// en Herencia, cada una de las subclases llama al contructor de la clase padre.
//  intrucción ":base",
/////////////////////// pero si se programa un constructor:
// public Mamiferos ( String nombre)
// {
//   nombreSerVivo=nombre;
//  }
// se debe programar para llamar al constructor de la Superclase en cada sublclase
// pasarle el dato de parametro.
///////////////////////////////////////////////////////
// Principio de Sustituciön: 
// un objeto de un tipo por otro tipo, teniendo en cuenta la Herencia
// ES siempre un.......
// un humano es siempre un caballo........NOOOOOOOOOOOOOOOOOOOOOOOOO
// un Caballo es siempre un mamifero......SIIIIIIIIIIIIIIIIIIIIIIIII
///////////////////////////////////////////////
///////////////////////////////////////////////
// SuperClase: Mamiferos
// Subclases: Caballo,Humeno, Gorilla.
////////////////////////////////
// Caballo animal = new Mamiferos();::::::NOOOOOOOOOOOOOOOOOOOOOO
// Caballo animal = new Mamiferos();::::::NOOOOOOOOOOOOOOOOOOOOOO
// Caballo animal = new Mamiferos();::::::NOOOOOOOOOOOOOOOOOOOOOO
// Mamiferos animal = new Caballo();::::::SIIIIIIIIIIIIIIIIIIIIII
// Mamiferos animal = new Humano();::::::SIIIIIIIIIIIIIIIIIIIIII
// Mamiferos animal = new Gorila();::::::SIIIIIIIIIIIIIIIIIIIIII
/////////////////////////////////////////////////////////////
///  Empleado:       :::  SuperClase
/// -- secretaria -- director -- jefe seccion  ::: Subclases
/// 
/////////////////////////////////////////////////////////////
/// POLIMORFISMO
/// virtual      override
/// 
/// Declara método pensar (humano) para mamiferos como Delfín.
/// Revisando en documentación .NET Core 3.1
/// https://docs.microsoft.com/en-us/dotnet/api/.....
/// se pueden encontrar lo methods...
/// ToString ::: Devuelve una cadena que representa el objeto actual.
///             public virtual string ToString ();
///             TODAS las CLASEs heredan este método y pueden modificar 
///             este método para q adapte.

/////////////////////////////////////////////////////////////////////////
/// public, private, protectec
/// public variable o método, accede desde cualquier clase.
/// NO recomendable declarar una variable en una clase como public 
/// se db declarr private:: encapsulada, si se necesita modificar private x Metodo private
/// protected , accesible desde la propia clase y las q hereden.
/// pasar metodo respirar de Mamiferos a protectec