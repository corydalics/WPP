using System.Threading.Tasks;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    public class ServerEditViewModel : BaseViewModel
    {
        private readonly IServerProvider _serverProvider;
        private Server _selectedServer;

        public ServerEditViewModel(IServerProvider serverProvider)
        {
            _serverProvider = serverProvider;

        }

        public Server SelectedServer
        {
            get
            {
                return _selectedServer;
            }
            set
            {
                _selectedServer = value;
                FirePropertyChanged();
            }
        }

        public void SaveDetails()
        {
            _serverProvider.Add(SelectedServer);
        }
    }
}
