using System.Windows;
using UpdaterLib;

namespace TestUpdaterRepo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Updater.CheckForUpdate("https://api.github.com/repos/weexnes/TestUpdaterRepo/releases/latest", GLobals.Version);
        }
    }
}