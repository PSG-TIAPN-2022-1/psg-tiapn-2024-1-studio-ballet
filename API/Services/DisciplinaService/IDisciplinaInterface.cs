using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.DisciplinaService
{
    public interface IDisciplinaInterface
    {
        Task<ServiceResponse<List<Disciplina>>> GetDisciplinas();
        Task<ServiceResponse<List<Disciplina>>> CreateDisciplina(Disciplina newDisciplina);
        Task<ServiceResponse<Disciplina>> GetDisciplinaByID(int id);
        Task<ServiceResponse<List<Disciplina>>> UpdateDisciplina(Disciplina editadoDisciplina);
        Task<ServiceResponse<List<Disciplina>>> DeleteDisciplina(int id);
    }
}
