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

namespace HarkaiDaniel_WPF_Kalkulator
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
            if (tbx_szam1Be.Text != "" && tbx_szam2Be.Text != "" && tbx_muveletiJel.Text != "")
            {
                if (double.TryParse(tbx_szam1Be.Text, out double szam1) && double.TryParse(tbx_szam2Be.Text, out double szam2))
                {
                    string eredmeny = "";
                    string muveletiJel = tbx_muveletiJel.Text;
                    if (muveletiJel == "+") eredmeny = osszead(szam1, szam2).ToString();
                    else if (muveletiJel == "-") eredmeny = kivonas(szam1, szam2).ToString();
                    else if (muveletiJel == "*") eredmeny = szorzas(szam1, szam2).ToString();
                    else if (muveletiJel == "/") eredmeny = osztas(szam1, szam2);
                    else MessageBox.Show("Nem megfelelő műveleti jelet adtál meg! (+, -, *, /)!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);

                    tbx_eredmeny.Text = eredmeny;

                }
                else
                {
                    MessageBox.Show("Nem számot adtál meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Mind a két számot és a műveleti jelet is meg kell adni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string osztas(double szam1, double szam2)
        {
            double eredmeny;

            if (szam2 != 0) eredmeny = szam1 / szam2;
            else return "0-val nem lehet osztani!";

            return eredmeny.ToString();

            
        }

        private double szorzas(double szam1, double szam2)
        {
            return szam1 * szam2;
        }

        private double kivonas(double szam1, double szam2)
        {
            return szam1 - szam2;
        }

        private double osszead(double szam1, double szam2)
        {
            return szam1 + szam2;
        }
    }
}
