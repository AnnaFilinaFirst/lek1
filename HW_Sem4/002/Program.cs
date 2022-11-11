/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

while (num > 9)
{
    int firstNum = num / 10;
    int preResult = num % 10;
    //int result = preResult + (preResult % 10);
    int fin = firstNum + preResult;
    Console.WriteLine($"Сумма цифр в числе {num} равна {fin}");
    break;
}

/*Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{   
    sum += i; // sum = sum + i; +=, -=, *=, /=
}

Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
*/