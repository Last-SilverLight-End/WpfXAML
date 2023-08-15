using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCheckBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /* 특정 부분만 지칭 할 경우에 진행
         * private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.Gray;
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.White;
        }*/

        // 이벤트 이름을 같게 하여 진행
        private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbHam.IsChecked = newVal;
            cbTuna.IsChecked = newVal;
        }
       
        private void cbTopingsCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if((cbCheese.IsChecked== true)  && (cbHam.IsChecked == true) && (cbTuna.IsChecked == true))
            {
                cbParent.IsChecked = true;
            }
            if ((cbCheese.IsChecked == false) && (cbHam.IsChecked == false) && (cbTuna.IsChecked == false))
            {
                cbParent.IsChecked = false;
            }
        }
    }
}
