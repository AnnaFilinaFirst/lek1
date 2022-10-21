/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int result1 = number % 100;
    int result2 = result1 / 10;
    Console.WriteLine($"Вторая цифра трехзначного числа: {result2}");
}
else
{
    Console.WriteLine($"Некорректные данные");
}