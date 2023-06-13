using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string sigla  { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listadeEstados = new List<Estados>();

            listadeEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rondônia",
                sigla = "RO"
            });
            listadeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                sigla = "AC"
            });
            return listadeEstados;
        }

    }
}
