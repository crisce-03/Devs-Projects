using System;

namespace Practica_LogicadeProgra
{
    internal class Program
    {
        public static double func_calculo(double salarioDescuentos)
        {
            double isr = 0;

            if (salarioDescuentos >= 0.01 && salarioDescuentos <= 472.00)
            {
                Console.WriteLine("TRAMO I: No aplica, no paga renta");
            }
            else if (salarioDescuentos >= 472.01 && salarioDescuentos <= 895.24)
            {
                isr = (((salarioDescuentos - 472) * 0.1) + 17.67);
                Console.WriteLine("TRAMO II: El impuesto sobre la renta a pagar es de: " + isr.ToString("F2"));
            }
            else if (salarioDescuentos >= 895.25 && salarioDescuentos <= 2038.10)
            {
                isr = (((salarioDescuentos - 895.24) * 0.2) + 60);
                Console.WriteLine("TRAMO III: El impuesto sobre la renta a pagar es de: " + isr.ToString("F2"));
            }
            else if (salarioDescuentos >= 2038.11)
            {
                isr = (((salarioDescuentos - 2038.10) * 0.3) + 288.57);
                Console.WriteLine("TRAMO IV: El impuesto sobre la renta a pagar es de: " + isr.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Dato no válido");
            }

            return Math.Round(isr, 2);
        }

        public static double cal_aguinaldo(double salario, double time, int opcion_time)
        {
            double aguinaldo=0;

            double salario_diario;

            if(opcion_time==3)
            {
                if (time >=1 & time <3)
                {
                    aguinaldo = ((salario / 30) * 15);
                }else if (time < 10)
                {
                    aguinaldo = ((salario / 30) * 19);
                }
                else if(time>10)
                {
                    aguinaldo = ((salario / 30) * 21);
                }
            }else if (opcion_time == 2)
            {
                salario_diario = salario / 30;

                aguinaldo=((15*salario_diario * time)/12);
            }else if(opcion_time == 1)
            {
                salario_diario = salario / 30;

                aguinaldo = ((15 * salario_diario * time)/360);
            }
            else
            {
                Console.WriteLine("La opcion ingresada no es valida");
            }

            return aguinaldo;
        }

        static void Main(string[] args)
        {
            double salarioNominal, salarioDescuentos, salarioNeto,aguinaldo,time_work=0;

            

            while (true)
            {
                Console.WriteLine("Ingrese su salario: ");
                salarioNominal = Convert.ToDouble(Console.ReadLine());


                Console.Write("Ingrese la fecha en que comenzo a trabajar (YYYY-MM-DD): ");
                string fecha_inicio = Console.ReadLine();

                Console.Write("Ingrese la fecha en que dejo de trabajar o la actual (YYYY-MM-DD): ");
                string fecha_final = Console.ReadLine();

                if (DateTime.TryParse(fecha_inicio, out DateTime fecha1 ) & DateTime.TryParse(fecha_final, out DateTime fecha2))
                {
                    TimeSpan diferencia=fecha2 - fecha1;
                    time_work = diferencia.Days;
                }
                else
                {
                    Console.WriteLine("El formato de la fecha no es válido.");
                }

                Console.WriteLine(time_work);







                double afp = Math.Round(salarioNominal * 0.0725, 2);
                double isss = Math.Round(salarioNominal * 0.03, 2);
                if (isss > 30)
                {
                    isss = 30;
                }

                salarioDescuentos = Math.Round(salarioNominal - (afp + isss), 2);

                Console.WriteLine("El descuento de AFP es de: " + afp.ToString("F2"));
                Console.WriteLine("El descuento de ISSS es de: " + isss.ToString("F2"));
                Console.WriteLine("Su salario con descuentos es de: " + salarioDescuentos.ToString("F2"));

                double isr = func_calculo(salarioDescuentos);
                salarioNeto = salarioDescuentos - isr;

                Console.WriteLine("Su salario Neto mensual es de: " + salarioNeto.ToString("F2"));

                
                
              

                Console.WriteLine("¿Desea calcular otro salario? (1 = Sí, 0 = No): ");
                int respuesta;
                while (!int.TryParse(Console.ReadLine(), out respuesta) || (respuesta != 1 && respuesta != 0))
                {
                    Console.WriteLine("Dato ingresado no válido. Intente nuevamente (1 = Sí, 0 = No): ");
                }

                if (respuesta == 0)
                {
                    Console.WriteLine("Feliz día, ¡Adiós! :)");
                    break;
                }
            }
        }
    }
}


