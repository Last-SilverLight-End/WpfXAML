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

namespace WpfHelloWorld
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock myTb= new TextBlock();
            myTb.Text = "Hello world";
            myTb.Inlines.Add(" this is added using inlines!");
            myTb.Inlines.Add(new Run(" Run Text tgat i added in code Behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BurlyWood;
            this.Content = myTb;
        }


    }
}
