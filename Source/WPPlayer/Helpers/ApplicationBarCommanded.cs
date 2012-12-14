using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;
using Microsoft.Phone.Shell;

namespace WPPlayer.Helpers
{
    [ContentProperty("Buttons")]
    class ApplicationBarCommanded : IApplicationBar
    {
        private readonly ApplicationBar _applicationBar;

        public bool IsVisible
        {
            get { return _applicationBar.IsVisible; }
            set { _applicationBar.IsVisible = value; }
        }

        public double Opacity
        {
            get { return _applicationBar.Opacity; }
            set { _applicationBar.Opacity = value; }
        }

        public bool IsMenuEnabled
        {
            get { return _applicationBar.IsMenuEnabled; }
            set { _applicationBar.IsMenuEnabled = value; }
        }

        public Color BackgroundColor
        {
            get { return _applicationBar.BackgroundColor; }
            set { _applicationBar.BackgroundColor = value; }
        }

        public Color ForegroundColor
        {
            get { return _applicationBar.ForegroundColor; }
            set { _applicationBar.ForegroundColor = value; }
        }

        public ApplicationBarMode Mode
        {
            get { return _applicationBar.Mode; }
            set { _applicationBar.Mode = value; }
        }

        public double DefaultSize
        {
            get { return _applicationBar.DefaultSize; }
        }

        public double MiniSize
        {
            get { return _applicationBar.MiniSize; }
        }

        public IList Buttons
        {
            get { return _applicationBar.Buttons; }
        }

        public IList MenuItems
        {
            get { return _applicationBar.MenuItems; }
        }

        public event EventHandler<ApplicationBarStateChangedEventArgs> StateChanged
        {
            add { _applicationBar.StateChanged += value; }
            remove { _applicationBar.StateChanged -= value; }
        }

        public ApplicationBarCommanded()
        {
            _applicationBar = new ApplicationBar();
        }
    }
}
