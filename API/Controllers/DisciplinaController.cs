using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.DisciplinaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IDisciplinaInterface _disciplinaInterface;
        public DisciplinaController(IDisciplinaInterface disciplinaInterface)
        {
            _disciplinaInterface = disciplinaInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Disciplina>>>> GetDisciplinas()
        {
            return Ok(await _disciplinaInterface.GetDisciplinas());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Disciplina>>> GetDisciplinabyID(int ID)
        {
            ServiceResponse<Disciplina> serviceResponse = await _disciplinaInterface.GetDisciplinaByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Disciplina>>>> CreateDisciplina(Disciplina disciplina)
        {
            return Ok(await _disciplinaInterface.CreateDisciplina(disciplina));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<Disciplina>>>> UpdateDisciplina([FromBody] Disciplina EditadoDisciplina)
        {
            ServiceResponse<List<Disciplina>> serviceResponse = await _disciplinaInterface.UpdateDisciplina(EditadoDisciplina);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Disciplina>>>> DeleteDisciplina(int ID)
        {
            ServiceResponse<List<Disciplina>> serviceResponse = await _disciplinaInterface.DeleteDisciplina(ID);
            return Ok(serviceResponse);
        }
    }
}
