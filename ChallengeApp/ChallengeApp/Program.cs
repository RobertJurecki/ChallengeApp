using ChallengeApp;
using System;


Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("==========================================");
Console.WriteLine();

var emploee = new Employee();
Console.WriteLine("Wprowadź oceny pracownika: \nZakończenie pracy q\n");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        emploee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = emploee.GetStatistic();
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Średnia ocen w postaci literowej: {statistics.AverageLetter}");
