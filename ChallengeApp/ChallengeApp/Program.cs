string name = "Ewa";
int age = 33;
//Man, man, women, Women
string gender = "women";


if (gender == "Women" || gender == "women")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        if (name == "Ewa" && age == 33) 
            {
            Console.WriteLine("Jestem w lini 9");
            }
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Jestem w lini 9");
    }
    else
    {
        Console.WriteLine("END PROGRAM ");
    }
}