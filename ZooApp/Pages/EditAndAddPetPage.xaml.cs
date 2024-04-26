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
    /// Логика взаимодействия для EditAndAddPetPage.xaml
    /// </summary>
    public partial class EditAndAddPetPage : Page
    {
        EditAndAddPetViewModel viewModel;
        public EditAndAddPetPage()
        {
            InitializeComponent();
            viewModel = new EditAndAddPetViewModel();
            DataContext = viewModel;
        }
        public EditAndAddPetPage(Pet pet)
        {
            InitializeComponent();
            viewModel = new EditAndAddPetViewModel(pet);
            DataContext = viewModel;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.IdDoctor != 0 && viewModel.IdFood != 0 && viewModel.IdHome != 0 && viewModel.IdSex != 0 && viewModel.IdSmotritel != 0 && viewModel.Pet.name != null && viewModel.Pet.name != string.Empty && viewModel.Pet.birthday != null)
            {
                if (viewModel.Pet.id == 0)
                {
                    ViewModelBase.database.Pets.Add(viewModel.Pet);
                }
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
            }
            else MessageBox.Show("Заполнены не все обязательные поля");
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int id = Convert.ToInt32(button.Tag);
            var currentPet = ViewModelBase.database.Pets.FirstOrDefault(x => x.id == id);
            if (currentPet != null)
            {
                ViewModelBase.database.Pets.Remove(currentPet);
                ViewModelBase.database.SaveChanges();
                MessageBox.Show("Питомец был удален");
                ViewModelBase.MainFrame.Navigate(new PetsPage());
            }
            else MessageBox.Show("Что-то пошло не по плану");
        }
    }
}
