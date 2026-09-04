using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Empresa
    {
        public string CNPJ { get; set; }
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateTime dataDoCadastro { get; set; }
        public Boolean ativo { get; set; }
    }
}
