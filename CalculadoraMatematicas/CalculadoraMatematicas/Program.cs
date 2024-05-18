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
                2-Salir
                """;
            Console.WriteLine(menu);
        }


        static void Main(string[] args) 
        {
            menu();

           

            Suma suma = new Suma(1,1);

            suma.sumar();
     

            Console.WriteLine("END 0");
        }
    }
}