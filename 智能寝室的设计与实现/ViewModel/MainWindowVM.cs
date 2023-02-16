using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Prism.Commands;
using Prism.Mvvm;
using 智能寝室的设计与实现.Model;

namespace 智能寝室的设计与实现.ViewModel
{
    public class MainWindowVM
    {
        //创建与Model通讯属性
        public MainModel MymainModel { get; set; } = new MainModel();
        //创建与help通讯的类
        public Helpcs helpcsc { get; set; }=new Helpcs();
        public Border myborder { get; set; }
        public MainWindowVM()
        {
        }
        //创建icommand  reduce

        public ICommand  Close { get => new DelegateCommand(() => { App.Current.Shutdown(); }); }
        public ICommand reduce { get => new DelegateCommand(() => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized; }); }
        public ICommand OPenskin { get => new DelegateCommand(() => 
        {
            MymainModel.Isopen = true;
        });
        }
        public ICommand Loaded { get => new DelegateCommand<object>((p) => { if (p is Border aop) myborder = aop; }); }
        public ICommand Topicswitching { get => new DelegateCommand<object>((p) => 
        {
            if (p is Border op) helpcsc.Theme = (System.Windows.Media.SolidColorBrush)op.Background;
            if (helpcsc.Theme != new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2B2B2B"))) myborder.Visibility = System.Windows.Visibility.Collapsed;
            else myborder.Visibility = System.Windows.Visibility.Visible;
        }); }
    }
}
