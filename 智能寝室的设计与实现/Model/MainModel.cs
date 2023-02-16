using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 智能寝室的设计与实现.Model
{
    public class MainModel:BindableBase
    {
		private bool isopen;

		public bool Isopen
        {
			get { return isopen; }
			set { isopen = value;  RaisePropertyChanged(); }//RaisePropertyChanged 通知更新
        }

	}
}
