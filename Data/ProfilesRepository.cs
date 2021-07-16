using System.Collections.Generic;
using System.Data;
using System.Linq;
using blogger_server.Models;
using Dapper;

namespace blogger_server.Data
{
  public class ProfilesRepository
  {
    private readonly IDbConnection _db;
    public ProfilesRepository(IDbConnection db)
    {
      _db = db;
    }
    public List<Profile> GetAllProfiles()
    {
      var sql = " SELECT * FROM Profile";
      return _db.Query<Profile>(sql).ToList();
    }
    public Profile Create(Profile profileData)
    {
      var sql = @"
      INSERT INTO profile(name, email, picture)
      VALUES(@Name, @Email, @Picture);
      SELECT LAST_INSERT_ID();
       ";
       int id = _db.ExecuteScalar<int>(sql, profileData);
       profileData.Id = id;
       return profileData;
    }
  }
}