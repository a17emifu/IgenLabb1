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

namespace uppgift3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string on = "Klickad";
        string off = "Oklickad";
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            btnvänster.Content = on;
            btnhöger.Content = off;
        }

        private void btnhöger_Click(object sender, RoutedEventArgs e)
        {
            btnvänster.Content = off;
            btnhöger.Content = on;
        }
    }
}
