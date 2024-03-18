using MongoBlog.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoBlog.repo
{
    public class UserRepo
    {
        private readonly Client _client;
        public UserRepo()
        {

            _client = new Client("mongodb://localhost:27017");
        }

        //Create User
        public void CreateUser(User user)
        {
            var collection = _client.GetCollection<User>("Blog", "User");
            collection.InsertOne(user);
        }

        /// <summary>
        /// update the user by object
        /// </summary>
        /// <param name="user"></param>
        public void UpdateUser(User user)
        {
            var collection = _client.GetCollection<User>("Blog", "User");
            var filter = Builders<User>.Filter.Eq(x => x.Id, user.Id);
            collection.ReplaceOne(filter, user);
        }

        /// <summary>
        /// del user 
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(User user)
        {
            var collection = _client.GetCollection<User>("Blog", "User");
            var filter = Builders<User>.Filter.Eq(x => x.Id, user.Id);
            collection.DeleteOne(filter);
        }

        /// <summary>
        /// find user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(ObjectId id)
        {
            var collection = _client.GetCollection<User>("Blog", "User");
            var filter = Builders<User>.Filter.Eq(x => x.Id, id);
            return collection.Find(filter).FirstOrDefault();
        }

    }
}
