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
    /// Логика взаимодействия для EditAndAddReptileInfo.xaml
    /// </summary>
    public partial class EditAndAddReptileInfo : Page
    {
        EditAndAddReptileInfoViewModel viewModel;
        public EditAndAddReptileInfo()
        {
            InitializeComponent();
            viewModel = new EditAndAddReptileInfoViewModel();
            DataContext = viewModel;
        }
        public EditAndAddReptileInfo(ReptileInfo info)
        {
            InitializeComponent();
            viewModel = new EditAndAddReptileInfoViewModel(info);
            DataContext = viewModel;
        }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Info.normalTemperature != null && viewModel.Info.normalTemperature != string.Empty && viewModel.Info.firstDate != null && viewModel.Info.secondDate != null)
            {
                if (viewModel.IsVisible == false) ViewModelBase.database.ReptileInfoes.Add(viewModel.Info);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.ReptileInfoes.Remove(viewModel.Info);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Информация была удалена");
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
