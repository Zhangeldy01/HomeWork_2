/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8 
918 -> 1 */

int GetRandomNumber()
    {
      return new Random().Next(100, 1000);
    }
void ShowRandomNumber (int number)
    {
    Console.WriteLine($"Случайное трехзначное число: {number}");
    int result = ((number / 10) % 10);
    Console.WriteLine($"Вторая цифра: {result}");
    }
ShowRandomNumber(GetRandomNumber());