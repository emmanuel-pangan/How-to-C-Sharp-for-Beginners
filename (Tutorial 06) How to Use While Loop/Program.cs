// While loop repeats the code while its condition is TRUE.
double tuitionFee = 5000;

while (tuitionFee > 0)
{
    Console.WriteLine($"Tuition Fee:\n{tuitionFee}");
    Console.WriteLine("Please enter your new payment:");
    double payment = double.Parse(Console.ReadLine());

    // If payment is zero or negative.
    if (payment <= 0)
    {
        // Skip the rest of the codes.
        continue;
    }

    // If payment is greater than the tuition fee.
    if (payment > tuitionFee)
    {
        // Get the change.
        double change = payment - tuitionFee;
        Console.WriteLine($"Your change is:\n{change}");
        tuitionFee = 0;
        break;
    }

    // Subtract the payment from the tuition fee.
    tuitionFee -= payment;
}

Console.WriteLine("Your tuition fee is now fully paid.");