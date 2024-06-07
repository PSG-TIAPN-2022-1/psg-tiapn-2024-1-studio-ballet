using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.EndereçoService
{
    public class EndereçoService:IEndereçoInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public EndereçoService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Endereço>>> CreateEndereço(Endereço endereço)
        {
            ServiceResponse<List<Endereço>> serviceReponse = new ServiceResponse<List<Endereço>>();
            try
            {
                _context.Add(endereço);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Endereços.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Endereço>>> DeleteEndereço(int id)
        {
            ServiceResponse<List<Endereço>> serviceResponse = new ServiceResponse<List<Endereço>>();



            try
            {
                Endereço endereço = _context.Endereços.FirstOrDefault(a => a.Id == id);

                if (endereço == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Endereços.Remove(endereço);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Endereços.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Endereço>> GetEndereçoByID(int Id)
        {
            ServiceResponse<Endereço> serviceResponse = new ServiceResponse<Endereço>();

            try
            {
                Endereço EndereçoModel = _context.Endereços.FirstOrDefault(x => x.Id == Id);

                if (EndereçoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = EndereçoModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Endereço>>> GetEndereços()
        {
            ServiceResponse<List<Endereço>> serviceResponse = new ServiceResponse<List<Endereço>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Endereços.ToList();
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

        public async Task<ServiceResponse<List<Endereço>>> UpdateEndereço(Endereço editadoEndereço)
        {
            ServiceResponse<List<Endereço>> serviceResponse = new ServiceResponse<List<Endereço>>();

            try
            {

                Endereço EndereçoModel = _context.Endereços.AsNoTracking().FirstOrDefault(x => x.Id == editadoEndereço.Id);
                if (EndereçoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Endereços.Update(editadoEndereço);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Endereços.ToList();

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
