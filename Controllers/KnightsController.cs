using System.Collections.Generic;
using knights.Models;
using knights.Services;
using Microsoft.AspNetCore.Mvc;


namespace knights.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class KnightsController : ControllerBase
  {
    private readonly KnightsService _ks;
    public KnightsController(KnightsService ks)
    {
      _ks = ks;
    }

    [HttpGet]
    public ActionResult<List<Knight>> GetKnights()
    {
      try
      {
        var knights = _ks.GetAll();
        return Ok(knights);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }


    [HttpGet("{id}")]
    public ActionResult<List<Knight>> GetKnightById(int id)
    {
      try
      {
        var knight = _ks.GetById(id);
        return Ok(knight);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }


    [HttpPost]
    public ActionResult<Knight> CreateKnight([FromBody] Knight knightData)
    {
      try
      {
        Knight knight = _ks.CreateKnight(knightData);
        return Ok(knight);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }


    [HttpPut("{id}")]
    public ActionResult<Knight> UpdateKnight(int id, [FromBody] Knight knight)
    {
      try
      {
        return Ok(_ks.update(id, knight));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }

    [HttpDelete("{id}")]
    public ActionResult<Knight> DeleteKnight(int id)
    {
      try
      {
        return Ok(_ks.delete(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}