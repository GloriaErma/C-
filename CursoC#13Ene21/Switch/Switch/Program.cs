﻿using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoge transporte: coche, tren avion");
            string transp = Console.ReadLine();
            switch (transp)
            {
                case "coche":
                    Console.WriteLine("velocidad 100 km/h");
                    break;
                case "tren":
                    Console.WriteLine("velocidad 250 km/h");
                    break;
                case "avion":
                    Console.WriteLine("velocidad 800 km/h");
                    break;
                default:
                    Console.WriteLine("Transporte NA");
                    break;
            }
            ///////////////////////////////////
            ///
            Console.WriteLine("Ingrese Numero Mes:::::::::::");
            int mes = Int32.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes Incorrecto");
                    break;
            }

        }
    }
}