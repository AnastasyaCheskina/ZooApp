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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }

        private void addNewEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddEmployeePage());
        }

        private void editEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int id = Convert.ToInt32(button.Tag);
            var employee = ViewModelBase.database.Employees.FirstOrDefault(x=>x.id == id);
            if (employee != null)
            {
                ViewModelBase.MainFrame.Navigate(new EditAndAddEmployeePage(employee));
            }
            else MessageBox.Show("Что-то пошло не так");
        }
    }
}
