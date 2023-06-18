/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23
14 -> no
46 -> no
161 -> yes */

Console.WriteLine("Add number 1");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} -> Yes");
}
else 
{
    Console.WriteLine($"{number} -> No");
}
