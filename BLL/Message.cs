using System.Threading.Tasks;

using SimpleBot.Contracts;

namespace SimpleBot.BLL
{
    public class Message: IMessage
    {
        #region| Methods |

        public async Task SaveMessage(string message)
        {
            var DAL = new DAL.Message();

            await DAL.SaveMessage(message);

            DAL = null;
        } 

        #endregion
    }
}
