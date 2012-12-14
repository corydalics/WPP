using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    class ServerEditViewModel : BaseViewModel
    {
        private Server _selectedServer;
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

        public ICommand SaveCommand { get ; set; }
    }
}
