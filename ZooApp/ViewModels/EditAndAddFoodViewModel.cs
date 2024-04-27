using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddFoodViewModel : INotifyPropertyChanged
    {
        Food food;
        List<TypeFood> foods;
        int idSelected;
        bool isVisible;
        public EditAndAddFoodViewModel()
        {
            food = new Food();
            foods = ViewModelBase.database.TypeFoods.ToList();
            foods.Add(new TypeFood() { id = 0, name = "Не выбрано" });
            foods = foods.OrderBy(x => x.id).ToList();
            idSelected = 0;
            isVisible = false;
        }
        public EditAndAddFoodViewModel(Food food)
        {
            this.food = food;
            foods = ViewModelBase.database.TypeFoods.ToList();
            foods.Add(new TypeFood() { id = 0, name = "Не выбрано" });
            foods = foods.OrderBy(x => x.id).ToList();
            idSelected = food.id_type_food;
            isVisible = true;
        }

        public Food Food { get => food; set => food = value; }
        public List<TypeFood> Foods { get => foods; set => foods = value; }
        public int IdSelected
        {
            get => idSelected;
            set
            {
                idSelected = value;
                if (idSelected != 0) Food.id_type_food = idSelected;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(IdSelected)));
            }
        }

        public bool IsVisible { get => isVisible; set => isVisible = value; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
