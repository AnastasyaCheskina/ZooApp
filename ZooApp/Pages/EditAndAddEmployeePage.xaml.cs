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
    /// Логика взаимодействия для EditAndAddEmployeePage.xaml
    /// </summary>
    public partial class EditAndAddEmployeePage : Page
    {
        EditAndAddEmployeeViewModel viewModel;
        public EditAndAddEmployeePage()
        {
            InitializeComponent();
            viewModel = new EditAndAddEmployeeViewModel();
            DataContext = viewModel;
        }
        public EditAndAddEmployeePage(Employee employee)
        {
            InitializeComponent();
            viewModel = new EditAndAddEmployeeViewModel(employee);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.IdStatus != 0 && viewModel.Employee.name != null && viewModel.Employee.name != string.Empty && viewModel.Employee.birthday != null)
            {
                if (viewModel.Employee.id == 0)
                    ViewModelBase.database.Employees.Add(viewModel.Employee);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
            }
            else MessageBox.Show("Заполнены не все обязательные данные");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.database.Employees.Remove(viewModel.Employee);
            ViewModelBase.database.SaveChanges();
            MessageBox.Show("Сотрудник был успешно удален");
            ViewModelBase.MainFrame.Navigate(new EmployeePage());
        }
    }
}
