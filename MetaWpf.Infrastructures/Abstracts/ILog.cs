using System;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface ILog : IController
    {
        event EventHandler<EventArgs> CloseLog;
    }
}
