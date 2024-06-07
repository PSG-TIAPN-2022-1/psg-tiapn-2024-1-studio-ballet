using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.NotasService
{
    public interface INotasInterface
    {
        Task<ServiceResponse<List<Notas>>> GetNotas();
        Task<ServiceResponse<List<Notas>>> CreateNota(Notas newNota);
        Task<ServiceResponse<Notas>> GetNotaByID(int id);
        Task<ServiceResponse<List<Notas>>> UpdateNotas(Notas editadoNota);
        Task<ServiceResponse<List<Notas>>> DeleteNotas(int id);
    }
}
