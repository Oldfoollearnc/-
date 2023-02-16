using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using 智能寝室的设计与实现.View;
using 智能寝室的设计与实现.ViewModel;

namespace 智能寝室的设计与实现
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        //返回容器 MainWindow
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //注册
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowVM>("maininterface");
        }
    }
}
