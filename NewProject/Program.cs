
// VARIABLES AND DATA TYPES

DataTypes();

void DataTypes()
{
    string employeeName = "Daniel";       // Text
    int experience = 3;                   // Whole number
    long companyUsers = 5000000000L;      // Large whole number

    float temperature = 72.5f;            // Decimal
    double distance = 125.75;             // Decimal
    decimal accountBalance = 8450.75m;    // Money / precise decimal

    char department = 'A';                // Single character
    bool isActive = true;                  // true / false

    Console.WriteLine($"Employee: {employeeName}");
    Console.WriteLine($"Experience: {experience}");
    Console.WriteLine($"Users: {companyUsers}");
    Console.WriteLine($"Temperature: {temperature}");
    Console.WriteLine($"Distance: {distance}");
    Console.WriteLine($"Balance: {accountBalance}");
    Console.WriteLine($"Department: {department}");
    Console.WriteLine($"Active: {isActive}");
}

// Arithrmetic Operations
int totalItems = 47;
int boxes = 6;

Console.WriteLine(totalItems + boxes);
Console.WriteLine(totalItems - boxes);
Console.WriteLine(totalItems * boxes);
Console.WriteLine(totalItems / boxes);
Console.WriteLine(totalItems % boxes);
Console.WriteLine((double)totalItems / boxes);

// Comparison Operators

int requiredExperience = 3;
int candidateExperience = 5;

Console.WriteLine(candidateExperience == requiredExperience);
Console.WriteLine(candidateExperience != requiredExperience);
Console.WriteLine(candidateExperience > requiredExperience);
Console.WriteLine(candidateExperience < requiredExperience);
Console.WriteLine(candidateExperience >= requiredExperience);
Console.WriteLine(candidateExperience <= requiredExperience);


// Logical Operators

bool emailVerified = true;
bool passwordCorrect = true;
bool accountBlocked = false;

bool loginAllowed = emailVerified && passwordCorrect;
bool canContactSupport = emailVerified || passwordCorrect;

Console.WriteLine(loginAllowed);
Console.WriteLine(canContactSupport);
Console.WriteLine(accountBlocked);
Console.WriteLine(!accountBlocked);

// Assignment Operators

int rewardPoints = 100;

rewardPoints += 50;
Console.WriteLine(rewardPoints);

rewardPoints -= 20;
Console.WriteLine(rewardPoints);

rewardPoints *= 2;
Console.WriteLine(rewardPoints);

rewardPoints /= 2;
Console.WriteLine(rewardPoints);

rewardPoints %= 7;
Console.WriteLine(rewardPoints);






// Write a C# code to accept two integers and check whether they are equal or not.
// The code below accepts two integers from the user and compares them.

Console.WriteLine("Enter First Integer");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Integer");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Matched or Equal");
}
else
{
    Console.WriteLine("Not Equal");
}

//Write a C# Sharp program to check whether a given number is positive or negative.

Console.WriteLine("Enter a Number");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Positive Number");
}
else if (number < 0)
{
    Console.WriteLine("Negative Number");
}
else
{
    Console.WriteLine("Number is Zero");
}

//Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
Console.WriteLine("Enter Height in Centimeters");
int height = Convert.ToInt32(Console.ReadLine());

if (height < 150)
{
    Console.WriteLine("Short");
}
else if (height <= 165)
{
    Console.WriteLine("Average Height");
}
else if (height <= 195)
{
    Console.WriteLine("Tall");
}
else
{
    Console.WriteLine("Very Tall");
}

//Write a C# Sharp program to find the largest of three numbers.

