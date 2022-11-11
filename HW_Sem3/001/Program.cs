/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
    Console.WriteLine("Введите пятизначное число.");
    int number = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < 100000; i++)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
        Console.WriteLine($"Число {number} является полиндромом");
        } 
       else
        {
            Console.WriteLine($"Число {number} НЕ является полиндромом");
        }                
    }
//int Num = 0;