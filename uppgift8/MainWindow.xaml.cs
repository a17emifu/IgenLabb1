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

namespace uppgift8
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Calc calc;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalcMaker(double a, double b) 
        {
            calc = new Calc(a, b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalcMaker(double.Parse(boxone.Text), double.Parse(boxtwo.Text));
            double result;

            if (btnAdd.IsChecked == true) 
            {
                result= calc.Add();
                boxresult.Text = Math.Round(result, 2).ToString();
            }

            if (btnSub.IsChecked == true)
            {
                result = calc.Sub();
                boxresult.Text = Math.Round(result, 2).ToString();
            }

            if (btnMulti.IsChecked == true)
            {
                result = calc.Multi();
                boxresult.Text = Math.Round(result, 2).ToString();
            }

            if (btnDiv.IsChecked == true)
            {
                result = calc.Div();
                boxresult.Text = Math.Round(result, 2).ToString();
            }
        }
    }
}
