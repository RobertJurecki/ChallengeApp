Employee Employee1 = new Employee("Hans", "Klos", 35);
Employee Employee2 = new Employee("Janek", "Kos", 18);
Employee Employee3 = new Employee("Gustlik", "Jeleń", 25);

Employee1.AddScore(1);
Employee1.AddScore(2);
Employee1.AddScore(3);
Employee1.AddScore(4);
Employee1.AddScore(5);

Employee2.AddScore(5);
Employee2.AddScore(4);
Employee2.AddScore(1);
Employee2.AddScore(2);
Employee2.AddScore(1);

Employee3.AddScore(3);
Employee3.AddScore(3);
Employee3.AddScore(1);
Employee3.AddScore(2);
Employee3.AddScore(3);

List<Employee> Employees = new List<Employee>()
{
    Employee1, Employee2, Employee3 
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach(var Employee in Employees)
{
    if (Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        EmployeeWithMaxResult = Employee;
    }
        
}
Console.WriteLine($"Największą ilość punktów: {maxResult} uzyskał {EmployeeWithMaxResult.Name} {EmployeeWithMaxResult.Surname} lat {EmployeeWithMaxResult.Age}");

class Employee
{
    public string Name { get; }
    public string Surname { get; }
    public int Age { get; }
    private int result;

    public int Result
    {
        get { return result; }
    }

    public Employee(string name, string surname, int age) 
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public void AddScore(int score)
    {
        result += score;
    }
}