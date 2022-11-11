/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double GetNumber (uint a, uint b)
{
    double number = Math.Pow(a, b);
    return number;
}

uint EnterNumber (string message)
{
    uint userNumber;
    while (true) {
        Console.Write(message);

        if (uint.TryParse(Console.ReadLine(), out uint num)) {
            userNumber = num;
            break;
        }    
        else {
            Console.WriteLine($"{num} не является числом, повторите ввод.");
        }
    } 
    return userNumber;
}

uint aNumber = EnterNumber("Введите первое число: ");
uint bNumber = EnterNumber("Введите второе число: ");

double myNumber = GetNumber(aNumber, bNumber);

Console.WriteLine($"{aNumber} в степени {bNumber} будет {myNumber}.");