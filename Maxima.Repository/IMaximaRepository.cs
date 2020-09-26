using System.Threading.Tasks;
using Maxima.Domain;

namespace Maxima.Repository
{
    public interface IMaximaRepository
    {
         //CRUD
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;

         //Salvar Alterações
         Task<bool> SaveChangesAsync();

         //Busca Todos os Pedidos
         Task<Pedido[]> GetAllPedidosAsync();

         //Busca todos os Clientes
         Task<Cliente[]> GetAllClientesAsync();


         //Busca todos os produtos
         Task<Produto[]> GetAllProdutosAsync();


         //Busca Produtos por ID
         Task<Produto> GetProdutosAsyncByID(int id);

         
    }
}