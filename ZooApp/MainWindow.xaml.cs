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
using ZooApp.Pages;
using ZooApp.ViewModels;

namespace ZooApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModelBase.MainFrame = mainFrame;
            ViewModelBase.MainFrame.Navigate(new PetsPage());
        }

        private void petBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new PetsPage());
        }

        private void employeeBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EmployeePage());
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
