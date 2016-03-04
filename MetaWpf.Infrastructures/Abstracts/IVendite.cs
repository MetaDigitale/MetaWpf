using System;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface IVendite : IController
    {
        event EventHandler<EventArgs> CloseVendite;
    }
}
