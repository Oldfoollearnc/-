using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;
using Prism.DryIoc;
using Prism.Ioc;
using 智_能寝室的设计与实现.View;
using 智_能寝室的设计与实现.Materia.Class.ViewModel;

namespace 智_能寝室的设计与实现
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
           return Container.Resolve<登入>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<登入, drVM>();
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowVM>("zjm");
        }
    }
}
