/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
Console.Write($"Из трех введенных вами чисел {numberA} является наибольшим");
}
else
{
    if (numberB > numberA && numberB > numberC)
{
Console.Write($"Из трех введенных вами чисел {numberB} является наибольшим");
}
else
{
    Console.Write($"Из трех введенных вами чисел {numberC} является наибольшим");
}
}