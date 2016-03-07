using System;
using MetaWpf.Infrastructures.Abstracts;

namespace MetaWpf.Infrastructures.Modules
{
    public interface IModulesMainMenu : IController
    {
        event EventHandler<EventArgs> GestioneLog;
        event EventHandler<EventArgs> GestioneParametri;
        event EventHandler<EventArgs> GestioneCalculator;
    }
}
