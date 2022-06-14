// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter your number of week day: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Today is a weekend");
}
else if (number > 1 && number < 6)
{
    Console.WriteLine("Today is a weekday");
}
else 
{
    Console.WriteLine("You entered the wrong number.");
}