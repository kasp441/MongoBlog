namespace MongoBlog.Models
{
    public class Blog
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> PostIds { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
    }
}
