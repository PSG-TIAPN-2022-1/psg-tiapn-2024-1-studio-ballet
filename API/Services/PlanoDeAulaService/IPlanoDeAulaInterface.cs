using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.PlanoDeAulaService
{
    public interface IPlanoDeAulaInterface
    {
        Task<ServiceResponse<List<PlanoDeAula>>> GetPlanos();
        Task<ServiceResponse<List<PlanoDeAula>>> CreatePlano(PlanoDeAula newPlano);
        Task<ServiceResponse<PlanoDeAula>> GetPlanoByID(int id);
        Task<ServiceResponse<List<PlanoDeAula>>> UpdatePlano(PlanoDeAula editadoPlano);
        Task<ServiceResponse<List<PlanoDeAula>>> DeletePlano(int id);
    }
}
