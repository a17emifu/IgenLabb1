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

namespace uppgift9
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        CeroChecker ceroChecker;
        int result;
        string viewResult;
        bool withAdult;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RegisterPerson(string namn, int age)
        {
            person = new Person(namn, age);
        }
        public void CallCeroChecker()
        {
            ceroChecker = new CeroChecker(person);
            result = ceroChecker.CeroCalc();
        }

        public void ViewResult()
        {
            switch (result)
            {
                case 0:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och får se alla filmer.";
                    break;
                case 1:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och då får du se filmer med åldersgräns upp till 11 år.";
                    break;
                case 2:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och då får se filmer med åldersgräns upp till 7 år.";
                    break;
                case 3:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och då får se filmer med barntillåten.";
                    break;
                case 4:
                    viewResult = $"Error error, vad matade du in?";
                    break;

            }
        }

        public void ViewResultWithAdult()
        {
            switch (result)
            {
                case 0:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och får se alla filmer.";
                    break;
                case 1:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och då får du se filmer med åldersgräns upp till 11 år. Det spelar ingen roll att du går tillsammans med en vuxen";
                    break;
                case 2:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och får se filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig.";
                    break;
                case 3:
                    viewResult = $"Hej {boxName.Text}. Du är {boxAge.Text} gammal och då får se filmer med barntillåten.";
                    break;
                case 4:
                    viewResult = $"Error error, vad matade du in?";
                    break;

            }
        }
        public void Result()
        {
            txtResult.Text = viewResult;
        }
        public void CompanyChecker() 
        {
            if (rbtnWithAdult.IsChecked ==true ) { withAdult = true; }
            if (rbtnWithoutAdult.IsChecked == true) { withAdult = false; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CompanyChecker();
            RegisterPerson(boxName.Text, int.Parse(boxAge.Text));
            CallCeroChecker();

            if (withAdult == true) 
            {
                ViewResultWithAdult();
            }
            if (withAdult == false) 
            {
                ViewResult();
            }

            Result();
        }
    }
}
