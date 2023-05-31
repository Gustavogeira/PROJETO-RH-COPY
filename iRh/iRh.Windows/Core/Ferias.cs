using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    public static class Ferias
    {
        public static double calcula(double salario)
        {
            var salarioBruto = 0;
           
            var valorFerias = salarioBruto / 3 + salarioBruto -  Inss.Calcula(salarioBruto) - Irpf.calcula(salarioBruto);

            return valorFerias;
            
        }
    }
}
