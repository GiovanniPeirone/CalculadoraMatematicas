using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatematicas
{
    internal class Suma
    {
        int n1 { get; set; }

        int n2 { get; set; }


        public Suma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }


        public void sumar()
        {
            Console.WriteLine(n1 + n2);
        }

    }
}


