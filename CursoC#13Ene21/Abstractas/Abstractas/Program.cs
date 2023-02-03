using System;

namespace Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clases Abstractas Video 52,53!");
            Lagartija objLagarto1 = new Lagartija("Juancho");
            objLagarto1.respirar();
            Humano objHumano1 = new Humano("Juan");
            objHumano1.respirar();
            ///
            objLagarto1.getNombre("Largarto");
            objHumano1.getNombre("Humano");




        }
    }
    
    interface IMamiferoTerrestre
    {
        int NumeroPatas();
    }
    /// <summary>
    ///  Interfaz hace OPCIONAL que las clases la implementen
    /// </summary>
    interface IAnimalDeportes
    {
        string TipoDeporte();
        Boolean EsOlimpico();
    }
    /// <summary> Ambiguedad
    /// Método de Interfaz iguales con diferente funcionalidad
    /// </summary>
    interface ISaltoPata
    {
        int NumeroPatas();
    }
    // SI tiene método Abstracto su clase db ser Abstracta
    // SE define Abstracto para obligar a desarrollar método getNombre() en la clase que 
    ///  NO hereda de animales  
    ///  NO interfaz Animales,  tendria q desarrollar el método en todas las clases /// 
    abstract class Animales
    {
        public void respirar() => Console.WriteLine("RESPIRO");
        public abstract void getNombre(string obj);
    }
    class Lagartija : Animales
    {
        public Lagartija(String nombre) => nombreReptil = nombre;
        public override void getNombre(string obj) => Console.WriteLine($" El nombre del REPTIL {obj} es:: " + nombreReptil);
        private String nombreReptil;
    }

    class Mamiferos : Animales
    {

        public Mamiferos(String nombre) => nombreSerVivo = nombre;
        //Elimina método respirar, ya esta desarrollado en Animales 
        //public void respirar() = > Console.WriteLine("RESPIRO");
        
        public virtual void pensar() => Console.WriteLine("pensamiento Delfín");

        public void cuidaCrias() => Console.WriteLine("CUIDAR CRIAS");
        // se sobreescribe getNombre método abstracto
        public override void getNombre(string obj) => Console.WriteLine($" El nombre del MAMIFERO {obj} es:: " + nombreSerVivo);
        // campo de Clase encapsulado
        private String nombreSerVivo;

    }

    // clases que heredan de Mamiferos
    // implemente Interfaz
    // orden::  "class" + NombreClase + ":" + NombreInterfaz;
    // SI Herencia:: "class" + NombreClase + ":" + NombreInterfaz + "," + NombreInterfaz;
    // UNA CLASE SOLO TIENE UNA UNICA HERENCIA DE CLASE.
    class Caballo : Mamiferos, IMamiferoTerrestre, IAnimalDeportes, ISaltoPata
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) { }

        //public void galopar() => Console.WriteLine("GALOPAR");

        public void galopar()
        {
            respirar();   // accede al declarar protected void respirar() en Mamiferos
        }
        // DB implementar método Interfaz
        // Nombre Método, tipo dato return, parametros y tipo === definidos en Interfaz
        /// <summary>
        /// Manejo AMBIGUEDAD:
        /// PRECINDIR MODIFICADOR ACCESO, = ELIMINAR PUBLIC
        /// INCLUIR NOMBRE DE INTERFACE ANTES DEL NOMBRE MÉTODO con PUNTO "."
        /// </summary> Nomenclatura punto****************************************
        ////////////public 
        int IMamiferoTerrestre.NumeroPatas() => 4;
        //{
        //return 4;
        //}
        int ISaltoPata.NumeroPatas() => 2;
        public string TipoDeporte() => "Hipica";
        public Boolean EsOlimpico() => true;
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }

        // pERO SI TODOS DEBEN PENSAR IGUAL SE DECLARA EL MÉTODO SELLADO EN HUMANO.
        1- public sealed override void pensar() => Console.WriteLine("PENSAR HUMANO");

        2- public override void pensar() => Console.WriteLine("PENSAR HUMANO");

    }
    // Método pensar() de Adolecente NO es el mismo de Humano, 
    // se db sobre escribir
    // pERO SI TODOS DEBEN PENSAR IGUAL SE DECLARA EL MÉTODO SELLADO EN HUMANO.
    // y SE PUEDE BORRAR CLASE ADOLECENTE...
    class Adolecente : Humano
    {
        public Adolecente(String nombreAdolecente) : base(nombreAdolecente)
        { }
        public override void pensar() => Console.WriteLine("PENSAR HORMONAL ADOLECENTE");

    }
     //  NO permite extender NI heredar de Gorila
    //  sealed class Gorila : Mamiferos, IMamiferoTerrestre
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
        public Ballena(String nombreBallena) : base(nombreBallena) // llamar contructor padre
        {
            Console.WriteLine();
        }
        public void nadar()
        {
            Console.WriteLine("CAPAZ NADAR");
        }

    }
    //  NO permite extender NI heredar de Gorila
    //  sealed class Gorila : Mamiferos, IMamiferoTerrestre
    //class Chimpance : Gorila
    //{
    //    public Chimpance(String nombreChimpance ) : base( nombreChimpance)
    //    {
    //    }
    //}     

}
////////////////////////////////////////////////////////////////
/// Class abstractas
/// Herencia SuperClase, métodos:  respirar(), pensar(), getNombre(), cuidarCrias();
/// SubClases, Ballena- métodos: nadar();
/// 
/// Caballo: galopar(),
/// Humano: overrride pensar() -->  Reescribirlo e invalidar Mamiferos.pensar,
/// Gorila: trepar();
/// ////////////////////////////////////
/// Mamiferos terrestres, cuantas patas tienen?
/// NO pueden incluirse método por que lo hereda Ballena.
/// Desarrollar NumeroPatas en Caballo, Humano y Gorila, obliga a crear 3 veces ese método!!!!!
/// X eso creamos Interfaz: IMamiferosTerrestres con método NumeroPatas.
/// Se implemento esta Interfaz en Caballo, Humano y Gorila.
/// Obliga a desarrollar el método en estas clases.
/// ///////////////////////////////
/// Representar Lagartiga, NO es Mamiferos, huevos, NO cuidan crias
/// Crear clase Animales: Mamiferos y Lagartijas.
/// Animales con método: respirar() en Mamiferos = Lagartijas y getNombre() Mamiferos <> Lagartijas
/// Método getNombre puede convertirse en Abstracto crearlo en Clase Animales.
/// Método Abstracto es solo tiene una declaracion y NO esta desarrollado.
/// Si Lagartija y Mamiferos
/// Cuando se hereda de una clase Abstracta, el método Abstrcto esta obligado ha desarrollarlo.
/// En Lagartija es obligado a desarrollar getNombre() q es Método Abstracto.
/// Si en una clase declara Método Abstracto, obligatoriamente la clase es abstracta.
/// SI se crea un método Abstrato getNombre() en La clase Animales, esta clase db ser Abtracta
/// ////////////////////
/// CLases mas especializadas son la de base, Directores
/// son mas abstractas a medida que subimos en herencia, personas
/// ///////////////////////////////////////////////////////////////////////////////
/// clases selladas   * sealed Classes
/// NO se puede heredar
/// NO se db extender en el futuro.
/// Método sellado, Adiciona clase adolecente, y NO db sobreescribe el método pensar() qu esta
/// en Humano, se declara sealed... Humano.pensar()
/// impide herencia y sobreescritura de métodos.
/// 