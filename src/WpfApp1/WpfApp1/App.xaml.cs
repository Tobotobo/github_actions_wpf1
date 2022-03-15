using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using WpfApp1.Models;
using WpfApp1.Views;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = new UnityContainer();
            container.RegisterSingleton<ICalcService, CalcService>();

            var vm = container.Resolve<MainWindowViewModel>();
            new MainWindow(vm).Show();
        }
    }
}
