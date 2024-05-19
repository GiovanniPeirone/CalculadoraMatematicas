using CalculadoraMatematicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Peogram
    {
        static void menu()
        {
            string menu = """
                1-Funcion Lineal
                2-suma
                3-Salir
                """;
            Console.WriteLine(menu);
        }


        static void Main(string[] args) 
        {
            while (true)
            {
                menu();
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 3)
                {
                    break;
                }
                else if (opcion == 1)
                {
                    Console.WriteLine("Balores de OP 1");
                    Console.WriteLine("x:");
                    Decimal xop1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("y:");
                    Decimal yop1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Balores de OP 2");
                    Console.WriteLine("x:");
                    Decimal xop2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("y:");
                    Decimal yop2 = Convert.ToDecimal(Console.ReadLine());





                    SEL operacion = new SEL(xop1, yop1 , xop2, yop2);

                    operacion.calcularEcuacuacionLineal();




                    if (2*3 == 3 * 2) { }





                }
                else if (opcion == 2)
                {
                    Suma suma = new Suma(1, 1);

                    suma.sumar();
                }
            }

     

            Console.WriteLine("END 0");
        }
    }
}