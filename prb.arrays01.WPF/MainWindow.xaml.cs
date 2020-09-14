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

namespace prb.arrays01.WPF
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
        enum numberNames { een, twee, drie, vier, vijf, zes }
        Random rnd;
        int[] numbers;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rnd = new Random();
        }

        private void btnThrow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lstDice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
