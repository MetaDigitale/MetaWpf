using System;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Abstracts;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.MainMenu.Abstracts;
using Microsoft.Practices.Unity;

namespace MetaWpf.Modules.MainMenu
{
    internal class MainMenuController : IModulesMainMenu
    {
        private readonly IUnityContainer _container;

        private readonly IRegion _mainRegion;

        public MainMenuController(
            IUnityContainer container,
            [Dependency(RegionNames.MainRegion)] IRegion mainRegion)
        {
            this._container = container;
            this._mainRegion = mainRegion;
        }

        public void Run()
        {
            var mainMenuViewModel = this._container.Resolve<IMainMenuViewModel>();
            this._mainRegion.Context = mainMenuViewModel;
        }

        public event EventHandler<EventArgs> GestioneLog;
        internal void InvokeGestioneLog(object parameter)
        {
            var handler = this.GestioneLog;
            handler?.Invoke(this, new EventArgs());
        }

        public event EventHandler<EventArgs> GestioneParametri;
        internal void InvokeGestioneParametri(object parameter)
        {
            var handler = this.GestioneParametri;
            handler?.Invoke(this, new EventArgs());
        }
    }
}
