using System.Configuration;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

using SimpleBot.Contracts;

namespace SimpleBot.DAL
{
    public class Message: IMessage
    {
        #region| Methods | 

        public async Task SaveMessage(string message)
        {
            var conn = ConfigurationManager.AppSettings["ConnectionString"];

            var client = new MongoClient(conn);

            var db = client.GetDatabase("demo");
            var col = db.GetCollection<BsonDocument>("messages");

            var document = new BsonDocument
            {
                {"message", message},
            };

            await col.InsertOneAsync(document);

            client = null;
            db = null;
        } 

        #endregion
    }
}
