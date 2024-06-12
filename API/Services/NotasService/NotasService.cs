using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.NotasService
{
    public class NotasService:INotasInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public NotasService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Notas>>> CreateNota(Notas Nota)
        {
            ServiceResponse<List<Notas>> serviceReponse = new ServiceResponse<List<Notas>>();
            try
            {
                _context.Add(Nota);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Nota.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Notas>>> DeleteNotas(int id)
        {
            ServiceResponse<List<Notas>> serviceResponse = new ServiceResponse<List<Notas>>();



            try
            {
                Notas nota = _context.Nota.FirstOrDefault(a => a.Id == id);

                if (nota == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Nota.Remove(nota);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Nota.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Notas>> GetNotaByID(int Id)
        {
            ServiceResponse<Notas> serviceResponse = new ServiceResponse<Notas>();

            try
            {
                Notas NotaModel = _context.Nota.FirstOrDefault(x => x.Id == Id);

                if (NotaModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = NotaModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Notas>>> GetNotas()
        {
            ServiceResponse<List<Notas>> serviceResponse = new ServiceResponse<List<Notas>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Nota.ToList();
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

        public async Task<ServiceResponse<List<Notas>>> UpdateNotas(Notas editadoNota)
        {
            ServiceResponse<List<Notas>> serviceResponse = new ServiceResponse<List<Notas>>();

            try
            {

                Notas NotaModel = _context.Nota.AsNoTracking().FirstOrDefault(x => x.Id == editadoNota.Id);
                if (NotaModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Nota.Update(editadoNota);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Nota.ToList();

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