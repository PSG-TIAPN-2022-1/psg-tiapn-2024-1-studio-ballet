using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        
        private readonly IAlunoInterface _alunoInterface;
        public AlunoController(IAlunoInterface alunoInterface)
        {
            _alunoInterface = alunoInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Aluno>>>> GetAlunos()
        {
            return Ok(await _alunoInterface.GetAlunos());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Aluno>>> GetAlunosbyID(int ID)
        {
            ServiceResponse<Aluno> serviceResponse = await _alunoInterface.GetAlunoByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Aluno>>>> CreateAlunos(Aluno Aluno)
        {
            return Ok(await _alunoInterface.CreateAluno(Aluno));
        }

        //Metodo para editar

        [HttpPut]
        
        public async Task<ActionResult<ServiceResponse<List<Aluno>>>> UpdateAluno([FromBody] Aluno EditadoAluno)
        {
            ServiceResponse<List<Aluno>> serviceResponse = await _alunoInterface.UpdateAluno(EditadoAluno);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Aluno>>>> DeleteAluno(int ID)
        {
            ServiceResponse<List<Aluno>> serviceResponse = await _alunoInterface.DeleteAluno(ID);
            return Ok(serviceResponse);
        }

    }
}
