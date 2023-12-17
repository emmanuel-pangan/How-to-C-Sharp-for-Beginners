// Variables like this becomes messy.
string student1 = "John";
string student2 = "Michael";
string student3 = "Petra";

// To solve this, you can make an array.
string[] students = { "John", "Michael", "Petra" };

Console.WriteLine("Student Name: " + students[students.Length - 1]);

// You can also use other types aside from string.
int[] ages = new int[3];
ages[0] = 12;
ages[1] = 17;
ages[2] = 24;

double[] grades = new double[3];
grades[0] = 75.0;
grades[1] = 80.5;
grades[2] = 97.1;