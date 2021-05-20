using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Knights.Models;

namespace Knights.Repository
{
    public class KnightsRepository
    {

      private readonly IDbConnection _db;
    public KnightsRepository(IDbConnection db)
    {
        _db = db;
    }
          internal IEnumerable<Knight> getKnightsByCastle(int id)
    {
      string sql = "SELECT * FROM knights WHERE castleId = @id";
      return _db.Query<Knight>(sql, new {id});
    }

    internal Knight create(Knight newknight)
    {
      string sql = @"
      INSERT INTO knights
      (name, dragonsSlayed, hasSword, castleId)
      VALUES
      (@Name, @DragonsSlayed, @HasSword, @CastleId);
      SELECT LAST_INSERT_ID();";
      newknight.Id = _db.ExecuteScalar<int>(sql, newknight);
      return newknight;
    }
  }
}