using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using 智_能寝室的设计与实现.Data;
using 智_能寝室的设计与实现.View;

namespace 智_能寝室的设计与实现.Materia.Class.ViewModel
{
    public class drVM:BindableBase
    {
        //object[] objects;
        public drVM()
        {
        }
        public ICommand dengru { get => new DelegateCommand<object[]>((p) =>
        {
            //objects = p;
            Dengruyanzhen(p);
        }); }

        private static void Dengruyanzhen(object[] p)
        {
            if (p[0].ToString() == Settings1.Default.user)
            {
            new MainWindow().Show(); (p[1] as 登入).Close();
            }    /*Settings1.Default.user = (string)p[0]; Settings1.Default.*/
        }

        //public ICommand kjj { get => new DelegateCommand<object>((p) => { if ((p as KeyEventArgs).Key == Key.Enter) Dengruyanzhen(objects);
        //}); 
        //}
    }
}
