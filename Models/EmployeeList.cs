using System.Collections.Generic;
namespace mvcProject.Models
{
    public class EmployeeList
    {
        public static List<Employee> employeeList = new List<Employee>(){

            new Employee(){
                 Id = 1,
                Name = "Saloni",
                Gender = "Female",
                City = "Ajmer"
            },
            new Employee(){
                 Id = 0,
                Name = "Sanjay",
                Gender = "Male",
                City = "Alwar"
            }
        };

        public static List<Employee> ReturnEmployeeList(){
            return employeeList;
        }

    }
}