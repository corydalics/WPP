using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Phone.Shell;

namespace WPPlayer.Helpers
{
    class ApplicationBarMenuItemCommanded : ApplicationBarMenuItem
    {

        private readonly Button _button;

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof (ICommand), typeof (ApplicationBarMenuItemCommanded), new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof (object), typeof (ApplicationBarMenuItemCommanded), new PropertyMetadata(default(object)));

        public ApplicationBarMenuItemCommanded()
        {
            _button = new Button();
        }

        public object CommandParameter
        {
            get { return (object) _button.GetValue(CommandParameterProperty); }
            set { _button.SetValue(CommandParameterProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand) _button.GetValue(CommandProperty); }
            set
            {
                _button.SetValue(CommandProperty, value);
                if (value != null)
                {
                    this.Click += (sender, args) =>  value.Execute(_button.GetValue(CommandParameterProperty)) ;
                }
            }
        }
    }
}
