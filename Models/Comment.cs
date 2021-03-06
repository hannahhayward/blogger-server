using System.ComponentModel.DataAnnotations;

namespace blogger_server.Models{
     public class Comment
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        [Required]
        [MaxLength(240)]
        public string Body { get; set; }
        [Required]
        public int Blog { get; set; }
    }
  }