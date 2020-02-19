using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace RadSplashScreenHidingMainWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RadSplashScreenManager.Show<CustomSplashScreen>();
            Thread.Sleep(3000);
            RadSplashScreenManager.Close();

            base.OnStartup(e);
        }
    }
}
