using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPPlayer.ViewModels
{
    class FolderListViewModel : BaseViewModel
    {
        private string _folderName;
        public string FolderName 
        {
            get
            {
                return _folderName;
            }

            set
            {
                _folderName = value;
                FirePropertyChanged();
            }
        }
    }
}
