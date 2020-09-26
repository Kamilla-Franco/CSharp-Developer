using System.Linq;
using System.Threading.Tasks;
using Maxima.Domain;
using Microsoft.EntityFrameworkCore;

namespace Maxima.Repository
{
  public class MaximaRepository : IMaximaRepository
  {
        public MaximaContext _context { get; }

        public MaximaRepository(MaximaContext context){
            
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        //CRUD
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }   

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }



        public async Task<Cliente[]> GetAllClientesAsync()
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.AsNoTracking().OrderBy(c => c.Cli_Id);
            return await query.ToArrayAsync();
        }

        public async Task<Pedido[]> GetAllPedidosAsync()
        {
            IQueryable<Pedido> query = _context.Pedidos;
            query = query.AsNoTracking().OrderBy(p => p.PedidoId);
            return await query.ToArrayAsync();
        
        }

        public async Task<Produto[]> GetAllProdutosAsync()
        {
        IQueryable<Produto> query = _context.Produtos;
            query = query.AsNoTracking().OrderBy(p => p.ProdutoId);
            return await query.ToArrayAsync();
        }

        public async Task<Produto> GetProdutosAsyncByID(int id)
        {
        IQueryable<Produto> query = _context.Produtos;
            query = query.AsNoTracking().Where(i => i.ProdutoId == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return(await _context.SaveChangesAsync()) >0;
        }

    }   
    
  
}