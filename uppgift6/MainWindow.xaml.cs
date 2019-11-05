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

namespace uppgift6
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        double numOne, numTwo;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void InputNum(double a, double b) 
        {
            numOne = a;
            numTwo = b;
        }

        public double AddNum() 
        {
            double addResult = numOne + numTwo;
            return addResult;
        }

        public double SubNum() 
        {
            double subResult = numOne - numTwo;
            return subResult;
        }

        public double MultiNum()
        {
            double multiResult = numOne * numTwo;
            return multiResult;
        }

        public double DevNum() 
        {
            double devResult = numOne / numTwo;
            return devResult;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputNum(double.Parse(txtboxOne.Text), double.Parse(txboxTwo.Text));
            txtboxResult.Text = AddNum().ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InputNum(double.Parse(txtboxOne.Text), double.Parse(txboxTwo.Text));
            txtboxResult.Text = SubNum().ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputNum(double.Parse(txtboxOne.Text), double.Parse(txboxTwo.Text));
            txtboxResult.Text = MultiNum().ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InputNum(double.Parse(txtboxOne.Text), double.Parse(txboxTwo.Text));
            txtboxResult.Text = DevNum().ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }

        public void ResetAll()
        {
            numOne = 0;
            numTwo = 0;
            txtboxOne.Clear();
            txboxTwo.Clear();
            txtboxResult.Clear();
        }

    }
}
