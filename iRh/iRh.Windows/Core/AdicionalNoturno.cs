using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double calcula(double salario)
        {
            var horasDeTrabalho = 220.0;
            var horasNoturnasFeitasNoMes = 0;

           var  valorPorHora = salario / horasDeTrabalho;
           var valorDoAdicional = valorPorHora * 0.20;
           var salarioComAdicional = horasNoturnasFeitasNoMes * (valorPorHora + valorDoAdicional);
           return salarioComAdicional;
        }

    }
}
