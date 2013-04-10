using System.Collections.Generic;


namespace WPPlayer.Models
{
    public class ServerProvider : IServerProvider
    {
        private readonly IList<Server> _servers;

        public ServerProvider()
        {
            _servers = new List<Server>();
        }

        public IEnumerable<Server> Servers
        {
            get { return _servers; }
        }

        public void Add(Server server)
        {
            this._servers.Add(server);
        }
    }
}
