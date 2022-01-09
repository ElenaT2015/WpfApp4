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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDouble = rateDollar * sumDollar;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resDouble = rateGrivna * sumGrivna;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate3.Text);
            double sumEuro = Convert.ToDouble(sum3.Text);
            double resDouble = rateEuro * sumEuro;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate4.Text);
            double sumDrama = Convert.ToDouble(sum4.Text);
            double resDouble = rateDrama * sumDrama;
            resSum4.Text = resDouble.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rateDyuym = Convert.ToDouble(rate5.Text);
            double resDouble = rateDyuym*0.0254;
            resSum5.Text = resDouble.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rateFuty = Convert.ToDouble(rate6.Text);
            double resDouble = rateFuty * 0.3048;
            resSum6.Text = resDouble.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rateMuly = Convert.ToDouble(rate7.Text);
            double resDouble = rateMuly * 1609.344;
            resSum7.Text = resDouble.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double rateVersty = Convert.ToDouble(rate8.Text);
            double resDouble = rateVersty * 1067;
            resSum8.Text = resDouble.ToString();
        }
    }
}
