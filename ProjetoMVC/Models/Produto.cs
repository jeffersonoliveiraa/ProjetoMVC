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
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1,10, ErrorMessage = "Valor fora do permitido")]
        public int Quantidade { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
