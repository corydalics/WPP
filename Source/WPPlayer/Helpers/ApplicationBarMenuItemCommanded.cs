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
    class ApplicationBarMenuItemCommanded : DependencyObject, IApplicationBarMenuItem
    {
        private readonly ApplicationBarMenuItem _applicationBarMenuItem;

        public bool IsEnabled
        {
            get { return _applicationBarMenuItem.IsEnabled; }
            set { _applicationBarMenuItem.IsEnabled = value; }
        }

        public string Text
        {
            get { return _applicationBarMenuItem.Text; }
            set { _applicationBarMenuItem.Text = value; }
        }

        public event EventHandler Click
        {
            add { _applicationBarMenuItem.Click += value; }
            remove { _applicationBarMenuItem.Click -= value; }
        }

        public ApplicationBarMenuItemCommanded()
        {
            _applicationBarMenuItem = new ApplicationBarMenuItem();
        }

        public ApplicationBarMenuItemCommanded(string text)
        {
            _applicationBarMenuItem = new ApplicationBarMenuItem(text);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof (ICommand), typeof (ApplicationBarMenuItemCommanded), new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof (object), typeof (ApplicationBarMenuItemCommanded), new PropertyMetadata(default(object)));

        public object CommandParameter
        {
            get { return (object) GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand) GetValue(CommandProperty); }
            set
            {
                SetValue(CommandProperty, value);
                if (value != null)
                {
                    _applicationBarMenuItem.Click += (sender, args) =>  value.Execute(GetValue(CommandParameterProperty)) ;
                }
            }
        }
    }
}
