using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPPlayer.Models;
using System.Linq;

namespace WPPlayer.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IServerProvider _serverProvider;
        private Server _selectedServer;

        public MainPageViewModel(IServerProvider serverProvider)
        {
            _serverProvider = serverProvider;
            Servers = new ObservableCollection<Server>(_serverProvider.Servers);
            _selectedServer = Servers.FirstOrDefault();
        }

        public Server SelectedServer
        {
            get { return _selectedServer; }
            set
            {
                _selectedServer = value;
                FirePropertyChanged();
            }
        }

        public ObservableCollection<Server> Servers { get; private set; }

    }
}
