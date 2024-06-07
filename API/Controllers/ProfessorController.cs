using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Services.ProfessorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IProfessorInterface _professorInterface;
        public ProfessorController(IProfessorInterface alunoInterface)
        {
            _professorInterface = alunoInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Professor>>>> GeProfessores()
        {
            return Ok(await _professorInterface.GetProfessores());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Professor>>> GetProfessoresbyID(int ID)
        {
            ServiceResponse<Professor> serviceResponse = await _professorInterface.GetProfessorByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Professor>>>> CreateProfessor(Professor Professor)
        {
            return Ok(await _professorInterface.CreateProfessor(Professor));
        }

        //Metodo para editar

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<Professor>>>> UpdateProfessor(Professor EditadoProfessor)
        {
            ServiceResponse<List<Professor>> serviceResponse = await _professorInterface.UpdateProfessor(EditadoProfessor);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Professor>>>> DeleteProfessor(int ID)
        {
            ServiceResponse<Professor> serviceResponse = await _professorInterface.GetProfessorByID(ID);
            return Ok(serviceResponse);
        }

    }
}
