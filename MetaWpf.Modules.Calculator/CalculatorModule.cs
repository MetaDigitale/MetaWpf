using MetaWpf.Domain.Abstracts;
using MetaWpf.Domain.Concretes;
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
            container.RegisterType<IMathTools, MathTools>();

            container.RegisterType<ICalculatorViewModel, CalculatorViewModel>();

            container.RegisterType<IModulesCalculator, CalculatorController>();
        }
    }
}