using System.Threading.Tasks;
using Maxima.Domain;
using Maxima.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maxima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMaximaRepository _repo;
        public ProdutoController(IMaximaRepository repo){
            _repo = repo;
        }

    
    [HttpGet] 
    public async Task<IActionResult> GetTask()
    {
        try
        {
            var resultado = await _repo.GetAllProdutosAsync();
            return Ok(resultado);
        }
        catch (System.Exception)
        {                
            return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão com o banco de dados!");
        }
    }
    
    [HttpGet("{id}")] 
    public async Task<IActionResult> GetTask(int id)
    {
        try
        {
            var resultado = await _repo.GetProdutosAsyncByID(id);
            return Ok(resultado);
        }
        catch (System.Exception)
        {                
            return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão.");
        }
    }

    
    [HttpPost]
    public async Task<IActionResult> Post(Produto model)
    {
        try
        {
            _repo.Add(model);
            
            if(await _repo.SaveChangesAsync())
            {
                return Created($"/api/produto/{model.Id}", model);
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