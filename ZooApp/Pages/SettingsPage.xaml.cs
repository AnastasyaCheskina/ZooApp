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
using ZooApp.ViewModels;

namespace ZooApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void addNewFoodBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddFoodPage());
        }

        private void addNewTypeFoodBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddTypeFoodPage());
        }

        private void addNewHomeBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddHomePage());
        }

        private void addNewBirdInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddBirdInfo());
        }

        private void addNewReptileInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddReptileInfo());
        }
    }
}
