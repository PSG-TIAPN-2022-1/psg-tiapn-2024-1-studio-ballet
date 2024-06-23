using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.EndereçoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndereçoController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IEndereçoInterface _endereçoInterface;
        public EndereçoController(IEndereçoInterface endereçoInterface)
        {
            _endereçoInterface = endereçoInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Endereço>>>> GetEndereços()
        {
            return Ok(await _endereçoInterface.GetEndereços());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Endereço>>> GetEndereçosbyID(int ID)
        {
            ServiceResponse<Endereço> serviceResponse = await _endereçoInterface.GetEndereçoByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Endereço>>>> CreateEndereço(Endereço endereço)
        {
            return Ok(await _endereçoInterface.CreateEndereço(endereço));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<Endereço>>>> UpdateEndereço([FromBody] Endereço EditadoEndereço)
        {
            ServiceResponse<List<Endereço>> serviceResponse = await _endereçoInterface.UpdateEndereço(EditadoEndereço);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Endereço>>>> DeleteEndereço(int ID)
        {
            ServiceResponse<List<Endereço>> serviceResponse = await _endereçoInterface.DeleteEndereço(ID);
            return Ok(serviceResponse);
        }
    }
}
