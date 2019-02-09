
using MongoDB.Bson;

namespace SimpleBot.Logic
{
    public class Message: BsonDocument
    {
        public string Text { get; set; }
    }
}