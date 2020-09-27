using System.Threading.Tasks;
using Maxima.Domain;
using Maxima.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maxima.API.Controllers{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClienteController : ControllerBase
    {
        private readonly IMaximaRepository _repo;
        public ClienteController(IMaximaRepository repo){
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var resultado = await _repo.GetAllClientesAsync();
                return Ok (resultado);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na conexão.");
            }
    
    
        }

         // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(Cliente model)
        {
            try
            {
                _repo.Add(model);
                
                if(await _repo.SaveChangesAsync())
                {
                    return Created($"/api/cliente/{model.Cli_Id}", model);
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