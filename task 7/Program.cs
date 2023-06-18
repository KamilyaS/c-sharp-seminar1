/* Напишите программу, которая выводит случайное трехзначное число и удаляет ввторую цифру этого числа
456 ->46
782 ->72
918 ->98 */

/*Random rand = new Random();
int numberA = rand.Next(100, 1000);
Console.WriteLine(numberA);
Console.Write(numberA/100);
Console.Write(numberA%10);*/

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

/*int numberA = number / 100;
int numberB = number % 10;
int result = numberA * 10 + numberA;
Console.WriteLine(result);*/

int result = (number / 100) * 10 + (number %10);
Console.WriteLine(result);
