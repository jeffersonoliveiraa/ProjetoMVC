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
        [Display(Name = "Codigo")]
        public int Codigo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data do cadastro")]
        public DateTime DataCadastro { get; set; }
        public decimal Valor { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
