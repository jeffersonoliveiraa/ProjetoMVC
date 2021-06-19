using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatorio!")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
