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
    /// Логика взаимодействия для PetsPage.xaml
    /// </summary>
    public partial class PetsPage : Page
    {
        public PetsPage()
        {
            InitializeComponent();
        }

        private void addNewPetBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBase.MainFrame.Navigate(new EditAndAddPetPage());
        }
    }
}
