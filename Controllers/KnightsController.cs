using Knights.Models;
using Knights.Services;
using Microsoft.AspNetCore.Mvc;

namespace Knights.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KnightsController: ControllerBase
    {
        private readonly KnightsService _service;
        public KnightsController(KnightsService service)
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult<Knight> Create([FromBody] Knight newknight)
        {
            try
            {
               return Ok(_service.create(newknight));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
    }
}