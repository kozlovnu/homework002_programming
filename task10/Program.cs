// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8 
//918 -> 1
Console.WriteLine("Enter your number between 100 and 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 1000)
{
    int two = number / 10;
    double result = two % 10;
    Console.WriteLine("The second number is " + result);
}
else 
{
    Console.WriteLine("Your number is out of range.");
}    
