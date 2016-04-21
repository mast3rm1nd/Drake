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

namespace Drake
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

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%A3%D1%80%D0%B0%D0%B2%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5_%D0%94%D1%80%D0%B5%D0%B9%D0%BA%D0%B0");
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            double R, fp, ne, fl, fi, fc, L;

            /*
            double.TryParse(TextBox_R.Text, out R);
            double.TryParse(TextBox_fp.Text, out fp);
            double.TryParse(TextBox_ne.Text, out ne);
            double.TryParse(TextBox_fl.Text, out fl);
            double.TryParse(TextBox_fi.Text, out fi);
            double.TryParse(TextBox_fc.Text, out fc);
            double.TryParse(TextBox_L.Text, out L);*/

            try
            {

            R = Convert.ToDouble(TextBox_R.Text);
            fp = Convert.ToDouble(TextBox_fp.Text);
            ne = Convert.ToDouble(TextBox_ne.Text);
            fl = Convert.ToDouble(TextBox_fl.Text);
            fi = Convert.ToDouble(TextBox_fi.Text);
            fc = Convert.ToDouble(TextBox_fc.Text);
            L = Convert.ToDouble(TextBox_L.Text);
            
            Label_Answer.Content = "= " + (R * fp * ne * fl * fi * fc * L).ToString();
            }catch {}
        }
    }
}
