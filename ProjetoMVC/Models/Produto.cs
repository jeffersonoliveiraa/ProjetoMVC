using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Código do produto é obrigatório", AllowEmptyStrings = false)]
        public int Codigo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Nome do produto é obrigatório", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

        [Display(Name = "Data do cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Insira o preço do produto", AllowEmptyStrings = false)]
        public string Valor { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
