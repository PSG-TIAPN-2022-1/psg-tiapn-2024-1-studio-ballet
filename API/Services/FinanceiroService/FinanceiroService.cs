using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.FinanceiroService
{
    public class FinanceiroService : IFinanceiroInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public FinanceiroService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Financeiro>>> CreateFinanceiro(Financeiro financeiro)
        {
            ServiceResponse<List<Financeiro>> serviceReponse = new ServiceResponse<List<Financeiro>>();
            try
            {
                _context.Add(financeiro);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Financeiros.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Financeiro>>> DeleteFinanceiro(int id)
        {
            ServiceResponse<List<Financeiro>> serviceResponse = new ServiceResponse<List<Financeiro>>();



            try
            {
                Financeiro financeiro = _context.Financeiros.FirstOrDefault(a => a.Id == id);

                if (financeiro == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Financeiros.Remove(financeiro);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Financeiros.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Financeiro>> GetFinanceiroByID(int Id)
        {
            ServiceResponse<Financeiro> serviceResponse = new ServiceResponse<Financeiro>();

            try
            {
                Financeiro FinanceiroModel = _context.Financeiros.FirstOrDefault(x => x.Id == Id);

                if (FinanceiroModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = FinanceiroModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Financeiro>>> GetFinanceiro()
        {
            ServiceResponse<List<Financeiro>> serviceResponse = new ServiceResponse<List<Financeiro>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Financeiros.ToList();
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

        public async Task<ServiceResponse<List<Financeiro>>> UpdateFinanceiro(Financeiro editadoFinanceiro)
        {
            ServiceResponse<List<Financeiro>> serviceResponse = new ServiceResponse<List<Financeiro>>();

            try
            {

                Aluno FinanceiroModel = _context.Alunos.AsNoTracking().FirstOrDefault(x => x.Id == editadoFinanceiro.Id);
                if (FinanceiroModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Financeiros.Update(editadoFinanceiro);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Financeiros.ToList();

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