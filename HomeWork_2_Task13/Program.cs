/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a;
 if (a >= 100)
{
    while (a > 999)
    a = a / 10;
    result = a % 10;
    Console.WriteLine($"Третья цифра: {result}");    
    }
else Console.WriteLine($"Третьей цифры нет ");
        