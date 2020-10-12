using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Employee.GetEmployees();
        return View(employees);


        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {
        var employees = Employee.GetEmployees();
        var Employee = employees.FirstOrDefault(x => x.FirstName == firstName).First();
        return View(employee);

    }

}