Console.WriteLine("Enter First Number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Third Number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
{
    Console.WriteLine($"Largest Number is {firstNumber}");
}
else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
{
    Console.WriteLine($"Largest Number is {secondNumber}");
}
else
{
    Console.WriteLine($"Largest Number is {thirdNumber}");
}

//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
Console.WriteLine("Enter Roll Number");
int rollNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Student Name");
string name = Console.ReadLine();

Console.WriteLine("Enter Subject 1 Marks");
int mark1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Subject 2 Marks");
int mark2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Subject 3 Marks");
int mark3 = Convert.ToInt32(Console.ReadLine());

int total = mark1 + mark2 + mark3;

double percentage = total / 3.0;

Console.WriteLine($"Roll Number: {rollNo}");
Console.WriteLine($"Student Name: {name}");
Console.WriteLine($"Total Marks: {total}");
Console.WriteLine($"Percentage: {percentage}");

if (percentage >= 60)
{
    Console.WriteLine("First Division");
}
else if (percentage >= 50)
{
    Console.WriteLine("Second Division");
}
else if (percentage >= 40)
{
    Console.WriteLine("Third Division");
}
else
{
    Console.WriteLine("Fail");
}

//Write a program that checks a customer's eligibility for a discount based on their membership level and purchase amount.
//membership levels (Gold 5%, Silver 10%, Platinum 20%) discount(if purchase amount < 100 no discount , more than 100 apply discount)
Console.WriteLine("Enter Purchase Amount");
double amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Membership Level");
string membership = Console.ReadLine();

double discount = 0;

if (amount > 100)
{
    if (membership == "Gold")
    {
        discount = amount * 5 / 100;
    }
    else if (membership == "Silver")
    {
        discount = amount * 10 / 100;
    }
    else if (membership == "Platinum")
    {
        discount = amount * 20 / 100;
    }
}
else
{
    Console.WriteLine("No Discount");
}

double finalAmount = amount - discount;

Console.WriteLine($"Discount Amount: {discount}");
Console.WriteLine($"Final Amount: {finalAmount}");

//Write a switch statement that takes an integer variable representing a day of the week (1 for Monday, 2 for Tuesday, etc.) and prints the corresponding day name.
Console.WriteLine("Enter Day Number");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;

    case 6:
        Console.WriteLine("Saturday");
        break;

    case 7:
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Invalid Day Number");
        break;
}

//Write a program in C# Sharp to display the first 10 natural numbers using for loop.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Write a C# Sharp program to find the sum of the first 10 natural numbers using for loop.
int sum = 0;

for (int i = 1; i <= 10; i++)
{
    sum = sum + i;
}

Console.WriteLine($"Sum is {sum}");

//Write a program that takes a positive integer input from the user and calculates the sum of its digits using a loop.
Console.WriteLine("Enter a Positive Integer");
int inputNumber = Convert.ToInt32(Console.ReadLine());

int digitSum = 0;

while (inputNumber > 0)
{
    int digit = inputNumber % 10;

    digitSum = digitSum + digit;

    inputNumber = inputNumber / 10;
}

Console.WriteLine($"Sum of Digits is {digitSum}");

//Write a program that takes a string input from the user and uses a loop to reverse the string.
Console.WriteLine("Enter a String");
string text = Console.ReadLine();

string reversedText = "";

for (int i = text.Length - 1; i >= 0; i--)
{
    reversedText = reversedText + text[i];
}

Console.WriteLine($"Reversed String is {reversedText}");


//Write a program that uses a while loop to calculate the sum of all integers from 1 to 100.
int currentNumber = 1;
int totalSum = 0;

while (currentNumber <= 100)
{
    totalSum = totalSum + currentNumber;

    currentNumber++;
}

Console.WriteLine($"Sum is {totalSum}");

//Using do while loop, create a number guessing game between 1 and 100.
Random random = new Random();

int secretNumber = random.Next(1, 101);

int userGuess;

do
{
    Console.WriteLine("Guess a Number Between 1 and 100");
    userGuess = Convert.ToInt32(Console.ReadLine());

    if (userGuess > secretNumber)
    {
        Console.WriteLine("Too High");
    }
    else if (userGuess < secretNumber)
    {
        Console.WriteLine("Too Low");
    }
    else
    {
        Console.WriteLine("Correct Guess");
    }

}
while (userGuess != secretNumber);

//Using while loop, write a program that counts down from a user-specified number to zero.

Console.WriteLine("Enter a Number");
int countdownNumber = Convert.ToInt32(Console.ReadLine());

while (countdownNumber >= 0)
{
    Console.WriteLine(countdownNumber);

    countdownNumber--;
}

//Write a program that prints the multiplication table from 1 to 10 using nested for loops.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Table of {i}");

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }

    Console.WriteLine();
}