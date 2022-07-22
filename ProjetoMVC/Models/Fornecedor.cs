using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Informe a Razão Social do Fornecedor", AllowEmptyStrings = false)]
        public string RazaoSocial { get; set; }
        
        [Display(Name = "CNPJ")]
        [StringLength(14, MinimumLength = 14)]
        [Required(ErrorMessage = "Informe o CNPJ do Fornecedor", AllowEmptyStrings = false)]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "A UF é obrigatória", AllowEmptyStrings = false)]
        public string UF { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O nome do responsavel é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string NomeContato { get; set; }
    }
}
