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

namespace uppgift4
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        string veckodag;
        string btndag;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void Labelmaker(string dag) 
        {
            btndag = dag;
            veckodag = $"Du klickade på knappen {dag}";

        }
        public void Labelviewer() 
        {
            lbl.Content = veckodag;
        }

        private void btnMån_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnMån.Content.ToString());
            Labelviewer();
        }

        private void btnTis_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnTis.Content.ToString());
            Labelviewer();
        }

        private void btnOns_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnOns.Content.ToString());
            Labelviewer();
        }

        private void btnTors_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnTors.Content.ToString());
            Labelviewer();
        }

        private void btnFre_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnFre.Content.ToString());
            Labelviewer();
        }

        private void btnLör_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnLör.Content.ToString());
            Labelviewer();
        }

        private void btnSön_Click(object sender, RoutedEventArgs e)
        {
            Labelmaker(btnSön.Content.ToString());
            Labelviewer();
        }
    }
}
