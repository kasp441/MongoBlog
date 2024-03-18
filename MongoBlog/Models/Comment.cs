using MongoDB.Bson;

namespace MongoBlog.Models
{
    public class Comment
    {
        public ObjectId Id { get; set; }
        public string Content { get; set; }
        public ObjectId PostId { get; set; }
        public DateTime CreatedAt { get; set; }

        public ObjectId UserId { get; set; }
    }
}
