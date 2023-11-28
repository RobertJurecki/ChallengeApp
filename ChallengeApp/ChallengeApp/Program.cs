using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade("Hans");
employee.AddGrade("3000");
employee.AddGrade(2);
employee.AddGrade('3');

var statistics1 = employee.GetStatisticWithForEach();
var statistics2 = employee.GetStatisticWithFor();
var statistics3 = employee.GetStatisticWithDoWhile();
var statistics4 = employee.GetStatisticWithWhile();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");