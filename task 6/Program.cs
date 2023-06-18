/* Напишите программу, которая выводит случайное числов из отрезка [10,99] и показывает наибольшую цифру числа
78 ->8
12 ->2
85 ->8 */

Random rand = new Random();
int randomNumber = rand.Next(10, 100);
//int randomNumber = new Random().Next(10, 100); //[10, 100) такая конструкция громоздская, при работе с массивом то эта функция будет занимать большее количество памяти

Console.WriteLine(randomNumber);

//int leftNumber = randomNumber / 10;
//int rightNumber = randomNumber % 10;

if (randomNumber / 10 > randomNumber % 10)
{
    Console.WriteLine($"leftNumber more than -> {randomNumber / 10}");
}
else if (randomNumber % 10 > randomNumber / 10)
{
    Console.WriteLine($"rightNumber more than -> {randomNumber % 10}");
}
else 
{
    Console.WriteLine("The numbers are equal");
}