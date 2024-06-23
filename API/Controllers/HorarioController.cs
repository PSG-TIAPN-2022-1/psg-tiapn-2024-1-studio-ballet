using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.HorarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IHorarioInterface _horarioInterface;
        public HorarioController(IHorarioInterface horarioInterface)
        {
            _horarioInterface = horarioInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Horario>>>> GetHorario()
        {
            return Ok(await _horarioInterface.GetHorario());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Horario>>> GetHorariobyID(int ID)
        {
            ServiceResponse<Horario> serviceResponse = await _horarioInterface.GetHorarioByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Horario>>>> CreateHorario(Horario Horario)
        {
            return Ok(await _horarioInterface.CreateHorario(Horario));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<Horario>>>> UpdateAluno([FromBody] Horario EditadoHorario)
        {
            ServiceResponse<List<Horario>> serviceResponse = await _horarioInterface.UpdateHorario(EditadoHorario);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Horario>>>> DeleteHorario(int ID)
        {
            ServiceResponse<List<Horario>> serviceResponse = await _horarioInterface.DeleteHorario(ID);
            return Ok(serviceResponse);
        }
    
    }
}
