using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;
using Data.Usecases;

namespace desafio_backend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddScoped<ICreateUsecase<string, Card>, CreateCardUsecase>();
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}
