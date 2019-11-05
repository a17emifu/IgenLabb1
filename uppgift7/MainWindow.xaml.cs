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

namespace uppgift7
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int numOne, numTwo;
        Calc calc = new Calc();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void InputNum(int a, int b)
        {
            numOne = a;
            numTwo = b;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputNum(int.Parse(boxOne.Text), int.Parse(boxTwo.Text));

            calc.SetNum(numOne, numTwo);
            calc.ListMaker();
            calc.DivCalc();

            boxResult.Text = calc.counter.ToString();
            boxRest.Text = calc.rest.ToString();
        }


    }
}
