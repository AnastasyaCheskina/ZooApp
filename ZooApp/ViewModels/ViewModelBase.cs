using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public static class ViewModelBase
    {
        public static Frame MainFrame = new Frame();
        public static ZooBaseEntities database = new ZooBaseEntities();
    }
}
