using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double calcule(double salario)
        {
            var mediaSalario = 0;
            var seguroDesemprego = 0;
            var salario1 = 0;
            var salario2 = 0;
            var salario3 = 0;

            mediaSalario = salario1 + salario2 + salario3 / 3;

            if(mediaSalario <= 1986.36)
            {
                seguroDesemprego = double.Parse(mediaSalario * 0.80);
                return seguroDesemprego;
            }
            else if(mediaSalario <= 3280.93)
            {
                seguroDesemprego = double.Parse(mediaSalario * 0.50) + 1574.69;
                return seguroDesemprego;
            }
            else
            {
                seguroDesemprego = double.Parse(2230.97);
                return seguroDesemprego;
            }
            return 0;
        }
    }
}
