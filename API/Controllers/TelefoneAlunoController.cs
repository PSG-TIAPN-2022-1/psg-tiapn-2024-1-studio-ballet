using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.TelefoneAlunoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneAlunoController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly ITelefoneAlunoInterface _telefoneInterface;
        public TelefoneAlunoController(ITelefoneAlunoInterface telefoneInterface)
        {
            _telefoneInterface = telefoneInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<TelefoneAluno>>>> GetTelefones()
        {
            return Ok(await _telefoneInterface.GetTelefones());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<TelefoneAluno>>> GetTelefonebyID(int ID)
        {
            ServiceResponse<TelefoneAluno> serviceResponse = await _telefoneInterface.GetTelefoneByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<TelefoneAluno>>>> CreateTelefone(TelefoneAluno Telefone)
        {
            return Ok(await _telefoneInterface.CreateTelefone(Telefone));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<TelefoneAluno>>>> UpdateTelefone([FromBody] TelefoneAluno EditadoTelefone)
        {
            ServiceResponse<List<TelefoneAluno>> serviceResponse = await _telefoneInterface.UpdateTelefone(EditadoTelefone);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<TelefoneAluno>>>> DeleteTelefone(int ID)
        {
            ServiceResponse<List<TelefoneAluno>> serviceResponse = await _telefoneInterface.DeleteTelefone(ID);
            return Ok(serviceResponse);
        }
    }
}
