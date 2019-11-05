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

namespace uppgift5
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int numone, numtwo, numsum;
        bool onoff = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputChecker();

            if (onoff == true) 
            {
                NumInput();
                ShowNumSum();
            }

            else 
            {
                ResetAll();
            }

        }

        public void NumInput() 
        {
            numone = int.Parse(tal1.Text);
            numtwo = int.Parse(tal2.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }

        public void ShowNumSum() 
        {
            numsum = numone + numtwo;
            summa.Text = numsum.ToString();
        }
        public void ResetAll() 
        {
            numone = 0;
            numtwo = 0;
            tal1.Clear();
            tal2.Clear();
            summa.Clear();
            onoff = false;
        }
        public bool InputChecker() 
        {
            if ((tal1.Text == "") || (tal2.Text==""))
            {
                MessageBox.Show("Mata in rätt");
                return onoff;
            }
            if (!int.TryParse(tal1.Text, out numone)|| (!int.TryParse(tal2.Text, out numtwo)))
            {
                MessageBox.Show("Mata in rätt");
                return onoff;
            }
            else 
            {
                onoff = true;
                return onoff;
            }
        }
    }
}
