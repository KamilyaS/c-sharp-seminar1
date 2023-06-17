// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Add numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if ((numberB * numberB) == numberA)
{
    Console.WriteLine("Yes");
}

else 
{
    Console.WriteLine("No");
}