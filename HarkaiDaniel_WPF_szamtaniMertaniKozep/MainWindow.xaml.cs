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

namespace HarkaiDaniel_WPF_szamtaniMertaniKozep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_szam1Be.Text != "" && tbx_szam2Be.Text != "")
            {
                if (double.TryParse(tbx_szam1Be.Text, out double szam1) && double.TryParse(tbx_szam2Be.Text, out double szam2))
                {

                    double szamtaniKozep = (szam1 + szam2) / 2;
                    tbx_szamtaniKozep.Text = szamtaniKozep.ToString();
                    double mertaniKozep = Math.Sqrt(szam1 * szam2);
                    tbx_mertaniKozep.Text = mertaniKozep.ToString();

                } else
                {
                    MessageBox.Show("Nem számot adtál meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            } else
            {
                MessageBox.Show("Mind a két számot meg kell adni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
