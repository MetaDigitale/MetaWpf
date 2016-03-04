using System;
using System.Windows;
using MetaWpf.App.Abstracts;
using MetaWpf.Infrastructures;
using MetaWpf.Modules.MainMenu;
using Microsoft.Practices.Unity;

namespace MetaWpf.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Istanzio il contenitore principale
            IUnityContainer container = new UnityContainer();

            // Registro i Moduli
            container.Resolve<MetaWpfBoot>()
                .RegisterModule(typeof (MetaModule))
                .RegisterModule(typeof(MainMenuModule));

            // start App
            container.Resolve<IMetaShell>().Show();
            container.Resolve<Controller>().Run();
        }

        public bool DoHandle { get; set; }
        private void Application_DispatcherUnhandledException(object sender,
                               System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.Dispatcher.Thread.Name);
            //suite4log.WriteMessageLog("App.Application_DispatcherUnhandledException.Dispatcher", e.Dispatcher.Thread.Name, "ServiceLog");
            //suite4log.WriteMessageLog("App.Application_DispatcherUnhandledException", e.Exception.Message, "ServiceLog");
            MessageBox.Show(e.Exception.Message, "Exception Caught",
                                    MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = false;
        }
    }
}
