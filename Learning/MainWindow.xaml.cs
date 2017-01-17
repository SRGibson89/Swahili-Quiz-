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

namespace Learning
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

        private void btnanimals_Click(object sender, RoutedEventArgs e)
        {
            Animals new_win = new Animals();
            new_win.ShowDialog();
        }

        private void btnfood_Click(object sender, RoutedEventArgs e)
        {
            Food new_win = new Food();
            new_win.ShowDialog();
        }
    }
}
