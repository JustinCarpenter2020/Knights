using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Knights.Models;

namespace Knights.Repositories
{
  public class CastlesRepository
  {
    private readonly IDbConnection _db;
    public CastlesRepository(IDbConnection db)
    {
        _db = db;
    }
    internal IEnumerable<Castle> getAll()
    {
      string sql = "SELECT * FROM castle";
      return _db.Query<Castle>(sql);
    }

    internal Castle getOne(int id)
    {
      string sql = "SELECT * FROM castle WHERE id = @id";
      return _db.QueryFirstOrDefault<Castle>(sql, new {id});
    }

    internal Castle create(Castle newcastle)
    {
      string sql = @"
      INSERT INTO castle 
      (name)
      VALUES
      (@Name);
      SELECT LAST_INSERT_ID();";
      newcastle.Id = _db.ExecuteScalar<int>(sql, newcastle);
      return newcastle;
    }

    internal Castle edit(Castle original)
    {
      throw new NotImplementedException();
    }
  }
}