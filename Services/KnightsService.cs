using System;
using System.Collections.Generic;
using knights.Data;
using knights.Models;

namespace knights.Services
{
  public class KnightsService
  {
    private readonly KnightsRepository _artistsRepo;

    public KnightsService(KnightsRepository artistsRepo)
    {
      _artistsRepo = artistsRepo;
    }

    public List<Knight> GetAll()
    {
      return _artistsRepo.GetAll();
    }

    public Knight CreateKnight(Knight artistData)
    {
      return _artistsRepo.Create(artistData);
    }
  }
}