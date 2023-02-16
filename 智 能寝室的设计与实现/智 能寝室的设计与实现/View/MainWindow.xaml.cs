

using LayUI.Wpf.Controls;
using 智_能寝室的设计与实现.Materia.Class.ViewModel;

namespace 智_能寝室的设计与实现.View
{
    public partial class MainWindow : LayWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
    }
}
