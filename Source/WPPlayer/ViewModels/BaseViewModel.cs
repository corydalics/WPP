using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPPlayer.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void FirePropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Initialize()
        {
            Init();
        }

        protected abstract void Init();
    }
}
