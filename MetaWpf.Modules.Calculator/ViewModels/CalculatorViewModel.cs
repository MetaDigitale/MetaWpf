using System.Windows.Input;
using MetaWpf.Domain.Abstracts;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.Calculator.Abstracts;

namespace MetaWpf.Modules.Calculator.ViewModels
{
    public class CalculatorViewModel : ViewModel, ICalculatorViewModel
    {
        private readonly CalculatorController _calculatorController;
        private readonly IMathTools _mathTools;

        private readonly ICommand _closeCommand;
        private readonly ICommand _computeCommand;
        private readonly ICommand _addCommand;
        private readonly ICommand _substractCommand;

        private int _numero1;
        private int _numero2;
        private int _result;

        public CalculatorViewModel(IModulesCalculator calculatorController,
            IMathTools mathTools)
        {
            this._calculatorController = (CalculatorController) calculatorController;
            this._mathTools = mathTools;

            this._closeCommand = new CommandModel(this.OnCloseCommand);
            this._computeCommand = new CommandModel(this.OnComputeCommand);
            this._addCommand = new CommandModel(this.OnAddCommand);
            this._substractCommand = new CommandModel(this.OnSubstractCommand);
        }

        #region Public Property
        public int Numero1
        {
            get { return this._numero1; }
            set
            {
                if (this._numero1 == value) return;

                this._numero1 = value;
                this.InvokePropertyChanged("Numero1");
            }
        }

        public int Numero2
        {
            get { return this._numero2; }
            set
            {
                if (this._numero2 == value) return;

                this._numero2 = value;
                this.InvokePropertyChanged("Numero2");
            }
        }

        public int Result
        {
            get { return this._result; }
            set
            {
                if (this._result == value) return;

                this._result = value;
                this.InvokePropertyChanged("Result");
            }
        }
        #endregion

        #region Private Methods
        private void ComputeAddCommand()
        {
            this.Result = this._mathTools.Add(this.Numero1, this.Numero2);
        }

        private void ComputeSubstractCommand()
        {
            this.Result = this._mathTools.Substract(this.Numero1, this.Numero2);
        }
        #endregion

        #region Command
        public ICommand CloseCommand => this._closeCommand;
        private void OnCloseCommand(object parameter)
        {
            this._calculatorController.InvokeCloseGestioneCalculator(parameter);
        }

        public ICommand ComputeCommand => this._computeCommand;
        private void OnComputeCommand(object parameter)
        { }

        public ICommand AddCommand => this._addCommand;
        private void OnAddCommand(object parameter)
        {
            this.ComputeAddCommand();
        }

        public ICommand SubstractCommand => this._substractCommand;
        private void OnSubstractCommand(object parameter)
        {
            this.ComputeSubstractCommand();
        }
        #endregion
    }
}