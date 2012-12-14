using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Shell;

namespace WPPlayer.Helpers
{
    public class ApplicationBarIconButtonCommanded : DependencyObject, IApplicationBarIconButton
    {

        private readonly ApplicationBarIconButton _applicationBarIconButton;


        public bool IsEnabled
        {
            get { return _applicationBarIconButton.IsEnabled; }
            set { _applicationBarIconButton.IsEnabled = value; }
        }

        public string Text
        {
            get { return _applicationBarIconButton.Text; }
            set { _applicationBarIconButton.Text = value; }
        }

        public Uri IconUri
        {
            get { return _applicationBarIconButton.IconUri; }
            set { _applicationBarIconButton.IconUri = value; }
        }

        public event EventHandler Click;

        public ApplicationBarIconButtonCommanded()
        {
            _applicationBarIconButton = new ApplicationBarIconButton();
        }

        public ApplicationBarIconButtonCommanded(Uri iconUri)
        {
            _applicationBarIconButton = new ApplicationBarIconButton(iconUri);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(ApplicationBarMenuItemCommanded), new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(ApplicationBarMenuItemCommanded), new PropertyMetadata(default(object)));

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set
            {
                SetValue(CommandProperty, value);
                if (value != null)
                {
                    _applicationBarIconButton.Click += (sender, args) => value.Execute(GetValue(CommandParameterProperty));
                }
            }
        }
    }
}
