using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.NotasService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly INotasInterface _notasInterface;
        public NotasController(INotasInterface notasInterface)
        {
            _notasInterface = notasInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Notas>>>> GetNotas()
        {
            return Ok(await _notasInterface.GetNotas());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Notas>>> GetNotabyID(int ID)
        {
            ServiceResponse<Notas> serviceResponse = await _notasInterface.GetNotaByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Notas>>>> CreateNota(Notas Nota)
        {
            return Ok(await _notasInterface.CreateNota(Nota));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<Notas>>>> UpdateNota([FromBody] Notas EditadoNota)
        {
            ServiceResponse<List<Notas>> serviceResponse = await _notasInterface.UpdateNotas(EditadoNota);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Notas>>>> DeleteNota(int ID)
        {
            ServiceResponse<List<Notas>> serviceResponse = await _notasInterface.DeleteNotas(ID);
            return Ok(serviceResponse);
        }
    }
}
