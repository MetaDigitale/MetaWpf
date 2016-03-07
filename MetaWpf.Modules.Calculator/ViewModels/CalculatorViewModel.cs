using System.Windows.Input;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.Calculator.Abstracts;

namespace MetaWpf.Modules.Calculator.ViewModels
{
    public class CalculatorViewModel : ICalculatorViewModel
    {
        private readonly CalculatorController _calculatorController;

        private readonly ICommand _closeCommand;
        private readonly ICommand _computeCommand;

        public CalculatorViewModel(IModulesCalculator calculatorController)
        {
            this._calculatorController = (CalculatorController) calculatorController;

            this._closeCommand = new CommandModel(this.OnCloseCommand);
            this._computeCommand = new CommandModel(this.OnComputeCommand);
        }

        #region Command
        public ICommand CloseCommand => this._closeCommand;
        private void OnCloseCommand(object parameter)
        {
            this._calculatorController.InvokeCloseGestioneCalculator(parameter);
        }

        private ICommand computeCommand => this._computeCommand;
        private void OnComputeCommand(object parameter)
        { }
        #endregion
    }
}