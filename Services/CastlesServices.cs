using System;
using System.Collections.Generic;
using Knights.Models;
using Knights.Repositories;

namespace Knights.Services
{
  public class CastlesService
  {
      private readonly CastlesRepository _repo;
      public CastlesService(CastlesRepository repo)
      {
          _repo = repo;
      }
    internal IEnumerable<Castle> getAll()
    {
      return _repo.getAll();
    }
    internal Castle getOne(int id)
    {
     return _repo.getOne(@id);
    }

    internal Castle createCastle(Castle newcastle)
    {
      return _repo.create( newcastle);
    }

    internal Castle edit(Castle updateCastle)
    {
      Castle original = _repo.getOne(updateCastle.Id);
      original.Name = updateCastle.Name != null ? updateCastle.Name: original.Name;
      return _repo.edit(original);
    }

  }
}