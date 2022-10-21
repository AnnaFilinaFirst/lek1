/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

while (number > 999)
{
   number = number / 10;
}
//Console.WriteLine($"получилось число {number}");
if (number >= 100 && number <= 999)
{
    int result1 = number % 100;
    int result2 = result1 % 10;
    Console.WriteLine($"Третья цифра числа: {result2}");
}
else
{
    if(number >= 0 && number <=99)
    {
        Console.WriteLine("Число не имеет третьей цифры");
    }
    else
    {
        Console.WriteLine("Введите положительное число");
    }
}