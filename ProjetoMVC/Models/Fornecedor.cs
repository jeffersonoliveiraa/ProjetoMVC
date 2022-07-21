using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string NomeContato { get; set; }
    }
}
