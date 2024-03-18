using MongoDB.Bson;

namespace MongoBlog.Models
{
    public class Post
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public ObjectId UserId { get; set; }
    }
}
