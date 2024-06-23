using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.FinanceiroService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJessicaOliveira2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceiroController : ControllerBase
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;

        private readonly IFinanceiroInterface _financeiroInterface;
        public FinanceiroController(IFinanceiroInterface financeiroInterface)
        {
            _financeiroInterface = financeiroInterface;
        }



        //Metodos de rotas


        //Metodo para resgatar todos
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Financeiro>>>> GetFinanceiro()
        {
            return Ok(await _financeiroInterface.GetFinanceiro());
        }
        //Metodo para resgatar pelo ID
        [HttpGet("{ID}")]
        public async Task<ActionResult<ServiceResponse<Financeiro>>> GetFinanceirobyID(int ID)
        {
            ServiceResponse<Financeiro> serviceResponse = await _financeiroInterface.GetFinanceiroByID(ID);
            return Ok(serviceResponse);
        }
        //Metodo para criar 
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Financeiro>>>> CreateFinanceiro(Financeiro Financeiro)
        {
            return Ok(await _financeiroInterface.CreateFinanceiro(Financeiro));
        }

        //Metodo para editar

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<Financeiro>>>> UpdateFinanceiro([FromBody] Financeiro EditadoFinanceiro)
        {
            ServiceResponse<List<Financeiro>> serviceResponse = await _financeiroInterface.UpdateFinanceiro(EditadoFinanceiro);
            return Ok(serviceResponse);
        }

        //Metodo para deletar

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Financeiro>>>> DeleteFinanceiro(int ID)
        {
            ServiceResponse<List<Financeiro>> serviceResponse = await _financeiroInterface.DeleteFinanceiro(ID);
            return Ok(serviceResponse);
        }
    }
}
