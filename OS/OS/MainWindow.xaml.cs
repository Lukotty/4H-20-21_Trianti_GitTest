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
using RubricaApplication;

namespace OS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void InitializeXAML()
        {
            mainGrid.Background = new SolidColorBrush(Color.FromRgb(120, 111, 166));
        }
        public MainWindow()
        {
            InitializeComponent();
            InitializeXAML();
        }

        private void btnRubrica_Click(object sender, RoutedEventArgs e)
        {
            RubricaApplication.MainWindow RubricaWindow= new RubricaApplication.MainWindow();
            Visibility = Visibility.Collapsed;
            RubricaWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            RubricaWindow.ShowDialog();
            Visibility = Visibility.Visible;
        }
    }
}
