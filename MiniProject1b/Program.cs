string firstName = "";
string formatedName = "";
string textAge = "";
int age;
int yearsLeft;
bool isValidAge;

Console.Write("Enter your first name: ");
firstName = Console.ReadLine();


do
{
    Console.Write("Enter your age: ");
    textAge = Console.ReadLine();

    isValidAge = int.TryParse(textAge, out age);
    if (isValidAge == false)
        {
        Console.WriteLine("You did not provide a valid age. You must enter numbers between 1 and 130 only!");
        }

    else if (age <= 0 || age >= 130)
    {
        Console.WriteLine("You did not enter a valid age. Must be between 1 and 130.");
    }
} while (isValidAge == false || age <= 0 || age > 130);


yearsLeft = 21 - age;

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formatedName = $"Professor {firstName}";
}
else
{
    formatedName = firstName;
}



if (age == 20)
{
    Console.WriteLine($"Hello {formatedName}, you should wait one more year before taking this class. 21 years old is recommended.");
}
else if (age >= 21)
{
    Console.WriteLine($"Welcome to the course {formatedName}.");
}
else
{
    Console.WriteLine($"Welcome {formatedName}, you should wait {yearsLeft} more years before taking this class. 21 years old is recommended.");
}
