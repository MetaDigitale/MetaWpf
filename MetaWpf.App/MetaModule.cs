using MetaWpf.App.Abstracts;
using MetaWpf.App.Shell;
using MetaWpf.Infrastructures.Abstracts;
using Microsoft.Practices.Unity;

namespace MetaWpf.App
{
    public class MetaModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IMetaShell, MetaShellViewModel>(
                new ContainerControlledLifetimeManager());
        }
    }
}