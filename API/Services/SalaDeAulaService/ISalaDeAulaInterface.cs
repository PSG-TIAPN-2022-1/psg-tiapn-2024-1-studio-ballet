using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.SalaDeAulaService
{
    public interface ISalaDeAulaInterface
    {
        Task<ServiceResponse<List<SalaDeAula>>> GetSalas();
        Task<ServiceResponse<List<SalaDeAula>>> CreateSala(SalaDeAula newSala);
        Task<ServiceResponse<SalaDeAula>> GetSalaByID(int id);
        Task<ServiceResponse<List<SalaDeAula>>> UpdateSala(SalaDeAula editadoSala);
        Task<ServiceResponse<List<SalaDeAula>>> DeleteSala(int id);
    }
}
