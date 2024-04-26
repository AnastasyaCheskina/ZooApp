using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddPetViewModel: INotifyPropertyChanged
    {
        Pet pet;
        bool isNew;

        public event PropertyChangedEventHandler PropertyChanged;

        List<AllSex> allSexes;
        int idSex;

        List<Food> foods;
        int idFood;

        List<TypePet> typePet;
        int? idTypePet;

        List<Home> homes;
        int idHome;

        List<Employee> employees;
        int idSmotritel;
        int idDoctor;

        public int IdSex
        {
            get { return idSex; } 
            set 
            { 
                idSex = value;
                if (idSex != 0) Pet.id_sex = idSex;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(IdSex)));
            }
        }

        public int IdFood
        {
            get { return idFood; }
            set
            {
                idFood = value;
                if (idFood != 0) Pet.id_food = idFood;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdFood)));
            }
        }

        public int? IdTypePet
        {
            get { return idTypePet; }
            set
            {
                idTypePet = value;
                if (idTypePet != 0 && idTypePet != null) Pet.id_type = idTypePet;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdTypePet)));
            }
        }
        public int IdHome
        {
            get { return idHome; }
            set
            {
                idHome = value;
                if (idHome != 0) Pet.id_home = idHome;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdHome)));
            }
        }
        public int IdSmotritel
        {
            get { return idSmotritel; }
            set
            {
                idSmotritel = value;
                if (idSmotritel != 0) Pet.id_smotritel = idSmotritel;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdSmotritel)));
            }
        }
        public int IdDoctor
        {
            get { return idDoctor; }
            set
            {
                idDoctor = value;
                if (idDoctor != 0) Pet.id_doctor = idDoctor;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdDoctor)));
            }
        }
        public Pet Pet
        {
            get { return pet; }
            set
            {
                pet = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Pet)));
            }
        }
        public bool IsNew { get => isNew; set => isNew = value; }
        public List<AllSex> AllSexes { get => allSexes; set => allSexes = value; }
        public List<Food> Foods { get => foods; set => foods = value; }
        public List<TypePet> TypePet { get => typePet; set => typePet = value; }
        public List<Home> Homes { get => homes; set => homes = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }

        public EditAndAddPetViewModel(Pet pet)
        {
            this.pet = pet;
            isNew = true;
            InitLists();
            idSex = pet.id_sex;
            idFood = pet.id_food;
            if (pet.id_type == null) idTypePet = 0;
            else idTypePet = pet.id_type;
            idHome = pet.id_home;
            idSmotritel = pet.id_smotritel;
            idDoctor = pet.id_doctor;
        }

        public EditAndAddPetViewModel()
        {
            pet = new Pet() { id = 0 };
            isNew = false;
            InitLists();
            idSex = 0;
            idFood = 0;
            idTypePet = 0;
            idHome = 0;
            idSmotritel = 0;
            idDoctor = 0;
        }
        private void InitLists()
        {
            allSexes = ViewModelBase.database.AllSexes.ToList();
            allSexes.Add(new AllSex() { id = 0, name = "Не выбрано" });
            allSexes = allSexes.OrderBy(x=>x.id).ToList();

            foods = ViewModelBase.database.Foods.ToList();
            foods.Add(new Food() { id = 0, name = "Не выбрано" });
            foods = foods.OrderBy(x=>x.id).ToList();

            typePet = ViewModelBase.database.TypePets.ToList();
            typePet.Add(new TypePet() { id = 0, name = "Не выбрано" });
            typePet = typePet.OrderBy(x => x.id).ToList();

            homes = ViewModelBase.database.Homes.ToList();
            homes.Add(new Home() { id = 0, name = "Не выбрано" });
            homes = homes.OrderBy(homes=>homes.id).ToList();

            employees = ViewModelBase.database.Employees.ToList();
            employees.Add(new Employee() { id = 0, name = "Не выбрано" });
            employees = employees.OrderBy(x => x.id).ToList();
        }
    }
}
