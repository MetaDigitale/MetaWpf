using MetaWpf.Infrastructures.Abstracts;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.Calculator.Abstracts;
using MetaWpf.Modules.Calculator.ViewModels;
using Microsoft.Practices.Unity;

namespace MetaWpf.Modules.Calculator
{
    public class CalculatorModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<ICalculatorViewModel, CalculatorViewModel>();

            container.RegisterType<IModulesCalculator, CalculatorController>();
        }
    }
}