using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Pedido
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Data do Pedido")]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("Produtos")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        [Display(Name = "Quantidade")]
        public int QtdPedido { get; set; }

        [Display(Name = "Fornecedor")]
        [ForeignKey("Fornecedores")]
        public int FornecedorId { get; set; }

        public Fornecedor Fornecedor { get; set; }

        [Display(Name = "Valor Total")]
        public string ValorTotal { get; set; }
    }
}
