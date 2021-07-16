using System.Collections.Generic;
using System.Data;
using System.Linq;
using blogger_server.Models;
using Dapper;

namespace blogger_server.Data
{
  public class BlogsRepository
  {
    private readonly IDbConnection _db;
    public BlogsRepository(IDbConnection db)
    { _db = db;
    }
    public List<Blog> GetAllBlogs()
    {
      var sql = "SELECT * FROM blogs";
      return _db.Query<Blog>(sql).ToList();
    }
    internal Blog GetBlog(int id)
    {
      var sql = "SELECT * FROM blogs WHERE id =@id";
      return _db.QueryFirstOrDefault<Blog>(sql, new { id });
    } 
  }
}