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
using ZooApp.Model;
using ZooApp.ViewModels;

namespace ZooApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditAndAddHomePage.xaml
    /// </summary>
    public partial class EditAndAddHomePage : Page
    {
        EditAndAddHomeViewModel viewModel;
        public EditAndAddHomePage()
        {
            InitializeComponent();
            viewModel = new EditAndAddHomeViewModel();
            DataContext = viewModel;
        }
        public EditAndAddHomePage(Home home)
        {
            InitializeComponent();
            viewModel = new EditAndAddHomeViewModel(home);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Home.name != null && viewModel.Home.name != string.Empty)
            {
                if (viewModel.IsVisible == false) ViewModelBase.database.Homes.Add(viewModel.Home);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.Homes.Remove(viewModel.Home);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Информация была удалена");
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
