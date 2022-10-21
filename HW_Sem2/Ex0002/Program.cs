/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int[] array = {1,2,3,4,5,6,7};
Console.WriteLine("Введите порядковый номер дня недели: ");
int day = int.Parse(Console.ReadLine());


/*int Day(int[] array)
{
    int count = array.Length;
    int index = 0;
}
index++;
*/
if ( day == array[0] || day == array[1] || day == array[2] || day == array[3] || day == array[4])

{
    Console.WriteLine("No");
}
else
{
    if ( day == array[5] || day == array[6])

{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}
}