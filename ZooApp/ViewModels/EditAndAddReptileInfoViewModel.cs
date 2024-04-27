using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddReptileInfoViewModel
    {
        bool isVisible;
        ReptileInfo info;

        public EditAndAddReptileInfoViewModel()
        {
            info = new ReptileInfo();
            isVisible = false;
        }

        public EditAndAddReptileInfoViewModel(ReptileInfo info)
        {
            isVisible = true;
            this.info = info;
        }

        public bool IsVisible { get => isVisible; set => isVisible = value; }
        public ReptileInfo Info { get => info; set => info = value; }
    }
}
