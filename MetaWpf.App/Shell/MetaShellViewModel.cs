using System.Windows;
using System.Windows.Input;

using MetaWpf.App.Abstracts;
using MetaWpf.Infrastructures;
using MetaWpf.Infrastructures.Abstracts;
using Microsoft.Practices.Unity;

namespace MetaWpf.App.Shell
{
    public class MetaShellViewModel : ViewModel, IMetaShell
    {
        private readonly IRegion _headerRegion;
        private readonly IRegion _mainRegion;
        private readonly IRegion _menuRegion;

        private readonly ICommand _closeCommand;

        public MetaShellViewModel(IUnityContainer container)
        {
            this._headerRegion = new RegionModel();
            this._mainRegion = new RegionModel();
            this._menuRegion = new RegionModel();

            // Define UI regions
            container.RegisterInstance<IRegion>(
                RegionNames.HeaderRegion, this._headerRegion,
                new ContainerControlledLifetimeManager());

            container.RegisterInstance<IRegion>(
                RegionNames.MainRegion, this._mainRegion,
                new ContainerControlledLifetimeManager());

            container.RegisterInstance<IRegion>(
                RegionNames.MenuRegion, this._menuRegion,
                new ContainerControlledLifetimeManager());

            // Define default region
            container.RegisterInstance<IRegion>(
                this._mainRegion,
                new ContainerControlledLifetimeManager());

            // Define CloseCommand
            this._closeCommand = new CommandModel(this.OnCloseCommand);
        }

        public IRegion HeaderRegion => this._headerRegion;

        public IRegion MainRegion => this._mainRegion;

        public IRegion MenuRegion => this._menuRegion;

        public void Show()
        {
            var metaShell = new MetaShell
            {
                WindowState = WindowState.Maximized,
                DataContext = this
            };
            metaShell.Show();
        }

        public ICommand CloseCommand => this._closeCommand;

        private void OnCloseCommand(object parameter)
        {
#if DEBUG
            Application.Current.Shutdown();
#else
            if (MessageBoxFunctions.ShowCloseApplicationMessageBox())
                Application.Current.Shutdown();
#endif
        }
    }
}