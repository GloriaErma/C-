using System;

namespace CondicionIF
{
    class Program
    {
        static void Main(string[] args)
        {
            string car = "NO";            
            //Console.WriteLine("Hello World!");
            bool frio;
            frio = false;
            Console.WriteLine(frio);
            // Negacion !!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine(!frio);
            // Operador Comparacion   VIDEO: 14
            //  ==   igual
            //  !=   diferente
            //  <
            //  >
            //  >= 
            //  <=
            //  &&
            //  ||
            // FLUJO EJECUCION ARRIBA a ABAJO
            int edad = 15;
            Console.WriteLine("Vamos a evaluar si eres > edad!!!!!!!!!!!!!!!!!!!!!");
            if(edad >= 18)
                    // se puede obviar {}  SI solo es una linea de codigo HASTA EL ;
                Console.WriteLine("SIIIIIIIIIIIII  Eres > edad");
                    // se puede obviar {} SI solo es una linea de codigo HASTA EL ;
            //////////////////////////////////
            ///
            bool carnet = false;
            if(carnet) Console.WriteLine("SIIIIIIIIIIII  Tienes carnet");
            else       Console.WriteLine("NOOOOOOOOOOOO  Tienes carnet");
            //////////////////////////////////
            ///  PASAR A ENTERO
            Console.WriteLine("<<<<<<Ingrese edad::");
            int ed  = Int32.Parse(Console.ReadLine());
            Console.WriteLine("<<<<<<Confirme edad::");
            int edP = int.Parse(Console.ReadLine());
            if (edP >= 18)
            {
                Console.WriteLine("Tienes Carnet SI/NO  ??");
                car = Console.ReadLine();
            }
            if (edP >= 18 && car == "SI") Console.WriteLine("SI puedes");
            else                          Console.WriteLine("NO puedes");
            //////////////////////////////////
            ///  String.Comparte
            if (edP < 18) Console.WriteLine("NOOOO puedes");
            else
            {
                Console.WriteLine("Tienes Carnet SI/NO  ??");
                car = Console.ReadLine();
                int comparacion = String.Compare(car, "si", true);
                if (comparacion == 0) Console.WriteLine("SI puedes");
                else Console.WriteLine("NO puedes");
            }
            //////////////////////////////////
            ///
            Console.WriteLine("Ingrese primer" );
            float p1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo");
            float p2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer");
            float  p3 = Int32.Parse(Console.ReadLine());
            if (p1>=5 || p2>=5 || p3>=5)
                Console.WriteLine("La nota media es" + (p1+p2+p3)/3);
            else Console.WriteLine("Volver");
            //////////////////////////////////
            ///  Anidados
            if (edad < 18) Console.WriteLine("Niño");
            else if (edad < 30) Console.WriteLine("Joven");
            else if (edad < 60) Console.WriteLine("Maduro");
            else Console.WriteLine("Cuidate");
            //////////////////////////////////
            ///  Switch
            ///  evalua int, char, string
            ///  float y double utilizar IF
            ///  case tienen expresion constantes
            ///  todos los case db llevar break;
            ///  utilizar return y throw
            ///  


        }

    }
}
