import { Produto } from './Produto';

export interface Pedido {
  pedidoId: number;
  valorTotal: number;
  qtdeItem: number;
  valorFrete: number;
  clienteId: number;
  produtoId: number;
  produtosClientesPedido: Produto[];
}
