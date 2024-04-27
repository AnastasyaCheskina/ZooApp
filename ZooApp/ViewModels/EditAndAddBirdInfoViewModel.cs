using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddBirdInfoViewModel
    {
        bool isVisible;
        BirdInfo info;

        public EditAndAddBirdInfoViewModel()
        {
            info = new BirdInfo();
            isVisible = false;
        }

        public EditAndAddBirdInfoViewModel(BirdInfo info)
        {
            isVisible = true;
            this.info = info;
        }

        public bool IsVisible { get => isVisible; set => isVisible = value; }
        public BirdInfo Info { get => info; set => info = value; }
    }
}
