using MetaWpf.Infrastructures.Abstracts;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.MainMenu.Abstracts;
using MetaWpf.Modules.MainMenu.ViewModels;
using Microsoft.Practices.Unity;

namespace MetaWpf.Modules.MainMenu
{
    public class MainMenuModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IMainMenuViewModel, MainMenuViewModel>();

            container.RegisterType<IModulesMainMenu, MainMenuController>();
        }
    }
}
