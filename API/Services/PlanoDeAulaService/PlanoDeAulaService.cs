using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.PlanoDeAulaService
{
    public class PlanoDeAulaService:IPlanoDeAulaInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public PlanoDeAulaService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<PlanoDeAula>>> CreatePlano(PlanoDeAula Plano)
        {
            ServiceResponse<List<PlanoDeAula>> serviceReponse = new ServiceResponse<List<PlanoDeAula>>();
            try
            {
                _context.Add(Plano);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.PlanoDeAulas.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<PlanoDeAula>>> DeletePlano(int id)
        {
            ServiceResponse<List<PlanoDeAula>> serviceResponse = new ServiceResponse<List<PlanoDeAula>>();



            try
            {
                PlanoDeAula plano = _context.PlanoDeAulas.FirstOrDefault(a => a.Id == id);

                if (plano == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.PlanoDeAulas.Remove(plano);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.PlanoDeAulas.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<PlanoDeAula>> GetPlanoByID(int Id)
        {
            ServiceResponse<PlanoDeAula> serviceResponse = new ServiceResponse<PlanoDeAula>();

            try
            {
                PlanoDeAula PlanoModel = _context.PlanoDeAulas.FirstOrDefault(x => x.Id == Id);

                if (PlanoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = PlanoModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<PlanoDeAula>>> GetPlanos()
        {
            ServiceResponse<List<PlanoDeAula>> serviceResponse = new ServiceResponse<List<PlanoDeAula>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.PlanoDeAulas.ToList();
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

        public async Task<ServiceResponse<List<PlanoDeAula>>> UpdatePlano(PlanoDeAula editadoPlano)
        {
            ServiceResponse<List<PlanoDeAula>> serviceResponse = new ServiceResponse<List<PlanoDeAula>>();

            try
            {

                PlanoDeAula PlanoModel = _context.PlanoDeAulas.AsNoTracking().FirstOrDefault(x => x.Id == editadoPlano.Id);
                if (PlanoModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.PlanoDeAulas.Update(editadoPlano);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.PlanoDeAulas.ToList();

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