using System;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface IMainMenu : IController
    {
        event EventHandler<EventArgs> GestioneLog;
        event EventHandler<EventArgs> GestioneParametri;
    }
}
