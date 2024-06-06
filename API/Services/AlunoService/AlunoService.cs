using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;


namespace APIJessicaOliveira2.Service.AlunoService
{
    public class AlunoService : IAlunoInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public AlunoService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Aluno>>> CreateAluno(Aluno Aluno)
        {
            ServiceResponse<List<Aluno>> serviceReponse = new ServiceResponse<List<Aluno>>();
            try
            {
                _context.Add(Aluno);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Alunos.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Aluno>>> DeleteAluno(int id)
        {
            ServiceResponse<List<Aluno>> serviceResponse = new ServiceResponse<List<Aluno>>();



            try
            {
                Aluno aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);

                if (aluno == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Alunos.Remove(aluno);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Alunos.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Aluno>> GetAlunoByID(int id)
        {
            ServiceResponse<Aluno> serviceResponse = new ServiceResponse<Aluno>();

            try
            {
                Aluno AlunoModel = _context.Alunos.FirstOrDefault(x => x.Id == id);

                if (AlunoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = AlunoModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Aluno>>> GetAlunos()
        {
            ServiceResponse<List<Aluno>> serviceResponse = new ServiceResponse<List<Aluno>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Alunos.ToList();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Aluno>>> UpdateAluno(Aluno editadoAluno)
        {
            ServiceResponse<List<Aluno>> serviceResponse = new ServiceResponse<List<Aluno>>();

            try
            {

                Aluno AlunoModel = _context.Alunos.AsNoTracking().FirstOrDefault(x => x.Id == editadoAluno.Id);
                if (AlunoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Alunos.Update(editadoAluno);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Alunos.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }
    }
}
