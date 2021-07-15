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
    [HttpPost]
    public ActionResult<Knight> CreateKnights([FromBody] Knight knightData)
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
  }
}