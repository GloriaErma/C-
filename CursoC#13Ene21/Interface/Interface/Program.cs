using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces video 48");
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
            for (int i = 0; i < 3; i++)
            {
                objAlmacen2[i].pensar();
            }
            Mamiferos objMamifero1 = new Mamiferos("");
            objMamifero1.respirar();  // NO accede al declarar protected void respirar() en Mamiferos

            Ballena objBallena = new Ballena("Wally");
            objBallena.nadar();
            Console.WriteLine("INTERFAZ::Número Patas Caballo Babieca  " + objCaballo.NumeroPatas());
        }
    }
    // crea Interfaz para obligar el manejo de método 
    // nombre interfaz "I"
    // Declaración métodos obligatorios que debe tener la clase.
    // Sin modificador de acceso.
    // que clase db implementar esta interfaz
    /// <summary>
    ///  los métodos NO se desarrollan, solo se nombran.
    ///  sin modificador de acceso.
    /// </summary>
    /// Los métodos comienzan por MAYUSCULAS.
    /// Nombre Método, tipo dato return, parametros y tipo === definidos en Interfaz
    interface IMamiferoTerrestre
    {
        int NumeroPatas();
    }
    // clase cuspide de jerarquia herencia, Hereda de Object.
    class Mamiferos
    {
        ///  video 43 - Contructores y base
        ///  el contructor de la SubClase SIEMPRE llama al contructor de SuperClase= ClasePadre
        ///  Asi sea contructor x defecto= vacio, Para iniciar los OBJETOS, 
        ///  
        /// reemplazar construtor X defecto invisible por el siguiente...
        // las subclases marcan ERROR, x q tienen :base() 
        /// ":base()": llamar al constructor de la SuperCLase= ClasePadre en las SubClases.
        // que llaman el contructor x defecto padre.
        // En cada subclase se db llamar el new contructor 
        public Mamiferos(String nombre) => nombreSerVivo = nombre;

        ////public void respirar()
        /// pasarlo de public a protected
        /// accecible clases: Mamiferos,Caballo,Humano
        /// NO accesible clase Main q NO hereda de Mamiferos.
        /// SI en Caballo, metodo galopar  
        /// protected void respirar()
        // NO aparecen en el menu contextual de las instancias-Objeto.
        //private void respirar()   : solo accessible desde Mamiferos
        //protected void respirar()  // NO accesible
        public void respirar()
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

        public void getNombre(string obj) => Console.WriteLine($" El nombre del {obj} es:: " + nombreSerVivo);
        
        // todas las clases q heredan de Mamiferos heredan método numeroPatas
        // pero la ballena NO cumple método.
        // La posibilidad x ERROR o mala intención programador desarrolle en 
        // clase que NO deban, NO db heredar en todos los Mamiferos.
        // La Interfaz, se puede decidir quien SI y quien NO implemente inter
        // especificar el comportamiento a SEGUIR X las clases que hereden.
        // 
        //public int numeroPatas()
        //{
        //    return patas;
        //}
        //private int patas;

        // campo de Clase encapsulado
        private String nombreSerVivo;
       
    }

    // clases que heredan de Mamiferos
    // implemente Interfaz
    // orden::  "class" + NombreClase + ":" + NombreInterfaz;
    // SI Herencia:: "class" + NombreClase + ":" + NombreInterfaz + "," + NombreInterfaz;
    class Caballo : Mamiferos, IMamiferoTerrestre
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) { }

        //public void galopar() => Console.WriteLine("GALOPAR");

        public void galopar()
        {
            respirar();   // accede al declarar protected void respirar() en Mamiferos
        }
        // DB implementar método Interfaz
        // Nombre Método, tipo dato return, parametros y tipo === definidos en Interfaz
        public int NumeroPatas() => 4;
        //{
            //return 4;
        //}
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }

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
    class Gorila : Mamiferos, IMamiferoTerrestre
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }

        public void trepar() => Console.WriteLine("TREPAR");
        // CREAR método pensar
        // para aplicar el virtual del método Mamiferos.pensar se db
        // corresponder a estos métodos que son sus modificaciones la 
        // palabra override
        //public void pensar() => 
        public override void pensar() => Console.WriteLine("PENSAR GORILA");
        // DB implementar método Interfaz
        // Nombre Método, tipo dato return, parametros y tipo === definidos en Interfaz
        public int NumeroPatas() => 2;

    }
    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena ) : base(nombreBallena) // llamar contructor padre
        {
            Console.WriteLine();
        }
        public void nadar()
        {
            Console.WriteLine("CAPAZ NADAR");
        }

    }


}
/////////////////////////////////////////////////////////
/// INTERFACES
/// Conjunto directrices q db cumplir la clases
/// Clase implementa o hereda las interfaces creadas
/// interfaz es una clase pero solo definiciones de métodos, sus declaraciones
/// interfaz plantilla, solo comportamientos de las clases que hereden interfaz
/// NOooooo propiedades q son campos o var y const.
/// /////////////////////////////////////
/// Obligar a cuando cree una base nueva se db especificar cuantas patas
/// tiene el animal
/// 1- opcion en Mamiferos crea un nuevo método.
/// 2- crea interfaz solo para clases que debn tener los métodos-
/// Cada clase desarrolle el método como need.