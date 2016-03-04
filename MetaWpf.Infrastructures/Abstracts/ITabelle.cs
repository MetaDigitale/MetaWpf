using System;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface ITabelle : IController
    {
        event EventHandler<EventArgs> CloseTabelle;
    }
}
