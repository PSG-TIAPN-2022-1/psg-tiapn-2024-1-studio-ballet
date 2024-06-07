using APIJessicaOliveira2.Models;
using APIJessicaOliveira2.Service.AlunoService;
using APIJessicaOliveira2.Services.ProfessorService;
using APIJessicaOliveira2.Services.DisciplinaService;
using Microsoft.EntityFrameworkCore;
using APIJessicaOliveira2.Services.EndereçoService;
using APIJessicaOliveira2.Services.FinanceiroService;
using APIJessicaOliveira2.Services.HorarioService;
using APIJessicaOliveira2.Services.NotasService;
using APIJessicaOliveira2.Services.PlanoDeAulaService;

namespace APIJessicaOliveira2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Injeções de dependencia

            builder.Services.AddScoped<IAlunoInterface, AlunoService>();
            builder.Services.AddScoped<IProfessorInterface, ProfessorService>();
            builder.Services.AddScoped<IDisciplinaInterface, DisciplinaService>();
            builder.Services.AddScoped<IEndereçoInterface,EndereçoService>();
            builder.Services.AddScoped<IFinanceiroInterface, FinanceiroService>();
            builder.Services.AddScoped<IHorarioInterface, HorarioService>();
            

            builder.Services.AddDbContext<STUDIO_JESSICA_OLIVEIRA2Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
