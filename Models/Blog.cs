using System.ComponentModel.DataAnnotations;

namespace blogger_server.Models{
   public class Blog
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        public string Body { get; set; }
        public string imgUrl { get; set; }
        public bool published { get; set; }
        public int CreatorId { get; set; }
    }
}