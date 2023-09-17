
var imie = "Ewa";
var płeć = 'k';
var wiek = 33;

if (płeć == 'k' && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (płeć == 'm' && wiek < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Osoba nie spełniająca parametrów programu");
}