using System;
using System.Threading.Tasks;

namespace SimpleBot.Contracts
{
    public interface IMessage
    {
        Task SaveMessage(string message);
    }
}
