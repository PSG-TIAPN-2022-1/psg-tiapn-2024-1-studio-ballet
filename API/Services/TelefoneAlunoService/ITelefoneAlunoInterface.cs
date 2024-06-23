using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.TelefoneAlunoService
{
    public interface ITelefoneAlunoInterface
    {
        Task<ServiceResponse<List<TelefoneAluno>>> GetTelefones();
        Task<ServiceResponse<List<TelefoneAluno>>> CreateTelefone(TelefoneAluno newTelefone);
        Task<ServiceResponse<TelefoneAluno>> GetTelefoneByID(int id);
        Task<ServiceResponse<List<TelefoneAluno>>> UpdateTelefone(TelefoneAluno editadoTelefone);
        Task<ServiceResponse<List<TelefoneAluno>>> DeleteTelefone(int id);
    }
}
