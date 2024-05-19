using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatematicas
{
    internal class SEL
    {
        Decimal xop1 { get; set; }
        Decimal yop1 { get; set; }
        Decimal xop2 { get; set; }
        Decimal yop2 { get; set; }

        Decimal resultado { get; set; } 

        public SEL(
            Decimal xop1,
            Decimal yop1,
            Decimal xop2,
            Decimal yop2

            )
        {
            this.xop1 = xop1;
            this.yop1 = yop1;
            this.xop2 = xop2;
            this.yop2 = yop2;
        }

        public void calcularEcuacuacionLineal()
        {
            resultado = ;
        }

    }
}
