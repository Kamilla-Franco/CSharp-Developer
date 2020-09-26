using System.Collections.Generic;

namespace Maxima.Domain
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public decimal ValorTotal { get; set; }
        public int QtdeItem { get; set; }

        public decimal ValorFrete { get; set; }

        
        public int ClienteId { get; set; }       
        public Cliente Cliente { get;}

         public int ProdutoId { get; set; }
        public Produto Produto { get;}

        public List<ProdutosClientesPedido> ProdutosClientesPedidos {get;}



    }
}