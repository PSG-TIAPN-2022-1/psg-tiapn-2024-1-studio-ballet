using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.SalaDeAulaService
{
    public class SalaDeAulaService
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public SalaDeAulaService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<SalaDeAula>>> CreateSala(SalaDeAula Sala)
        {
            ServiceResponse<List<SalaDeAula>> serviceReponse = new ServiceResponse<List<SalaDeAula>>();
            try
            {
                _context.Add(Sala);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.SalaDeAulas.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<SalaDeAula>>> DeleteSala(int id)
        {
            ServiceResponse<List<SalaDeAula>> serviceResponse = new ServiceResponse<List<SalaDeAula>>();



            try
            {
                SalaDeAula sala = _context.SalaDeAulas.FirstOrDefault(a => a.Id == id);

                if (sala == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.SalaDeAulas.Remove(sala);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.SalaDeAulas.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<SalaDeAula>> GetSalaByID(int Id)
        {
            ServiceResponse<SalaDeAula> serviceResponse = new ServiceResponse<SalaDeAula>();

            try
            {
                SalaDeAula sala = _context.SalaDeAulas.FirstOrDefault(x => x.Id == Id);

                if (sala == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = sala;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<SalaDeAula>>> GetSalas()
        {
            ServiceResponse<List<SalaDeAula>> serviceResponse = new ServiceResponse<List<SalaDeAula>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.SalaDeAulas.ToList();
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

        public async Task<ServiceResponse<List<SalaDeAula>>> UpdateAluno(SalaDeAula editadoSala)
        {
            ServiceResponse<List<SalaDeAula>> serviceResponse = new ServiceResponse<List<SalaDeAula>>();

            try
            {

                SalaDeAula sala = _context.SalaDeAulas.AsNoTracking().FirstOrDefault(x => x.Id == editadoSala.Id);
                if (sala == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.SalaDeAulas.Update(editadoSala);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.SalaDeAulas.ToList();

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
