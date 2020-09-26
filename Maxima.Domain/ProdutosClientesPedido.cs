namespace Maxima.Domain
{
    public class ProdutosClientesPedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public Pedido Pedido { get;}
        public Cliente Cliente { get;}
        public Produto produto { get;}
    }
}