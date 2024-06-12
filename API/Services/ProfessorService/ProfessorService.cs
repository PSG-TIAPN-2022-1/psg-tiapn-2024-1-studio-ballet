using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.ProfessorService
{
    public class ProfessorService : IProfessorInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public ProfessorService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Professor>>> CreateProfessor(Professor Professor)
        {
            ServiceResponse<List<Professor>> serviceReponse = new ServiceResponse<List<Professor>>();
            try
            {
                _context.Add(Professor);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Professores.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Professor>>> DeleteProfessor(int Id)
        {
            ServiceResponse<List<Professor>> serviceResponse = new ServiceResponse<List<Professor>>();



            try
            {
                Professor professor = _context.Professores.FirstOrDefault(a => a.Id == Id);

                if (professor == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Professores.Remove(professor);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Professores.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Professor>> GetProfessorByID(int id)
        {
            ServiceResponse<Professor> serviceResponse = new ServiceResponse<Professor>();

            try
            {
                Professor ProfessorModel = _context.Professores.FirstOrDefault(x => x.Id == id);

                if (ProfessorModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = ProfessorModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Professor>>> GetProfessores()
        {
            ServiceResponse<List<Professor>> serviceResponse = new ServiceResponse<List<Professor>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Professores.ToList();
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

        public async Task<ServiceResponse<List<Professor>>> UpdateProfessor(Professor editadoProfessor)
        {
            ServiceResponse<List<Professor>> serviceResponse = new ServiceResponse<List<Professor>>();

            try
            {

                Professor ProfessorModel = _context.Professores.AsNoTracking().FirstOrDefault(x => x.Id == editadoProfessor.Id);
                if (ProfessorModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Professores.Update(editadoProfessor);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Professores.ToList();

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