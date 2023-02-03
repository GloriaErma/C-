using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum video 58 ");
            Estaciones alergia = Estaciones.Primavera;
            Console.WriteLine("En el enum es: " + alergia);
            // ERROR Enum Estaciones NO es tipo String
            // es tipo Enum.......
            //String alergiaS = Estaciones.Primavera;
            //PARA pasar a String
            String alergia_S = alergia.ToString();
            Console.WriteLine("En Tipo String es: " + alergia_S);
            // guardar nulo en un tipo enum
            // ERROR igual q objetos
            ////Estaciones alergia = null;
            Estaciones? alergia_N = null;  // OK.
            /////////////////////////////////////////////////////////
            ///
            Bonos Antonio = Bonos.bueno;
            Console.WriteLine(Antonio);
            double bonoAntonio = (double)Antonio;  // valor
            Console.WriteLine( bonoAntonio );
            double salarioAntonio = 1500 + bonoAntonio;
            Console.WriteLine(salarioAntonio);
            //////////////////////
            ///  
            Bonos Antonio1 = Bonos.bajo;
            Console.WriteLine(Antonio1);
            double bonoAntonio1 = (double)Antonio1;  // valor
            Console.WriteLine(bonoAntonio1);
            double salarioAntonio1 = 1500 + bonoAntonio1;
            Console.WriteLine(salarioAntonio1);

        }
    }
    // declaraciones Enum en namespace
    // valor numerico c/u:  0,     1,     2,       3
    enum Estaciones { Primavera, Verano, Otoño, Invierno }
    // valor automatico
    enum Bonos { bajo=500, normal=1000, bueno=1500, extra=3000}


}
/// Enum
/// Conjunto Constantes con nombre.
/// "enum" + NombreEnum + { K1,K2...};  *****NO lleva el TIPO
/// sirven para representar y manejar valores k
/// Representar estaciones del año, meses del año,
/// Estaciones { primavera, verano, otoño, invierno}
/// //////////
/// habitual crear en Namespace
/// ////////////////////////
/// 