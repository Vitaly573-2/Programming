using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует интерфейс <see cref="ICommand"/> для привязки команд в WPF,
    /// позволяя определить действия для выполнения
    /// и условия, при которых команда может быть выполнена.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, представляющий метод, выполняющийся при вызове команды.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, определяющий, может ли команда быть выполнена.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Конструктор команды.
        /// </summary>
        /// <param name="execute">Метод, который будет выполнен при вызове команды.</param>
        /// <param name="canExecute">Метод, который проверяет, можно ли выполнить команду.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute)); 
            _canExecute = canExecute;
        }

        /// <summary>
        /// Событие, которое вызывается, когда изменяется возможность выполнения команды.
        /// (подписывается на событие при создании 
        /// и отписывается от него при удалении)
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Метод, проверяющий возможность выполнения команды.
        /// </summary>
        /// <param name="parameter">Объект, которые несет в себе смысл можно или нет.</param>
        /// <returns>Булевое значение можно выполнить команду или нет.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Метод, выполняет команду.
        /// </summary>
        /// <param name="parameter">Объект(команда).</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
