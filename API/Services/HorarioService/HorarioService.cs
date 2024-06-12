using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIJessicaOliveira2.Services.HorarioService
{
    public class HorarioService : IHorarioInterface
    {
        private STUDIO_JESSICA_OLIVEIRA2Context _context;
        public HorarioService(STUDIO_JESSICA_OLIVEIRA2Context context)
        {
            _context = context;
        }


        //metodos para rotas 
        public async Task<ServiceResponse<List<Horario>>> CreateHorario(Horario Horario)
        {
            ServiceResponse<List<Horario>> serviceReponse = new ServiceResponse<List<Horario>>();
            try
            {
                _context.Add(Horario);
                await _context.SaveChangesAsync();

                serviceReponse.Dados = _context.Horarios.ToList();
            }
            catch (Exception ex)
            {
                serviceReponse.Mensagem = ex.Message;
                serviceReponse.Sucesso = false;
            }
            return serviceReponse;

        }

        public async Task<ServiceResponse<List<Horario>>> DeleteHorario(int id)
        {
            ServiceResponse<List<Horario>> serviceResponse = new ServiceResponse<List<Horario>>();



            try
            {
                Horario horario = _context.Horarios.FirstOrDefault(a => a.Id == id);

                if (horario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                _context.Horarios.Remove(horario);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Horarios.ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<Horario>> GetHorarioByID(int Id)
        {
            ServiceResponse<Horario> serviceResponse = new ServiceResponse<Horario>();

            try
            {
                Horario horario = _context.Horarios.FirstOrDefault(x => x.Id == Id);

                if (horario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                    return serviceResponse;

                }
                serviceResponse.Dados = horario;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<Horario>>> GetHorario()
        {
            ServiceResponse<List<Horario>> serviceResponse = new ServiceResponse<List<Horario>>();
            await _context.SaveChangesAsync();

            try
            {
                serviceResponse.Dados = _context.Horarios.ToList();
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

        public async Task<ServiceResponse<List<Horario>>> UpdateHorario(Horario editadoHorario)
        {
            ServiceResponse<List<Horario>> serviceResponse = new ServiceResponse<List<Horario>>();

            try
            {

                Horario HorarioModel = _context.Horarios.AsNoTracking().FirstOrDefault(x => x.Id == editadoHorario.Id);
                if (HorarioModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuario não localizado";
                    serviceResponse.Sucesso = false;

                }
                _context.Horarios.Update(editadoHorario);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Horarios.ToList();

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