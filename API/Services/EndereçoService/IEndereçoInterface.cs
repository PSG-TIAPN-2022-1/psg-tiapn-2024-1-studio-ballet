using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.EndereçoService
{
    public interface IEndereçoInterface
    {
        Task<ServiceResponse<List<Endereço>>> GetEndereços();
        Task<ServiceResponse<List<Endereço>>> CreateEndereço(Endereço newEndereço);
        Task<ServiceResponse<Endereço>> GetEndereçoByID(int id);
        Task<ServiceResponse<List<Endereço>>> UpdateEndereço(Endereço editadoEndereço);
        Task<ServiceResponse<List<Endereço>>> DeleteEndereço(int id);
    }
}
