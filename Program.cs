using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;
using Data.Usecases;
using Presentational.DTO;
using Infra.Db;
using Npgsql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Infra.Repositorys;
using Data.Repository;

namespace desafio_backend
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            registerServices(builder);
            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }

        public static void registerServices(WebApplicationBuilder builder)
        {
            string connectionDB = builder.Configuration.GetConnectionString("DBConnectionString");
            builder.Services.AddDbContext<CardDbContext>(o => o.UseNpgsql(connectionDB));
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<ICreateUsecase<CreaeteCardDto, Card>, CreateCardUsecase>();
            builder.Services.AddScoped<ICreateRepository<Card, Card>, CardRepository>();
        }
    }
};