using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.TelefoneAlunoService
{
    public class TelefoneAlunoService : ITelefoneAlunoInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public TelefoneAlunoService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<TelefoneAluno>>> CreateTelefone(TelefoneAluno Telefone)
        {
            ServiceResponse<List<TelefoneAluno>> serviceReponse = new ServiceResponse<List<TelefoneAluno>>();
            try
            {
                _context.Add(Telefone);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.TelefoneAlunos.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<TelefoneAluno>>> DeleteTelefone(int id)
        {
            ServiceResponse<List<TelefoneAluno>> serviceResponse = new ServiceResponse<List<TelefoneAluno>>();



            try
            {
                TelefoneAluno telefone = _context.TelefoneAlunos.FirstOrDefault(a => a.Id == id);

                if (telefone == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.TelefoneAlunos.Remove(telefone);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.TelefoneAlunos.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<TelefoneAluno>> GetTelefoneByID(int Id)
        {
            ServiceResponse<TelefoneAluno> serviceResponse = new ServiceResponse<TelefoneAluno>();

            try
            {
                TelefoneAluno tel = _context.TelefoneAlunos.FirstOrDefault(x => x.Id == Id);

                if (tel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = tel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<TelefoneAluno>>> GetTelefones()
        {
            ServiceResponse<List<TelefoneAluno>> serviceResponse = new ServiceResponse<List<TelefoneAluno>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.TelefoneAlunos.ToList();
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

        public async Task<ServiceResponse<List<TelefoneAluno>>> UpdateTelefone(TelefoneAluno tel)
        {
            ServiceResponse<List<TelefoneAluno>> serviceResponse = new ServiceResponse<List<TelefoneAluno>>();

            try
            {

                TelefoneAluno TelefoneModel = _context.TelefoneAlunos.AsNoTracking().FirstOrDefault(x => x.Id == tel.Id);
                if (TelefoneModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.TelefoneAlunos.Update(tel);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.TelefoneAlunos.ToList();

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
