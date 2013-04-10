using System.Collections.Generic;

namespace WPPlayer.Models
{
    public interface IServerProvider
    {
        IEnumerable<Server> Servers { get; }
        Server SelectedServer { get; set; }
        void Add(Server selectedServer);
    }
}