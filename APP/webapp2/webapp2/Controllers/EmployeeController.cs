using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using webapp2.Models;

namespace webapp2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ShowEmployeeData(int Eid, string Ename, string Dept)
        {
            Employee emp = new Employee();
            emp.EmployeeID = Eid;
            emp.EmployeebName = Ename;
            emp.Department = Dept;


            return View(emp);
        }

        public IActionResult GetEmployeeDetails()
        {

            return View();
        }
    }
}
