using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.ProfessorService
{
    public interface IProfessorInterface
    {
        Task<ServiceResponse<List<Professor>>> GetProfessores();
        Task<ServiceResponse<List<Professor>>> CreateProfessor(Professor newProfessor);
        Task<ServiceResponse<Professor>> GetProfessorByID(int id);
        Task<ServiceResponse<List<Professor>>> UpdateProfessor(Professor editadoProfessor);
        Task<ServiceResponse<List<Professor>>> DeleteProfessor(int id);
    }
}
