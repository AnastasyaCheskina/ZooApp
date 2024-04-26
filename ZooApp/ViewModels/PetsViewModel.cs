using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class PetsViewModel :INotifyPropertyChanged
    {
        List<Pet> pets;
        List<TypePet> types;
        int idType;

        public PetsViewModel()
        {
            pets = ViewModelBase.database.Pets.ToList();
            types = ViewModelBase.database.TypePets.ToList();
            types.Add(new TypePet() { id = 0, name = "Все питомцы" });
            types = types.OrderBy(x => x.id).ToList();
            idType = 0;
        }
        public int IdType
        {
            get { return idType; } 
            set
            {
                idType = value;
                Sort();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdType)));
            }
        }
        public List<Pet> Pets
        {
            get { return pets; }
            set
            {
                pets = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Pets)));
            }
        }

        public List<TypePet> Types { get => types; set => types = value; }

        private void Sort()
        {
            var tempPets = ViewModelBase.database.Pets.ToList();
            if (idType != 0)
            {
                tempPets = tempPets.Where(x=>x.id_type == idType).ToList();
            }
            Pets = tempPets;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
