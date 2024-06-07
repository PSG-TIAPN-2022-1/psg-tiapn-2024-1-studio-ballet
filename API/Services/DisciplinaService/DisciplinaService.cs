using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.DisciplinaService
{
    public class DisciplinaService : IDisciplinaInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public DisciplinaService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Disciplina>>> CreateDisciplina(Disciplina disciplina)
        {
            ServiceResponse<List<Disciplina>> serviceReponse = new ServiceResponse<List<Disciplina>>();
            try
            {
                _context.Add(disciplina);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Disciplinas.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Disciplina>>> DeleteDisciplina(int id)
        {
            ServiceResponse<List<Disciplina>> serviceResponse = new ServiceResponse<List<Disciplina>>();



            try
            {
                Disciplina disciplina = _context.Disciplinas.FirstOrDefault(a => a.Id == id);

                if (disciplina == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Disciplinas.Remove(disciplina);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Disciplinas.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Disciplina>> GetDisciplinaByID(int Id)
        {
            ServiceResponse<Disciplina> serviceResponse = new ServiceResponse<Disciplina>();

            try
            {
                Disciplina DisciplinaModel = _context.Disciplinas.FirstOrDefault(x => x.Id == Id);

                if (DisciplinaModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = DisciplinaModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Disciplina>>> GetDisciplinas()
        {
            ServiceResponse<List<Disciplina>> serviceResponse = new ServiceResponse<List<Disciplina>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Disciplinas.ToList();
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

        public async Task<ServiceResponse<List<Disciplina>>> UpdateDisciplina(Disciplina editadoDisciplina)
        {
            ServiceResponse<List<Disciplina>> serviceResponse = new ServiceResponse<List<Disciplina>>();

            try
            {

                Disciplina DisciplinaModel = _context.Disciplinas.AsNoTracking().FirstOrDefault(x => x.Id == editadoDisciplina.Id);
                if (DisciplinaModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Disciplinas.Update(editadoDisciplina);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Disciplinas.ToList();

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
