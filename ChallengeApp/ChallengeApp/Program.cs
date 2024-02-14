using ChallengeApp;
using System;


Console.WriteLine("================================");
Console.WriteLine("|                              |");
Console.WriteLine("| Program do oceny pracowników |");
Console.WriteLine("|                              |");
Console.WriteLine("================================");
Console.WriteLine();

var employee = new EmployeeInFile("Hans", "Klos");
employee.GradeAdded += EmployeeGradeAdded;

Console.WriteLine("Wprowadź oceny pracownika: \nZakończenie pracy q\n");

void EmployeeGradeAdded(object seder, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj nową ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistic();
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Średnia ocen w postaci literowej: {statistics.AverageLetter}");
