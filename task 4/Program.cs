// Нужно написать программу, которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N 

Console.WriteLine("Add number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
if (numberA >0) {numberB = -numberA;}
else {
    numberB = numberA;
    numberA = -numberA;
}
while (numberA >= numberB)
{
    Console.Write(numberB + " ");
    numberB++;
}