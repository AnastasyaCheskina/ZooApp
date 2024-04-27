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
    /// Логика взаимодействия для EditAndAddFoodPage.xaml
    /// </summary>
    public partial class EditAndAddFoodPage : Page
    {
        EditAndAddFoodViewModel viewModel;
        public EditAndAddFoodPage()
        {
            InitializeComponent();
            viewModel = new EditAndAddFoodViewModel();
            DataContext = viewModel;
        }
        public EditAndAddFoodPage(Food food)
        {
            InitializeComponent();
            viewModel = new EditAndAddFoodViewModel(food);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Food.name != null && viewModel.Food.name != string.Empty && viewModel.IdSelected!= 0)
            {
                if (viewModel.IsVisible == false) ViewModelBase.database.Foods.Add(viewModel.Food);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.Foods.Remove(viewModel.Food);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Информация была удалена");
            ViewModelBase.MainFrame.Navigate(new SettingsPage());
        }
    }
}
