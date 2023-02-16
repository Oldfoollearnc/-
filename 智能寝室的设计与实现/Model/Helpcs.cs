using Prism.Mvvm;
using System.Windows.Media;

namespace 智能寝室的设计与实现.Model
{
	public class Helpcs:BindableBase
    {
        // #363636	
        private SolidColorBrush theme =new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF363636")) ;

		public SolidColorBrush Theme
		{
			get { return theme; }
			set { theme = value;RaisePropertyChanged(); }
		}

	}
}
