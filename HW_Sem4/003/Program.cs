/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/

int [] arr = {1,2,9,8,3,7,5,3};
//int exit = arr.Split(',');
void PrintArray (int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}");
    }
    //Console.WriteLine();
}
PrintArray(arr);



/*Console.WriteLine("Введите числа:");
string arr = Console.ReadLine();
string [] mass = arr.Split(',');
int [] array = new int [8];
Console.WriteLine($"{mass}");
*/