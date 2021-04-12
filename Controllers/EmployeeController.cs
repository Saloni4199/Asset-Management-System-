using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvcProject.Models;
using System.Web;




namespace mvcProject.Controllers
{
    public class EmployeeController : Controller
    {   
        
        public IActionResult Index(){
            
            List<Employee> employeeList = EmployeeList.ReturnEmployeeList();
            return View(employeeList);
        }
        public IActionResult Details(Employee employee){

            return View(employee);
        }
        
        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create_Post(){
            
            Employee employee =new Employee();
            TryUpdateModelAsync(employee);

            if(ModelState.IsValid){
            EmployeeList.employeeList.Add(employee);
            return RedirectToAction("Index");
            }
            else{
                return View();
            }
        }
       
        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create_Get(){
            
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id){
            Employee employee = EmployeeList.ReturnEmployeeList().Single(emp => emp.Id == id);
            return View(employee);
        }
       
        
    }
}