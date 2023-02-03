using System;

namespace Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Coches");
            // nombre de la clase, nombre objeto instancia, "= new", nombre constructor()
            Coche objCoche0 = new Coche();
            Coche objCoche1 = new Coche();
            // cuantas ruedas tienen objCoche0.ruedas SI es declarada propiedad public
            // se db crear metodo acceso.
            //Console.WriteLine(objCoche0.ruedas); si es public ruedas
            Console.WriteLine(); //metodo get
            // no permite modificar propiedad ruedas... 
            //objCoche0.ruedas = 27;
            Console.WriteLine($" Información objCoche0.getInfo(): {objCoche0.getInfo()}");
            Console.WriteLine($" Información objCoche1.getInfo(): {objCoche1.getInfo()}");
            // sobrecarga contructor
            Coche objCoche2 = new Coche(4500.25, 1200.35);
            Console.WriteLine($" Información objCoche2.getInfo(): {objCoche2.getInfo()}");
            // llamar primero métodos getters que setters
            //objCoche2.setExtras(true, "cuero");   Inicialmente Se declara tapiceria = "tela" en constructores.
            objCoche2.setExtras(true, "cuero");  // this en campo clase

            Console.WriteLine(objCoche2.getExtras());
        }
    }
    partial class Coche
    {
        //propiedades y metodos<<<<<>
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;  // tela, cuero...
        // contructor tiene mismo nombre q clase, NO devuelve dato, NO es void, NO es return.
        // db ser public, db tener zona parametros.
        // entre llaves se define estado inicial del constructor.
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
            //climatizador = true;  establecer a cada clase de coche SI o NO método setter
            // para establecere propiedades
        }
        public Coche(double largoD, double anchoD)
        {
            ruedas = 4;
            largo = largoD;
            ancho = anchoD;
            tapiceria = "Tela";
        }
        // SI NO tiene constructor TIene contructor X defecto 
        // hay constructor public coche sin parametros
        // public coche {}

    }
    //===========================================================================================================
    partial class Coche
    {
        // métodos getter dan información
        //public int getRuedas()
        //{
        //    return ruedas;
        //}
        // métodos que devuelve información

        public String getInfo()
        {
            return "Información:\n" + "  ruedas: " + ruedas + "  largo: " + largo + "  ancho: " + ancho;

        }
        ////////////////////////////////////////7
        /// Sobrecarga Contructor
        /// vari52os métodos con diferente  número de parámetros
        /// 
        
        /// ///////////////////////////////////
        // método setter NO devuelve valor: void, NO lleva return;
        // ambiguedad: Cuando los parametros del metodo son iguales a Campo Clase
        // diferencia this en campo de clase.
        public void setExtras(bool climatizador, String tapiceria)
        {
            //climatizador = parametro_climatizador;
            //tapiceria = prametro_tapiceria;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        public String getExtras()
        {
            return "Extras del coche: \n" +" Tapiceria: "+ tapiceria + "    Climatizador:" + climatizador;
        }

    }

}
//////////////////////////////7777777777777777777777777777
/// Métodos getters y setters
/// 
/// dividir clse coche: 1- sobrecarga constructores
