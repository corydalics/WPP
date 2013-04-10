using System.Collections.Generic;
using System.Linq;


namespace WPPlayer.Models
{
    public class ServerProvider : IServerProvider
    {
        private readonly IList<Server> _servers;

        public ServerProvider()
        {
            _servers = new List<Server>();
            SelectedServer = _servers.FirstOrDefault();
        }

        public IEnumerable<Server> Servers
        {
            get { return _servers; }
        }

        public Server SelectedServer { get; set; }

        public void Add(Server server)
        {
            this._servers.Add(server);
        }
    }
}
