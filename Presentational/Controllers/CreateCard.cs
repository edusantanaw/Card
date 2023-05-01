using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;
using Presentational.DTO;

namespace Presentational.Controllers
{
    [Route("/card")]
    [ApiController]
    public class CreateCardController : ControllerBase
    {
        private ICreateUsecase<CreaeteCardDto, Card> CreateCardUsecase;
        public CreateCardController([FromServices] ICreateUsecase<CreaeteCardDto, Card> createUsecase)
        {
            CreateCardUsecase = createUsecase;
        }
        [HttpPost]
        public IActionResult Post(CreaeteCardDto cardDTO)
        {
            try
            {
                var card = CreateCardUsecase.execute(cardDTO);
                return Ok(card);
            }
            catch (Exception error)
            {
                return BadRequest(error.Data);
            }
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            return Ok("result");
        }
    }
};