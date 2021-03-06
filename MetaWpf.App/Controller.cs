﻿using System.Threading;

using Microsoft.Practices.Unity;

using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Abstracts;
using MetaWpf.Infrastructures.Model;
using MetaWpf.Infrastructures.Modules;

namespace MetaWpf.App
{
    public class Controller : IController
    {
        private readonly IUnityContainer _container;
        private readonly IRegion _mainRegion;

        private IUnityContainer _sessionContainer;

        private MetaPrincipal _currentPrincipal;

        public Controller(
            IUnityContainer container,
            [Dependency(RegionNames.MainRegion)] IRegion mainRegion)
        {
            this._container = container;
            this._mainRegion = mainRegion;
        }

        public void Run()
        {
            var currentIdentity = new MetaIdentity("Admin", true);
            this._currentPrincipal = new MetaPrincipal(currentIdentity);

            Thread.CurrentPrincipal = this._currentPrincipal;

            // create nested (session) container
            this._sessionContainer = this._container.CreateChildContainer();

            // avvio il menu
            this.RunMainMenu();
        }

        private void RunMainMenu()
        {
            // creo MainMenu
            var mainMenu = this._sessionContainer.Resolve<IModulesMainMenu>();
            // registro il menu come sessione Singleton
            this._sessionContainer.RegisterInstance(
                mainMenu, new ContainerControlledLifetimeManager());

            // Imposto gli event handlers del menu
            mainMenu.GestioneParametri += this.MainMenu_GestioneParametri;
            mainMenu.GestioneLog += this.MainMenu_GestioneLog;
            mainMenu.GestioneCalculator += this.MainMenu_GestioneCalculator;

            // Avvio il menu
            mainMenu.Run();
        }

        private void CleanMainMenuEvents(object sender)
        {
            var mainMenu = sender as IModulesMainMenu;

            if (mainMenu == null) return;

            mainMenu.GestioneParametri -= this.MainMenu_GestioneParametri;
            mainMenu.GestioneLog -= this.MainMenu_GestioneLog;
            mainMenu.GestioneCalculator -= this.MainMenu_GestioneCalculator;
        }

        #region GestioneLog
        private void MainMenu_GestioneLog(object sender, System.EventArgs e)
        {
            this.CleanMainMenuEvents(sender);

            // TODO: Run LogManager
        }
        #endregion

        #region GestioneParametri
        private void MainMenu_GestioneParametri(object sender, System.EventArgs e)
        {
            this.CleanMainMenuEvents(sender);

            // TODO: Run SettingsManager
        }
        #endregion

        #region GestioneCalculator
        private void MainMenu_GestioneCalculator(object sender, System.EventArgs e)
        {
            this.CleanMainMenuEvents(sender);

            var gestionCalculator = this._sessionContainer.Resolve<IModulesCalculator>();
            this._container.RegisterInstance(gestionCalculator);

            gestionCalculator.CloseGestioneCalculator += this.GestionCalculator_CloseGestioneCalculator;
            gestionCalculator.Run();
        }

        private void GestionCalculator_CloseGestioneCalculator(object sender, System.EventArgs e)
        {
            var gestioneCalculator = sender as IModulesCalculator;

            if (gestioneCalculator == null) return;

            gestioneCalculator.CloseGestioneCalculator -= this.GestionCalculator_CloseGestioneCalculator;
           this.RunMainMenu();
        }
        #endregion
    }
}