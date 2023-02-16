using NLE.Devices.ADAM;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace 智_能寝室的设计与实现.Materia.Class.ViewModel
{
    public class MainWindowVM : BindableBase
    {
        System.Timers.Timer timer;
        double a;//是否有人
        
        public MainWindowVM()
        {
            Personcount = 1;
            yanwu = "正常";
            Datagriddata = new ObservableCollection<Datagriddatas>() { new Datagriddatas() { a1 = "user", a2 = DateTime.Now.ToString(), a3 = "修改", a4 = "管理员" } };
          ADAMSeries aDAMSeries;  aDAMSeries = new ADAMSeries();
            aDAMSeries.Connect("com200", 9600);
            timer = new System.Timers.Timer()
            {
                Interval = 3000,
                Enabled = false
            };
            timer.Elapsed += (state, e) =>
            {
                aDAMSeries.ReadADAM4150Data();
            };
            timer.Start();
            aDAMSeries.ADAM4150DataReceived += (e, s) =>
            {
                if (s.Data.DI0 == true)
                    yanwu = "异常";
                else
                    yanwu = "正常";
            };
        }
        public ICommand chuancandg
        {
            get => new DelegateCommand<object>((p) =>
            {
            });
        }



        public ObservableCollection<Datagriddatas> Datagriddata { get; set; }
        private string myVar;

        public string yanwu
        {
            get { return myVar; }
            set { myVar = value; RaisePropertyChanged(); }
        }

        private int personcount;

        public int Personcount
        {
            get { return personcount; }
            set { personcount = value;SetProperty<int>(ref personcount, value); }
        }



    }
    public class Datagriddatas
    {
        public string a1 { get; set; }
        public string a2 { get; set; }
        public string a3 { get; set; }
        public string a4 { get; set; }
    }
}
