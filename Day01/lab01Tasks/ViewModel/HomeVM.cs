using lab01Tasks.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Tasks.ViewModel
{
    public class HomeVM
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public HomeVM()
        {
            Employees = EmployeeMoocData.EmployeeList;
        }
    }
}
