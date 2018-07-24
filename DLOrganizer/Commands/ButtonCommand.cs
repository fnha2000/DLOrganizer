﻿using System;
using System.Windows.Input;

namespace DLOrganizer.Commands
{
    public class ButtonCommand<T> : ICommand
    {
        private Action<T> ExecuteFunc;
        private Func<bool> ExecuteAllowed;

        public event EventHandler CanExecuteChanged;

        public ButtonCommand(Action<T> func, Func<bool> allowed)
        {
            ExecuteFunc = func;
            ExecuteAllowed = allowed;
        }

        public bool CanExecute(object parameter)
        {
            return ExecuteAllowed();
        }

        public void Execute(object parameter)
        {
            ExecuteFunc((T)parameter);
        }
    }
}
