using ChallangeApp;

Employee employee1 = new Employee("Jan", "Kowalski", 33);
Employee employee2 = new Employee("Magda", "Baklazan", 21);
Employee employee3 = new Employee("Jacek", "Nowak", 28);
AddingPoints();
var bestEmployee = BestEmployee();
Console.WriteLine("Najwięcej punktów otrzymał/a: " + bestEmployee.Name + " " + bestEmployee.Surname + ", a suma jego/jej punktów wyniosła: " + bestEmployee.Points); ;

void AddingPoints()
{
    Random rand = new Random();
    employee1.AddPoints(rand.Next(0, 10));
    employee1.AddPoints(rand.Next(0, 10));
    employee1.AddPoints(rand.Next(0, 10));
    employee2.AddPoints(rand.Next(0, 10));
    employee2.AddPoints(rand.Next(0, 10));
    employee2.AddPoints(rand.Next(0, 10));
    employee3.AddPoints(rand.Next(0, 10));
    employee3.AddPoints(rand.Next(0, 10));
    employee3.AddPoints(rand.Next(0, 10));
}
Employee BestEmployee()
{
    List<Employee> pointsOfEmployees = new List<Employee>()
    {
        employee1, employee2, employee3
    };
    int maxPoints = -1;
    Employee bestEmployee = null;

    foreach (var employee in pointsOfEmployees)
    {
        if (employee.Points > maxPoints)
        {
            bestEmployee = employee;
            maxPoints = employee.Points;
        }
    }
    return bestEmployee;
}