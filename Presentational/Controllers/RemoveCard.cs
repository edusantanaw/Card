using Microsoft.AspNetCore.Mvc;
using Domain.Usecases;
using Domain.Entities;
using Presentational.DTO;

namespace Presentational.Controllers
{
    [Route("/card")]
    [ApiController]
    public class RemoveCardController : ControllerBase
    {
        private IDeleteUsecase DeleteCardUsecase;
        public RemoveCardController([FromServices] IDeleteUsecase createUsecase)
        {
            DeleteCardUsecase = createUsecase;
        }
        [HttpDelete("{id}")]
        public IActionResult Post(Guid id)
        {
            try
            {
                var isDeleted = DeleteCardUsecase.execute(id);
                if (!isDeleted) return NotFound();
                return Ok(true);
            }
            catch (Exception error)
            {
                return BadRequest(error.Data);
            }
        }
    }
};