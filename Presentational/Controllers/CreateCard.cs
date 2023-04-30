using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;

namespace Presentational.Controllers;

[Route("/card")]
[ApiController]
public class CreateCardController : ControllerBase
{
    private ICreateUsecase<string, Card> CreateCardUsecase;
    public CreateCardController([FromServices]ICreateUsecase<string, Card> createUsecase)
    {
        CreateCardUsecase = createUsecase;
    }
    [HttpPost]
    public IActionResult Post()
    {
        var card = CreateCardUsecase.execute("test");
        return Ok(card);
    }
}