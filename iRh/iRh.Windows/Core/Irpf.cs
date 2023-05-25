using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    public static  class Irpf
    {
        public static double calcula(double salario)
        {
            if(salario <= 1903.98)
            {
                return 0;
            }
            else if(salario <=  2826.65)
            {
                var descontoImpostoDeRenda = (salario / 100) * 7.5 - 142.80;
                return descontoImpostoDeRenda;
            }
            else if(salario <= 3751.05)
            {
                var descontoImpostoDeRenda = (salario / 100) * 15 - 354.80;
                return descontoImpostoDeRenda;
            }
            else if(salario <= 4664.68)
            {
                var descontoImpostoDeRenda = (salario / 100) * 22.5 - 636.13;
                return descontoImpostoDeRenda;
            }
            else if (salario > 4664.68)
            {
                var descontoImpostoDeRenda = (salario / 100) * 27.5 - 869.13;
                return descontoImpostoDeRenda;
            }
            return 0;

        }
    }
}
