using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static  class HoraExtra
    {
        public static double calcule(double salario)
        {
            var horasFeitas = 0;
            var valorDaHoraTrabalhada = salario / 220;
            var valorDaHoraExtra = valorDaHoraTrabalhada * 0.20;
            var valorReceber = valorDaHoraExtra * valorDaHoraTrabalhada * horasFeitas;

            return horasFeitas;
        }
    }
}
