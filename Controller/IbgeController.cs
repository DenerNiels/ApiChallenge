using ApiChallenge.Data;
using ApiChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiChallenge.Controller
{
    public class IbgeController : ControllerBase
    {
        public IbgeController()
        {
        }

        [HttpGet]
        [Route("GetById/{id}")]
        private async Task<IActionResult> GetById(int id, IbgeService ibgeService, CancellationToken cancellationToken)
        {
            var data = await ibgeService.GetByIdAsync(id, cancellationToken);
            if (data == null)
                return NotFound(new { message = "Id não encontrado" });

            return Ok(data);
        }
    }
}