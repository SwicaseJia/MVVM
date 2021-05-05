using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Tasks.Model
{
    public static class EmployeeMoocData
    {
        public static ObservableCollection<Employee> EmployeeList = new ObservableCollection<Employee>()
        {
            new Employee
            {
                Id=1,
                Name="Ali",
                Image="/Images/male.jpg",
                Gender = Gender.Male,
                Salary = 2000
         
            },
            new Employee
            {
                Id=2,
                Name="Lila",
                Image="/Images/female.jpg",
                Gender = Gender.Female,
                Salary = 2000

            },
            new Employee
            {
                Id=3,
                Name="Hamada",
                Image="/Images/male.jpg",
                Gender = Gender.Male,
                Salary = 2000

            },
            new Employee
            {
                Id=4,
                Name="Fatakat",
                Image="/Images/female.jpg",
                Gender = Gender.Female,
                Salary = 2000

            },
        };

    }
}
