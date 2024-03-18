namespace MongoBlog.repo
{
    public class BlogRepo
    {
        public BlogRepo()
        {
            var client = new Client("mongodb://localhost:27017");
            var blogCollection = client.GetCollection<Blog>("blog", "blogs");
            var postCollection = client.GetCollection<Post>("blog", "posts");
            var commentCollection = client.GetCollection<Comment>("blog", "comments");
        }
    }
}
