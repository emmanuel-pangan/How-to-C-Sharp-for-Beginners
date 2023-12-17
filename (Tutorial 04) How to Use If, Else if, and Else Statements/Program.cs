// IF-ELSE STATEMENTS
Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

// If statement allow us to add decisions to our codes.
bool isAgeGreaterThan18 = age > 18;
if (isAgeGreaterThan18)
{
    Console.WriteLine("You're an adult.");
    Console.WriteLine("Please enter your salary:");
    decimal salary = decimal.Parse(Console.ReadLine());
    if (salary > 1)
    {
        Console.WriteLine("Your salary is greater than $1.");
    }
}

else if (age > 12)
{
    Console.WriteLine("You're a teen.");
}

else if (age > 6)
{
    Console.WriteLine("You're an elementary student.");
}

else
{
    Console.WriteLine("You're still a kid.");
}