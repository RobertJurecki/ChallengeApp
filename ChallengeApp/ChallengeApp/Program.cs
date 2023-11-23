using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade("Hans");
employee.AddGrade("3000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistic();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");