/* Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат
точек в этой четверти (x и y) */

/*System.Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("X > 0 && Y > 0");
}
else if (number == 2)
{
    System.Console.WriteLine("X < 0 && Y > 0");
}
else if (number == 3)
{
    System.Console.WriteLine("X < 0 && Y < 0");
}
else if (number == 4)
{
    System.Console.WriteLine("X > 0 && Y < 0");
}
else 
{
    System.Console.WriteLine("Incorrect");
}*/ 

// решение через помещение координат в массив и обращение к массиву оптимизирует код

System.Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
string [] array = {"X > 0 && Y > 0", "X < 0 && Y > 0","X < 0 && Y < 0","X > 0 && Y < 0"};

if (number >0 && number <5)
{
    System.Console.WriteLine(array[number-1]);
}
else 
{
    System.Console.WriteLine("Incorrect");
}