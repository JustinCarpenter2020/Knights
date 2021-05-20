using System.Collections.Generic;
using Knights.Models;
using Knights.Services;
using Microsoft.AspNetCore.Mvc;

namespace Knights.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CastlesController: ControllerBase
    {
        private readonly CastlesService _service;
        private readonly KnightsService _kService;
        public CastlesController(CastlesService service, KnightsService kService)
        {
            _service = service;
            _kService = kService;
        }
      [HttpGet]
      public ActionResult<IEnumerable<Castle>> GetAll()
      {
          try
          {
              return Ok(_service.getAll());
          }
          catch (System.Exception e)
          {
              
              return BadRequest(e.Message);
          }
      }

      [HttpGet("{id}")]
      public ActionResult<Castle> GetOne(int id)
      {
          try
          {
              return Ok(_service.getOne(id));
          }
          catch (System.Exception e)
          {
              
              return BadRequest(e.Message);
          }
      }

      [HttpGet("{id}/knights")]
      public ActionResult<IEnumerable<Castle>> GetAllKnights(int id)
      {
          try
          {
          return Ok(_kService.getKnights(id));
          }
          catch (System.Exception e)
          {
              
              return BadRequest(e.Message);
          }
      }
    [HttpPost]
    public ActionResult<Castle> CreateCastle([FromBody] Castle newcastle)
    {
        try
        {
            return Ok(_service.createCastle(newcastle));
        }
        catch (System.Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<Castle> EditCastle([FromBody] Castle updateCastle, int id)
    {
        try
        {
            updateCastle.Id = @id;
            return Ok( _service.edit(updateCastle));
        }
        catch (System.Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }





    }

}