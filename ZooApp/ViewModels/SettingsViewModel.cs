using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class SettingsViewModel
    {
        List<Food> foods;
        List<Home> homes;
        List<TypeFood> typeFood;
        List<BirdInfo> birdInfo;
        List<ReptileInfo> reptileInfo;

        public SettingsViewModel()
        {
            foods = ViewModelBase.database.Foods.ToList();
            homes = ViewModelBase.database.Homes.ToList();
            typeFood = ViewModelBase.database.TypeFoods.ToList();
            birdInfo = ViewModelBase.database.BirdInfoes.ToList();
            reptileInfo = ViewModelBase.database.ReptileInfoes.ToList();
        }

        public List<Food> Foods { get => foods; set => foods = value; }
        public List<Home> Homes { get => homes; set => homes = value; }
        public List<TypeFood> TypeFood { get => typeFood; set => typeFood = value; }
        public List<BirdInfo> BirdInfo { get => birdInfo; set => birdInfo = value; }
        public List<ReptileInfo> ReptileInfo { get => reptileInfo; set => reptileInfo = value; }
    }
}
