using System.Collections.Generic;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private List<Server> _servers;
        public List<Server> Servers
        {
            get { return _servers; }
            set
            {
                _servers = value;
                FirePropertyChanged();
            }
        }
    }
}
