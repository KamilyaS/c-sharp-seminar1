/* Напишите программу, которая принимает на вход два числа
и проверяет, является ли одно число квадратом другого
5, 25 -> yes
-4, 16 -> yes
25, 5 -> yes
8, 9 -> no */

Console.WriteLine("Add number 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add number 2");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB || numberB == numberA * numberA)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}