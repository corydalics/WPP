using System.Collections.ObjectModel;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IServerProvider _serverProvider;
        private ObservableCollection<Server> _servers;

        public MainPageViewModel(IServerProvider serverProvider)
        {
            _serverProvider = serverProvider;
        }

        public Server SelectedServer
        {
            get { return _serverProvider.SelectedServer; }
            set
            {
                _serverProvider.SelectedServer = value;
                FirePropertyChanged();
            }
        }

        public ObservableCollection<Server> Servers
        {
            get { return _servers; }
            private set
            {
                _servers = value;
                FirePropertyChanged();
            }
        }


        protected override void Init()
        {
            Servers = new ObservableCollection<Server>(_serverProvider.Servers);
        }
    }
}
