/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine ("Enter a number: ");
 int dayofweek = Convert.ToInt32(Console.ReadLine());
if (dayofweek == 6 || dayofweek == 7) 
Console.WriteLine ("day of rest");
 else if (dayofweek <= 5) 
 Console.WriteLine ("working day");
 else if (dayofweek > 7) Console.WriteLine ("Error: There are only 7 days in the week!");
 
