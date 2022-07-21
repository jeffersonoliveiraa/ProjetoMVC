using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public DateTime DataPedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int QtdPedido { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
