using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Pis
    {
       public static double calcula(double salario, double mesesTrabalhados)
        {
            const double salarioMinimo = 13020.00;
            var mediaSalario = salario / mesesTrabalhados;
            if(salario > 1320)
            {
                var resultado = (0);

                return resultado;
            }
            else
            {
                var resultado = (salarioMinimo / mesesTrabalhados) * mesesTrabalhados;

                return resultado;
            }
        }
    }
}
