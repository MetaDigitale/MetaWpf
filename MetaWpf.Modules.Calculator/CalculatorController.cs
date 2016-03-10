using System;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Abstracts;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.Calculator.Abstracts;
using Microsoft.Practices.Unity;

namespace MetaWpf.Modules.Calculator
{
    public class CalculatorController : IModulesCalculator
    {
        private readonly IUnityContainer _container;
        private readonly IRegion _mainRegion;

        public CalculatorController(
            IUnityContainer container,
            [Dependency(RegionNames.MainRegion)] IRegion mainRegion)
        {
            this._container = container;
            this._mainRegion = mainRegion;
        }

        public void Run()
        {
            var calculatorViewModel = this._container.Resolve<ICalculatorViewModel>();
            this._mainRegion.Context = calculatorViewModel;
        }

        #region EventHandler
        public event EventHandler<EventArgs> CloseGestioneCalculator;

        internal void InvokeCloseGestioneCalculator(object parameter)
        {
            var handler = this.CloseGestioneCalculator;
            handler?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}