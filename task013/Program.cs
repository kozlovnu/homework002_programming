// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
{
    while (number > 1000)
    {
        number = number / 10;
    }
double result = number % 10;
Console.WriteLine(result);
}

else 
{
    Console.WriteLine("Your number is out of range");
}