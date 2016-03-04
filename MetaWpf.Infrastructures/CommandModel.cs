using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MetaWpf.Infrastructures
{
    public class CommandModel : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public CommandModel(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public CommandModel(Action<object> execute) : this(execute, null) { }

        #region ICommand Members

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null ? true : this.canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        #endregion
    }
}
