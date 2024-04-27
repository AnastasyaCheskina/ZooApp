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
    /// Логика взаимодействия для EditAndAddTypeFoodPage.xaml
    /// </summary>
    public partial class EditAndAddTypeFoodPage : Page
    {
        EditAndAddTypeFoodViewModel viewModel;
        public EditAndAddTypeFoodPage()
        {
            InitializeComponent();
            viewModel = new EditAndAddTypeFoodViewModel();
            DataContext = viewModel;
        }
        public EditAndAddTypeFoodPage(TypeFood info)
        {
            InitializeComponent();
            viewModel = new EditAndAddTypeFoodViewModel(info);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Info.name != null && viewModel.Info.name != string.Empty)
            {
                if (viewModel.IsVisible == false) ViewModelBase.database.TypeFoods.Add(viewModel.Info);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.TypeFoods.Remove(viewModel.Info);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Информация была удалена");
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
