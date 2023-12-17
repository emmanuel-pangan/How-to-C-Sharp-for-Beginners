// For loop is a fancier while loop with initialization and iterator.
string[] fruits = { "Apple", "Orange", "Banana" };

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]);
}

string[][] foods =
{
    new string[] { "Apple", "Orange", "Banana" },
    new string[] { "Potato", "Carrot", "Cabbage" },
    new string[] { "Pizza", "Fries", "Burger" },
};

for (int i = 0; i < foods.Length; i++)
{
    for (int j = 0; j < foods[i].Length; j++)
    {
        Console.Write(foods[i][j] + " ");
    }

    Console.WriteLine();
}