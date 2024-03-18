using MongoDB.Bson;

namespace MongoBlog.Models
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
