
var name = "Ewa";
var sex = 'k';
var age = 33;

if (sex == 'k' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine(name + ", lat " + age);
}