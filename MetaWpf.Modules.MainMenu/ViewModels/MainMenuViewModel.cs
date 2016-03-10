using System.Windows.Input;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Modules;
using MetaWpf.Modules.MainMenu.Abstracts;

namespace MetaWpf.Modules.MainMenu.ViewModels
{
    internal class MainMenuViewModel : IMainMenuViewModel
    {
        private readonly MainMenuController _controller;

        private readonly ICommand _gestioneLog;
        private readonly ICommand _gestioneParametri;
        private readonly ICommand _gestioneCalculator;

        public MainMenuViewModel(IModulesMainMenu mainMenu)
        {
            this._controller = (MainMenuController)mainMenu;

            this._gestioneLog = new CommandModel(this.OnGestioneLog);
            this._gestioneParametri = new CommandModel(this.OnGestioneParametri);
            this._gestioneCalculator = new CommandModel(this.OnGestioneCalculator);
        }

        #region Command
        public ICommand GestioneLog => this._gestioneLog;
        private void OnGestioneLog(object parameter)
        {
            this._controller.InvokeGestioneLog(parameter);
        }

        public ICommand GestioneParametri => this._gestioneParametri;
        private void OnGestioneParametri(object parameter)
        {
            this._controller.InvokeGestioneParametri(parameter);
        }

        public ICommand GestioneCalculator => this._gestioneCalculator;
        private void OnGestioneCalculator(object parameter)
        {
            this._controller.InvokeGestioneCalculator(parameter);
        }
        #endregion
    }
}