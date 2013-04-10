using System.Net;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    public class ServerEditViewModel : BaseViewModel
    {
        private readonly IServerProvider _serverProvider;
        private string _address;
        private int _port;
        private string _hostName;

        public ServerEditViewModel(IServerProvider serverProvider)
        {
            _serverProvider = serverProvider;
            _address = "192.168.1.1";
            _port = 21;
            _hostName = "default";
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                FirePropertyChanged();
            }
        }

        public int Port
        {
            get { return _port; }
            set
            {
                _port = value;
                FirePropertyChanged();
            }
        }

        public string HostName
        {
            get { return _hostName; }
            set
            {
                _hostName = value;
                FirePropertyChanged();
            }
        }

        public Server SelectedServer
        {
            get
            {
                return _serverProvider.SelectedServer;
            }
            set
            {
                _serverProvider.SelectedServer = value;
                FirePropertyChanged();
            }
        }

        public void SaveDetails()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(Address), Port);
            var name = HostName;
            var server = new Server {EndPoint = ipEndPoint, Name = HostName};
            _serverProvider.Add(server);
        }

        protected override void Init()
        {
        }
    }
}
