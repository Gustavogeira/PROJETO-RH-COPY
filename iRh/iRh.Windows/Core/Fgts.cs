using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Fgts
    {
        public static double calcula(double salario)
        {


            double valorTotal = (salario / 100) * 8;
            return valorTotal;
        }
    }
}
