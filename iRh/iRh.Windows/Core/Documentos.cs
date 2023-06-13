using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    internal class Documentos
    {
        public string Id { get; set; }
        public string Descrição { get; set; }
        

        public List<Documentos> ObterTodosDocumentos()
        {
            var listadeDocumentos = new List<Documentos>();

            listadeDocumentos.Add(new Documentos { Id = "1", Descrição = "Carteira Nacional de Habilitação " });
            listadeDocumentos.Add(new Documentos { Id = "2", Descrição = "Registro Geral "  });
            listadeDocumentos.Add(new Documentos { Id = "3", Descrição = "Registro Nacional de Estrangeiro " });
            listadeDocumentos.Add(new Documentos { Id = "4", Descrição = "Cédula de Identidade de Estrangeiro " });
            listadeDocumentos.Add(new Documentos { Id = "5", Descrição = "Passaporte " });
            listadeDocumentos.Add(new Documentos { Id = "6", Descrição = "Protocolo de refúgio" });
            listadeDocumentos.Add(new Documentos { Id = "7", Descrição = "Carteira de Registro Nacional Migratório" });
            listadeDocumentos.Add(new Documentos { Id = "8", Descrição = "Carteira de Trabalho" });
            listadeDocumentos.Add(new Documentos { Id = "9", Descrição = "Certidão de Nascimento" });
            listadeDocumentos.Add(new Documentos { Id = "10", Descrição = "Título Eleitoral" });
            listadeDocumentos.Add(new Documentos { Id = "11", Descrição = "Cadastro de Pessoas Físicas " });
            listadeDocumentos.Add(new Documentos { Id = "12", Descrição = "Carteira de Identidade " });
            listadeDocumentos.Add(new Documentos { Id = "13", Descrição = "Carteira de Identificação Funcional " });
            return listadeDocumentos;


        }
    }
}
