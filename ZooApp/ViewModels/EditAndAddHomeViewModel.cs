using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddHomeViewModel
    {
        Home home;
        bool isVisible;

        public EditAndAddHomeViewModel()
        {
            home = new Home();
            isVisible = false;
        }

        public EditAndAddHomeViewModel(Home home)
        {
            this.home = home;
            isVisible = true;
        }

        public Home Home { get => home; set => home = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }
    }
}
