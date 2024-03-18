using MongoDB.Driver;

namespace MongoBlog.repo
{
    public class Client
    {
        private readonly string _connectionString;
        IMongoClient _client;
        public Client(string connectionString)
        {
            _connectionString = connectionString;
            Connect();
        }

        public void Connect()
        {
            _client = new MongoClient(_connectionString);
        }

            public IMongoCollection<T> GetCollection<T>(string databaseName, string CollectionName) 
        {
            return _client.GetDatabase(databaseName).GetCollection<T>(CollectionName);
        }
    }
}
