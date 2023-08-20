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

namespace WpfCatYears
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

        private void InputCatAge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                try
                {
                    int inputCatAge = Int32.Parse(InputCatAge.Text);
                    string resultHumanAge = "";

                    if(inputCatAge > 0 && inputCatAge <= 1)
                    {
                        resultHumanAge = "0-15";
                        ResultTextBlock.Text = " Your cat is " + resultHumanAge + " years old";
                    }
                    else if (inputCatAge > 0 && inputCatAge <= 1)
                    {
                        resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                        ResultTextBlock.Text = " Your cat is " + resultHumanAge + " years old";
                    }
                    else
                    {
                        ResultTextBlock.Text = "your Cat is not between 0-25 " + resultHumanAge 
                            + " Your cat maybe old or not born!"; 
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Not a Valid Number, Enter Numberic Value! " + ex.Message);
                }
            }
        }
    }
}
