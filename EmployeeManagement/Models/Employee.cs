public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
}
public static List<Employee> GetEmployees()
{
    // Object initializer
    var employee1 = new Employee { FirstName = "Shreejana", Surname = "Yonzon", Address = "Ktm", Salary = 100.0 };
    var employee2 = new Employee { FirstName = "Ram", Surname = "Shrestha", Address = "Bhaktapur", Salary = 10000.0 };
    var employee3 = new Employee { FirstName = "Sushmita", Surname = "Acharya", Address = "Ktm", Salary = 100.0 };
    var employee4 = new Employee { FirstName = "Dinesh", Surname = "Ghimire", Address = "Ktm", Salary = 100.0 };
    var employee5 = new Employee { FirstName = "Soham", Surname = "Neupane", Address = "Ktm", Salary = 100.0 };
    var employee6 = new Employee { FirstName = "Bishal", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };

    var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
}