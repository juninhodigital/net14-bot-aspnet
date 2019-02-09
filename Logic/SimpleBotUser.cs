using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            SaveMessage(message.Text);

            return $"{message.User} disse '{message.Text}";
        }

        private async Task SaveMessage(string message)
        {
            var conn = "mongodb://localhost:27017";

            var client = new MongoClient(conn);

            var db = client.GetDatabase("demo");
            var col = db.GetCollection<BsonDocument>("messages");

            var document = new BsonDocument
            {
              {"message", message},
            };

            await col.InsertOneAsync(document);

            client = null;
            db     = null;
        }
    }

    public class Message: BsonDocument
    {
        public string Text { get; set; }
    }
}