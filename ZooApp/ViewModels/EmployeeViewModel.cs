using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EmployeeViewModel
    {
        List<Employee> employees;

        public EmployeeViewModel()
        {
            employees = ViewModelBase.database.Employees.ToList();
        }

        public List<Employee> Employees { get => employees; set => employees = value; }
    }
}
