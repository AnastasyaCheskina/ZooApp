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
    /// Логика взаимодействия для EditAndAddBirdInfo.xaml
    /// </summary>
    public partial class EditAndAddBirdInfo : Page
    {
        EditAndAddBirdInfoViewModel viewModel;
        public EditAndAddBirdInfo()
        {
            InitializeComponent();
            viewModel = new EditAndAddBirdInfoViewModel();
            DataContext = viewModel;
        }
        public EditAndAddBirdInfo(BirdInfo info)
        {
            InitializeComponent();
            viewModel = new EditAndAddBirdInfoViewModel(info);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Info.countryName != null && viewModel.Info.countryName != string.Empty && viewModel.Info.firstDate != null && viewModel.Info.secondDate != null)
            {
                if (viewModel.IsVisible == false) ViewModelBase.database.BirdInfoes.Add(viewModel.Info);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.BirdInfoes.Remove(viewModel.Info);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Информация была удалена");
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
