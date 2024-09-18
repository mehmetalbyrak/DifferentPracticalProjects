using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDBOrder.Services
{
    public class MongoDBConnection
    {
        private IMongoDatabase _database;

        public MongoDBConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("DBOrder");
        }

        public IMongoCollection<BsonDocument> GetOrdersCollection()
        {
            return _database.GetCollection<BsonDocument>("Orders");
        }


    }
}
