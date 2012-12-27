using System.Collections.Generic;

namespace WPPlayer.Models
{
    public interface IServerProvider
    {
        IEnumerable<Server> Servers { get; }
        void Add(Server selectedServer);
    }
}