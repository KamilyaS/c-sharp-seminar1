/* Напишите программу, которая принимает на ввод координаты
точки (X и Y), причем они не равны 0 и выдает номер четверти плоскости, в которой находится
эта точка */

int[] coordinates = new int[2];
System.Console.Write("Add coordinate X: ");
coordinates[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Add coordinate Y: ");
coordinates[1] = Convert.ToInt32(Console.ReadLine());

if (coordinates[0] > 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Point is in 1");
}
else if (coordinates[0] < 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Point is in 2");
}
else if (coordinates[0] < 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Point is in 3");
}
else if (coordinates[0] > 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Point is in 4");
}
else
{
    System.Console.WriteLine("Incorrect coordinates entered");
}