using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 智能寝室的设计与实现.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
   
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            //popup1.VerticalOffset = 150;
            //popup1.HorizontalOffset = 50;


            //popup1.VerticalOffset = -60;
            //popup1.HorizontalOffset = -95;
            //kongjian.TranslatePoint(mousePoint,grid);
            //
            //


        }
        public CustomPopupPlacement[] placePopup(Size popupSize, Size targetSize, Point offset)
        {
            CustomPopupPlacement placement1 =  new CustomPopupPlacement(new Point(5,5), PopupPrimaryAxis.Vertical);
             

            CustomPopupPlacement placement2 = new CustomPopupPlacement(new Point(0, 0), PopupPrimaryAxis.Horizontal);
               

            CustomPopupPlacement[] ttplaces =      new CustomPopupPlacement[] { placement1, placement2 };
              
            return ttplaces;
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            //this.UpdateLayout();
          //  Point point=    e.GetPosition(grid);
            Point  mousePoinst = kongjian.TranslatePoint(new Point(0,0) ,grid);
          
            //   popup1.CustomPopupPlacementCallback = new CustomPopupPlacementCallback(placePopup);

        }
    }
}
