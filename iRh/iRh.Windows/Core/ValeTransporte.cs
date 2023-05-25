using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static  class ValeTransporte
    {
        public static double Calcula(double salario)
        {
            double descontoValeTransporte = 0;

            descontoValeTransporte = salario * 0.06;
            return descontoValeTransporte;
        }
    }
}
