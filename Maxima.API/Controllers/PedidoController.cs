using System.Threading.Tasks;
using Maxima.Domain;
using Maxima.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maxima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {        
        private readonly IMaximaRepository _repo;
        public PedidoController(IMaximaRepository repo){
            _repo = repo;
        }

        
        
        [HttpGet] 
        public async Task<IActionResult> GetTask()
        {
            try
            {
                var resultado = await _repo.GetAllPedidosAsync();
                return Ok(resultado);
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão.");
            }
        }  

        
        [HttpPost]
        public async Task<IActionResult> Post(Pedido model)
        {
            try
            {
                _repo.Add(model);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Created($"/api/pedido/{model.PedidoId}", model);
                }                
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão.");
            }

            return BadRequest();      
       }   
    }
}