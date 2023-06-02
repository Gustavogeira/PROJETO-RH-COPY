using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double calcule(double salario1, double salario2, double salario3 )
        {
            var mediaSalario = 0;
     

            if(mediaSalario <= 1986.36)
            {
               var seguroDesemprego = (mediaSalario * 0.80);
                return seguroDesemprego;
            }
            else if(mediaSalario <= 3280.93)
            {
               var seguroDesemprego = (mediaSalario * 0.50) + 1574.69;
                return seguroDesemprego;
            }
            else
            {
                var seguroDesemprego = 2230.97;
                return seguroDesemprego;
            }
            
        }
    }
}

