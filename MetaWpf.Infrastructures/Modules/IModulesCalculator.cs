using System;
using MetaWpf.Infrastructures.Abstracts;

namespace MetaWpf.Infrastructures.Modules
{
    public interface IModulesCalculator : IController
    {
        event EventHandler<EventArgs> CloseGestioneCalculator;
    }
}