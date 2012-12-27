using System;
using System.Windows.Input;

namespace WPPlayer.Helpers
{
    public class GenericCommand : ICommand
    {
        private readonly Func<bool> _canExecute;
        private readonly Action _execute;

        public GenericCommand(Func<bool> canExecute, Action execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;
    }
}