using System;
using System.Collections.Generic;
using Knights.Models;
using Knights.Repository;

namespace Knights.Services
{
    public class KnightsService
    {
         private readonly KnightsRepository _repo;
      public KnightsService(KnightsRepository repo)
      {
          _repo = repo;
      }
         internal IEnumerable<Knight> getKnights(int id)
    {
      return _repo.getKnightsByCastle(id);
    }

    internal Knight create(Knight newknight)
    {
      return _repo.create(newknight);
    }
  }
}