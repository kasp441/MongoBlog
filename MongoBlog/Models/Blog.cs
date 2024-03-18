using MongoDB.Bson;

namespace MongoBlog.Models
{
    public class Blog
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ObjectId> PostIds { get; set; }
        public DateTime CreatedAt { get; set; }
        public ObjectId UserId { get; set; }
    }
}
