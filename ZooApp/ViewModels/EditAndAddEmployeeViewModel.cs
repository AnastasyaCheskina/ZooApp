using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Model;

namespace ZooApp.ViewModels
{
    public class EditAndAddEmployeeViewModel: INotifyPropertyChanged
    {
        Employee employee;
        List<Employee> employees;
        int? idEmployee;
        List<MarriedStatu> marriedStatu;
        int idStatus;
        bool isVisible;

        public event PropertyChangedEventHandler PropertyChanged;
        public int IdStatus
        {
            get { return idStatus; }
            set
            {
                idStatus = value;
                if (idStatus != 0) Employee.id_married_status = idStatus;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdStatus)));
            }
        }
        public int? IdEmployee
        {
            get { return idEmployee; }
            set
            {
                idEmployee = value;
                if (idEmployee != 0 && idEmployee != null) Employee.id_wife_hasbend = idEmployee;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IdEmployee)));
            }
        }

        public List<Employee> Employees { get => employees; set => employees = value; }
        public List<MarriedStatu> MarriedStatu { get => marriedStatu; set => marriedStatu = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public EditAndAddEmployeeViewModel(Employee employee)
        {
            this.employee = employee;
            InitLists();
            idEmployee = employee.id_wife_hasbend;
            idStatus = employee.id_married_status;
            isVisible = true;
        }

        public EditAndAddEmployeeViewModel()
        {
            employee = new Employee() { id = 0};
            InitLists();
            idEmployee = 0;
            idStatus = 0;
            isVisible = false;
        }
        private void InitLists()
        {
            employees = ViewModelBase.database.Employees.ToList();
            employees.Add(new Employee() { id = 0, name = "Не выбрано" });
            employees = employees.OrderBy(x => x.id).ToList();

            marriedStatu = ViewModelBase.database.MarriedStatus.ToList();
            marriedStatu.Add(new MarriedStatu() { id = 0, name = "Не выбрано" });
            marriedStatu = marriedStatu.OrderBy(marriedStatu => marriedStatu.id).ToList();
        }
    }
}
