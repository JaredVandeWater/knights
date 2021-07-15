using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using knights.Models;

namespace knights.Data
{
  public class KnightsRepository
  {
    private readonly IDbConnection _db;

    public KnightsRepository(IDbConnection db)
    {
      _db = db;
    }
    public List<Knight> GetAll()
    {
      var sql = "SELECT * FROM knights";
      return _db.Query<Knight>(sql).ToList();
    }
    public Knight Create(Knight knightData)
    {
      var sql = @"
            INSERT INTO knights(name, weapon)
            VALUES(@Name, @Weapon);
            SELECT LAST_INSERT_ID();
            ";

      int id = _db.ExecuteScalar<int>(sql, knightData);
      knightData.Id = id;
      return knightData;

    }

    public Knight getOne(int id)
    {
      string sql = "SELECT * FROM knights Where id = @id";
      return _db.QueryFirstOrDefault<Knight>(sql, new { id });
    }


    public int delete(int id)
    {
      string sql = @"
      DELETE FROM knights WHERE id = @id";
      return _db.Execute(sql, new { id });
    }
  }
}