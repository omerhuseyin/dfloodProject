//coded by wés <3
using System.Threading.Tasks;

namespace DFlood
{
    internal interface IMessageChannel
    {
        Task SendMessageAsync(string v);
    }
}