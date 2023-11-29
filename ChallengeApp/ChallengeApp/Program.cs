using ChallengeApp;


Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var emploee = new Employee();

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: Zakończenie pracy q");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    emploee.AddGrade(input);
}

var statistics = emploee.GetStatistic();
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Minimalna ocena: {statistics.Min}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Średnia ocen w postaci literowej: {statistics.AverageLetter}");
