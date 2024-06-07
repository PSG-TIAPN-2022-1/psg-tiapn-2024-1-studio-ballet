using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.FinanceiroService
{
    public interface IFinanceiroInterface
    {
        Task<ServiceResponse<List<Financeiro>>> GetFinanceiro();
        Task<ServiceResponse<List<Financeiro>>> CreateFinanceiro(Financeiro newFinanceiro);
        Task<ServiceResponse<Financeiro>> GetFinanceiroByID(int id);
        Task<ServiceResponse<List<Financeiro>>> UpdateFinanceiro(Financeiro editadoFinanceiro);
        Task<ServiceResponse<List<Financeiro>>> DeleteFinanceiro(int id);
    }
}
