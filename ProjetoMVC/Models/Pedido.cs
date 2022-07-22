using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public int Codigo { get; set; }

        [Display(Name = "Data do Pedido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        [Display(Name = "Quantidade")]
        public int QtdPedido { get; set; }

        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }

        public Fornecedor Fornecedor { get; set; }

        [Display(Name = "Valor Total")]
        public float ValorTotal { get; set; }
    }
}
