namespace MongoBlog.repo
{
    public class Repo
    {
        private readonly Client _client;
        public Repo(string connectionString)
        {
            _client = new Client(connectionString);
        }


    }
}
