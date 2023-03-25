using SEDC.CSharpBasic.Homework7.Library;

var employees = new List<Employee>
{
    new Employee("John", "Doe", Role.Manager, 50000),
    new Manager("Tose", "Todorovski", Role.Manager, 50000),
    new SalesPerson("Jane", "Smith", 40000),
};

foreach (Employee employee in employees)
{
    employee.PrintInfo();
}


