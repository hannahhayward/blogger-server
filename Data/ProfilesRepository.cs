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
    public Profile GetProfile(int id)
    {
      var sql = " SELECT * FROM Profile WHERE id = @id";
      return _db.QueryFirstOrDefault<Profile>(sql, new { id });
    }
    public IEnumerable<Profile> GetBlogsByProfile(int id){
      var sql = "SELECT * FROM Blogs WHERE id = @id;";
      return _db.Query<Profile>(sql);
    }
    public IEnumerable<Profile> GetCommentsByProfile(int id){
      var sql = "SELECT * FROM Comments WHERE id = @id;";
      return _db.Query<Profile>(sql);
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