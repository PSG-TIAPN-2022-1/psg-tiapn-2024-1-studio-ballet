using APIJessicaOliveira2.Models;

namespace APIJessicaOliveira2.Services.HorarioService
{
    public interface IHorarioInterface
    {
        Task<ServiceResponse<List<Horario>>> GetHorario();
        Task<ServiceResponse<List<Horario>>> CreateHorario(Horario newHorario);
        Task<ServiceResponse<Horario>> GetHorarioByID(int id);
        Task<ServiceResponse<List<Horario>>> UpdateHorario(Horario editadoHorario);
        Task<ServiceResponse<List<Horario>>> DeleteHorario(int id);
    }
}
