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
        public Produto Produto { get; set; }
        public int QtdPedido { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public double ValorTotal { get; set; }
    }
}
