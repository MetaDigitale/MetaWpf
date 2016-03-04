using System;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface IAccount : IController
    {
        event EventHandler<EventArgs> LogOnSuccess;
        event EventHandler<EventArgs> LogOnFailed;
        event EventHandler<EventArgs> CloseAccount;
    }
}
