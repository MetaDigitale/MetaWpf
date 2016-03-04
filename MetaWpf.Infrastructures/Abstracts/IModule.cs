using Microsoft.Practices.Unity;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
