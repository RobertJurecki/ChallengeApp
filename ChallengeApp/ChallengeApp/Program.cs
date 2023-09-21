int number = 4594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] numberOfDigits = new int[10];

foreach (char letter in letters)
{
    for (int i = 0; i < 10; i++)
    {
        if (letter == numbers[i]) { numberOfDigits[i]++; }
    }

}
    Console.WriteLine("Wyniki dla liczby: " + number);

for (int i = 0; i < numberOfDigits.Length; i++)
{
    Console.WriteLine($"{i} => {numberOfDigits[i]}");
}