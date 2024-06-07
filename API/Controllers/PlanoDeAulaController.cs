using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.PlanoDeAulaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoDeAulaController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IPlanoDeAulaInterface _planoInterface;
        public PlanoDeAulaController(IPlanoDeAulaInterface planoInterface)
        {
            _planoInterface = planoInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<PlanoDeAula>>>> GetPlanos()
        {
            return Ok(await _planoInterface.GetPlanos());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<PlanoDeAula>>> GetPlanobyID(int ID)
        {
            ServiceResponse<PlanoDeAula> serviceResponse = await _planoInterface.GetPlanoByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<PlanoDeAula>>>> CreatePlano(PlanoDeAula Plano)
        {
            return Ok(await _planoInterface.CreatePlano(Plano));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<PlanoDeAula>>>> UpdatePlano([FromBody] PlanoDeAula EditadoPlano)
        {
            ServiceResponse<List<PlanoDeAula>> serviceResponse = await _planoInterface.UpdatePlano(EditadoPlano);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<PlanoDeAula>>>> DeletePlano(int ID)
        {
            ServiceResponse<List<PlanoDeAula>> serviceResponse = await _planoInterface.DeletePlano(ID);
            return Ok(serviceResponse);
        }

    }
}
