using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PinPong.Core;


namespace PingPong.Core
{
    public class GameCommand : ICommand
    {
        Action<Object> _execute;
        Func<Object, bool> _canExecute;

        public GameCommand(Action<Object> execute, Func<Object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}