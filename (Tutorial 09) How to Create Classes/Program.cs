class Program
{
    static void Main(string[] args)
    {
        // Class is a blueprint for creating objects.
        // Objects are instances of a class that can hold fields and methods.

        Cat cat1 = new Cat();
        cat1.name = "Garfield";
        cat1.Eat("lasagna");

        Cat cat2 = new Cat();
        cat2.name = "Tom";
        cat2.Eat();
    }
}

class Cat
{
    public string name;

    public void Eat(string food = "")
    {
        if (string.IsNullOrEmpty(food))
        {
            Console.WriteLine($"{name} is hungry.");
        }

        else
        {
            Console.WriteLine($"{name} eats {food}.");
        }
    }
}