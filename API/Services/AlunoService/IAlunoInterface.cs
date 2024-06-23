using APIJessicaOliveira2.Models;


namespace APIJessicaOliveira2.Service.AlunoService
{
    public interface IAlunoInterface
    {
        Task<ServiceResponse<List<Aluno>>> GetAlunos();
        Task<ServiceResponse<List<Aluno>>> CreateAluno(Aluno newAluno);
        Task<ServiceResponse<Aluno>> GetAlunoByID(int id);
        Task<ServiceResponse<List<Aluno>>> UpdateAluno(Aluno editadoAluno);
        Task<ServiceResponse<List<Aluno>>> DeleteAluno(int id);


    }
}
