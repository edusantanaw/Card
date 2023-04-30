using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;
using Data.Usecases;
using Presentational.DTO;

namespace desafio_backend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddScoped<ICreateUsecase<CreaeteCardDto, Card>, CreateCardUsecase>();
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}
