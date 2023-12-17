// STRING
string name = "John";
string concatenate = "1" + "1"; // The variable "total" is renamed to "concatenate".
Console.WriteLine(concatenate);

// CHAR
char character = 'A';
Console.WriteLine(character);

// INT
int number = 0;
int a = 1;
int b = 2;
int total = a + b;
Console.WriteLine(total);

// LONG
long longerNumber = 10000000000;

// FLOAT
float smallDecimal = 12.99F;
float x = 100.99F;
int y = 10;
float difference = x - y;
Console.WriteLine(difference);

// DOUBLE
double midDecimal = 100.123456789;

// DECIMAL
decimal bigDecimal = 100.1234567890123456789M;
Console.WriteLine(bigDecimal);

// BOOLEAN
bool isAlive = true;

// IF-ELSE
if (isAlive)
{
    Console.WriteLine("I'm alive.");
}

else
{
    Console.WriteLine("I'm a ghost.");
}

// WHILE-LOOP
int yearsToLive = 100;
while (isAlive && yearsToLive > 0)
{
    Console.WriteLine("I'm still alive.");
    yearsToLive--;
}