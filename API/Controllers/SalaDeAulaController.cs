using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.SalaDeAulaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaDeAulaController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly ISalaDeAulaInterface _salaInterface;
        public SalaDeAulaController(ISalaDeAulaInterface salaInterface)
        {
            _salaInterface = salaInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SalaDeAula>>>> GetSalas()
        {
            return Ok(await _salaInterface.GetSalas());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<SalaDeAula>>> GetSalabyID(int ID)
        {
            ServiceResponse<SalaDeAula> serviceResponse = await _salaInterface.GetSalaByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<SalaDeAula>>>> CreateSala(SalaDeAula Sala)
        {
            return Ok(await _salaInterface.CreateSala(Sala));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<SalaDeAula>>>> UpdateSala([FromBody] SalaDeAula EditadoSala)
        {
            ServiceResponse<List<SalaDeAula>> serviceResponse = await _salaInterface.UpdateSala(EditadoSala);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<SalaDeAula>>>> DeleteSala(int ID)
        {
            ServiceResponse<List<SalaDeAula>> serviceResponse = await _salaInterface.DeleteSala(ID);
            return Ok(serviceResponse);
        }

    }
}
