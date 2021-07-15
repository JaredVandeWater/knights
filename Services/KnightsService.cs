using System;
using System.Collections.Generic;
using knights.Data;
using knights.Models;

namespace knights.Services
{
  public class KnightsService
  {
    private readonly KnightsRepository _knightsRepo;

    public KnightsService(KnightsRepository knightsRepo)
    {
      _knightsRepo = knightsRepo;
    }

    public List<Knight> GetAll()
    {
      return _knightsRepo.GetAll();
    }

    public Knight CreateKnight(Knight knightData)
    {
      return _knightsRepo.Create(knightData);
    }

    public Knight GetById(int id)
    {
      return _knightsRepo.getOne(id);
    }

    public string delete(int id)
    {
      int updated = _knightsRepo.delete(id);
      if (updated > 0)
      {
        return "Deleted";
      }
      else
      {
        throw new System.Exception("could not delete");
      }
    }

    public Knight update(int id, Knight knight)
    {
      knight.Id = id;
      Knight original = GetById(id);
      knight.Weapon = knight.Weapon == null ? original.Weapon : knight.Weapon;
      knight.Name = knight.Name == null ? original.Name : knight.Name;
    }
  }
}