using System.Configuration;
using System.Threading.Tasks;
using SimpleBot.BLL;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        #region| Methods |

        public string Reply(SimpleMessage message)
        {
            SaveMessage(message.Text).Wait();

            return $"{message.User} disse '{message.Text}";
        }

        private async Task SaveMessage(string message)
        {
            var client = new BLL.Message();

            await client.SaveMessage(message);

            client = null;

        } 

        #endregion
    }
}