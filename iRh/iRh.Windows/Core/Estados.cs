using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla  { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listadeEstados = new List<Estados>();

            listadeEstados.Add(new Estados { Sigla = "RO", Nome = "Rondônia" });
            listadeEstados.Add(new Estados { Sigla = "AC", Nome = "Acre" });
            listadeEstados.Add(new Estados { Sigla = "ES", Nome = "Espírito Santo" });
            listadeEstados.Add(new Estados { Sigla = "BA", Nome = "Bahia" });
            listadeEstados.Add(new Estados { Sigla = "AL", Nome = "Alagoas" });
            listadeEstados.Add(new Estados { Sigla = "AP", Nome = "Amapá" });
            listadeEstados.Add(new Estados { Sigla = "AM", Nome = "Amazonas" });
            listadeEstados.Add(new Estados { Sigla = "CE", Nome = "Ceará" });
            listadeEstados.Add(new Estados { Sigla = "DF", Nome = "Distrito Federal" });
            listadeEstados.Add(new Estados { Sigla = "GO", Nome = "Goiás" });
            listadeEstados.Add(new Estados { Sigla = "MA", Nome = "Maranhão" });
            listadeEstados.Add(new Estados { Sigla = "MT", Nome = "Mato Grosso" });
            listadeEstados.Add(new Estados { Sigla = "MS", Nome = "Mato Grosso Do Sul" });
            listadeEstados.Add(new Estados { Sigla = "MG", Nome = "Minas Gerais" });
            listadeEstados.Add(new Estados { Sigla = "PA", Nome = "Pará" });
            listadeEstados.Add(new Estados { Sigla = "PB", Nome = "Paraíba" });
            listadeEstados.Add(new Estados { Sigla = "PR", Nome = "Paraná" });
            listadeEstados.Add(new Estados { Sigla = "PE", Nome = "Pernambuco" });
            listadeEstados.Add(new Estados { Sigla = "PI", Nome = "Piauí" });
            listadeEstados.Add(new Estados { Sigla = "RJ", Nome = "Rio De Janeiro" });
            listadeEstados.Add(new Estados { Sigla = "RN", Nome = "Rio Grande Do Norte" });
            listadeEstados.Add(new Estados { Sigla = "RS", Nome = "Rio Grande Do Sul" });
            listadeEstados.Add(new Estados { Sigla = "RR", Nome = "Roraima" });
            listadeEstados.Add(new Estados { Sigla = "SC", Nome = "Santa Catarina" });
            listadeEstados.Add(new Estados { Sigla = "SP", Nome = "São Paulo" });
            listadeEstados.Add(new Estados { Sigla = "SE", Nome = "Sergipe" });
            listadeEstados.Add(new Estados { Sigla = "TO", Nome = "Tocantins" });
            return listadeEstados;
        }

    }
}
