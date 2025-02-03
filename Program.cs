using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /*Codigo Escrito por:
        Axel Enrique Cerritos Torres
        Cristopher Mauricio Cerritos Espino
        Carlos Alfredo Vejar Noguera
        Christopher Alexander González Alvarado
        Jeferson Alessandro Velásquez Rivera
         */
namespace Practica_LogicaProgra
{
    internal class Program
    {
        public static int func_hamburguesa()
        {

            Console.WriteLine("1. Hamburguesa de Rez $5.99");
            Console.WriteLine("2. Hamburguesa de Pollo $4.99");

            int tipo_hamburguesa = Int32.Parse(Console.ReadLine());


            return tipo_hamburguesa;
        }

        public static int func_papas()
        {
            Console.WriteLine("Que tamaño de papas desearia");

            string[] opcion_papas = { "1. Pequeña $1.00", "2. Mediana $1.50", "3. Grande $2.25" };

            for (int i = 0; i < opcion_papas.Length; i++)
            {

                Console.WriteLine(opcion_papas[i]);
            }

            int papas_tamano = Int32.Parse(Console.ReadLine());

            return papas_tamano;
        }

        public static int func_bebidas()
        {

            Console.WriteLine("Que tamaño de bebida desearia");

            string[] opcion_bebidas = { "1. Pequeña $1.00", "2. Mediana $1.75", "3. Grande $2.50" };

            for (int i = 0; i < opcion_bebidas.Length; i++)
            {

                Console.WriteLine(opcion_bebidas[i]);
            }

            int bebidas_tamano = Int32.Parse(Console.ReadLine());

            return bebidas_tamano;
        }

        static void Main(string[] args) {

            Console.WriteLine("Buen dia que desearia ordener hoy");

            Console.WriteLine("Seleccione la opcion a ordenar");

            string[] orden = { "Hamburguesa de Rez $5.99", "Papas Pequeñas $1.00", "Bebida Pequeña $1.00" };

            double precio_hamburguesa;

            int opcion_hamburguesa = func_hamburguesa();

            switch (opcion_hamburguesa)
            {
                case 1:
                    precio_hamburguesa = 5.99;
                    orden[0] = "Hamburguesa de Rez $5.99";

                    break;
                case 2:
                    precio_hamburguesa = 4.99;
                    orden[0] = "Hamburguesa de Pollo $4.99";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    return;
            }

            double precio_papas;

            int opcion_papas = func_papas();
            switch (opcion_papas)
            {
                case 1:
                    precio_papas = 1.00;
                    orden[1] = "Papas pequeñas $1.00";
                    break;
                case 2:
                    precio_papas = 1.50;
                    orden[1] = "Papas medianas $1.50";
                    break;
                case 3:
                    precio_papas = 2.25;
                    orden[1] = "Papas grandes $2.25";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    return;
            }

            double precio_bebida = 0;

            int opcion_bebida = func_bebidas();

            switch (opcion_bebida)
            {
                case 1:
                    precio_bebida = 1.00;
                    orden[2] = "Bebida pequeña $1.00";
                    break;
                case 2:
                    precio_bebida = 1.75;
                    orden[2] = "Bebida mediana $1.75";
                    break;
                case 3:
                    precio_bebida = 2.50;
                    orden[2] = "Bebida grande $2.50";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            double total = precio_hamburguesa + precio_papas + precio_bebida;

            Console.WriteLine("El total a pagar es: $" + total);

            Console.WriteLine("Dinero a entregar en caja:");

            double dinero_cliente = Convert.ToDouble(Console.ReadLine());

            double cambio = dinero_cliente - total;
            Console.WriteLine("Su cambio es: $" + cambio);

            Console.WriteLine("Su orden Completa seria:");

            for (int i = 0; i < orden.Length; i++)
            {
                Console.WriteLine(orden[i]);
            }

            Console.WriteLine("Total a pagar: $" + total);
            Console.WriteLine("Dinero entregado: $" + dinero_cliente);
            Console.WriteLine("Cambio: $" + cambio);

            Console.WriteLine("Gracias por su compra!");
            





        }
    }
}
