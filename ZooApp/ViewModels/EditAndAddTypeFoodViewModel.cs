using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddTypeFoodViewModel
    {
        bool isVisible;
        TypeFood info;

        public EditAndAddTypeFoodViewModel()
        {
            info = new TypeFood();
            isVisible = false;
        }

        public EditAndAddTypeFoodViewModel(TypeFood info)
        {
            isVisible = true;
            this.info = info;
        }

        public bool IsVisible { get => isVisible; set => isVisible = value; }
        public TypeFood Info { get => info; set => info = value; }
    }
}
