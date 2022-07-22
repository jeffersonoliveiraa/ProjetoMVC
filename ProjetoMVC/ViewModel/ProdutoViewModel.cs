using ProjetoMVC.Models;
using System;

namespace ProjetoMVC.ViewModel
{
    public class ProdutoViewModel
    {
        
        public int Codigo { get; set; }

        
        public string Descricao { get; set; }

        
        public DateTime DataCadastro { get; set; }

       
        public string Valor { get; set; }

        
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
